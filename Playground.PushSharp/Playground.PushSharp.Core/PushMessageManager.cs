using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using PushSharp;
using PushSharp.Apple;
using PushSharp.Core;

namespace Playground.PushSharp.Core
{
    public class PushMessageManager
    {
        private PushBroker Push { get; set; }

        private List<ILogger> Loggers { get; set; }

        public string AppleCertificateLocation { get; set; }

        public string AppleDeviceToken { get; set; }

        public string ApplePassword { get; set; }

        private bool ShouldSendToApple
        {
            get
            {
                return !string.IsNullOrWhiteSpace(AppleCertificateLocation)
                    && !string.IsNullOrWhiteSpace(AppleDeviceToken)
                    && !string.IsNullOrWhiteSpace(ApplePassword);
            }
        }

        public static PushMessageManager Create()
        {
            return new PushMessageManager();
        }

        public PushMessageManager()
        {
            Push = new PushBroker();
            Push.OnNotificationSent += NotificationSent;
            Push.OnChannelException += ChannelException;
            Push.OnServiceException += ServiceException;
            Push.OnNotificationFailed += NotificationFailed;
            Push.OnDeviceSubscriptionExpired += DeviceSubscriptionExpired;
            Push.OnDeviceSubscriptionChanged += DeviceSubscriptionChanged;
            Push.OnChannelCreated += ChannelCreated;
            Push.OnChannelDestroyed += ChannelDestroyed;

            Loggers = new List<ILogger>();
        }

        public virtual PushMessageManager WithLoggers(params ILogger[] loggers)
        {
            Loggers.AddRange(loggers);
            return this;
        }

        public virtual async void Send(string alertMessage, int numOfBadges = 0)
        {
            if (string.IsNullOrWhiteSpace(alertMessage)) { return; }
            if (numOfBadges < 0) { return; }

            await Task.Run(() =>
            {
                if (ShouldSendToApple)
                {
                    byte[] appleCertification = File.ReadAllBytes(AppleCertificateLocation);
                    Push.RegisterAppleService(new ApplePushChannelSettings(appleCertification, ApplePassword));
                    try
                    {
                        Push.QueueNotification(new AppleNotification(AppleDeviceToken)
                            .WithAlert(alertMessage)
                            .WithBadge(numOfBadges));
                    }
                    catch (NotificationFailureException e)
                    {
                        Loggers.ForEach(x => x.Write(e.Message));
                    }
                }

                Push.StopAllServices();
            });
        }

        //Currently it will raise only for android devices
        public virtual void DeviceSubscriptionChanged(
            object sender,
            string oldSubscriptionId,
            string newSubscriptionId,
            INotification notification)
        {
            string msg = string.Format(
                "Device Registration Changed:  Old-> {0}  New-> {1} -> ",
                oldSubscriptionId,
                newSubscriptionId,
                notification);
            Loggers.ForEach(x => x.Write(msg));
        }

        //this even raised when a notification is successfully sent
        public virtual void NotificationSent(object sender, INotification notification)
        {
            Loggers.ForEach(x => x.Write("Sent: " + sender + " -> " + notification));
        }

        //this is raised when a notification is failed due to some reason
        public virtual void NotificationFailed(
            object sender,
            INotification notification,
            Exception notificationFailureException)
        {
            string msg = string.Format("Failure: {0} -> {1} -> ", sender, notificationFailureException.Message, notification);
            Loggers.ForEach(x => x.Write(msg));
        }

        //this is fired when there is exception is raised by the channel
        public virtual void ChannelException(object sender, IPushChannel channel, Exception exception)
        {
            Loggers.ForEach(x => x.Write("Channel Exception: " + sender + " -> " + exception));
        }

        //this is fired when there is exception is raised by the service
        public virtual void ServiceException(object sender, Exception exception)
        {
            Loggers.ForEach(x => x.Write("Service Exception: " + sender + " -> " + exception));
        }

        //this is raised when the particular device subscription is expired
        public virtual void DeviceSubscriptionExpired(
            object sender,
            string expiredDeviceSubscriptionId,
            DateTime timestamp,
            INotification notification)
        {
            Loggers.ForEach(x => x.Write("Device Subscription Expired: " + sender + " -> " + expiredDeviceSubscriptionId));
        }

        //this is raised when the channel is destroyed
        public virtual void ChannelDestroyed(object sender)
        {
            Loggers.ForEach(x => x.Write("Channel Destroyed for: " + sender));
        }

        //this is raised when the channel is created
        public virtual void ChannelCreated(object sender, IPushChannel pushChannel)
        {
            Loggers.ForEach(x => x.Write("Channel Created for: " + sender));
        }
    }
}
