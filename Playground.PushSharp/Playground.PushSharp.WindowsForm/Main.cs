using System;
using System.Windows.Forms;
using Playground.PushSharp.Core;

namespace Playground.PushSharp.WindowsForm
{
    public partial class Main : Form, ILogger
    {
        private PushMessageManager Manager { get; set; }

        public Main()
        {
            InitializeComponent();
            Manager = PushMessageManager.Create().WithLoggers(this);
        }

        private void ChooseAppleCertificate_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Manager.AppleCertificateLocation = openFileDialog.FileName;
                    this.appleCertificateLocation.Text = Manager.AppleCertificateLocation;
                }
            }
        }

        private void pushButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.alertBodyTextBox.Text)) { MessageBox.Show("Alert Body not provided"); return; }
            if (this.badgeNumericUpDown.Value < 0) { MessageBox.Show("Badge value must > 0"); return; }

            Manager.AppleDeviceToken = this.appleTokenBox.Text;
            Manager.ApplePassword = this.textBoxApplePassword.Text;
            Manager.GoogleApiKey = this.textBoxGoogleApiKey.Text;
            Manager.GoogleRegId = this.textBoxGoogleRegId.Text;
            Manager.Send(this.alertBodyTextBox.Text, Convert.ToInt32(this.badgeNumericUpDown.Value));
        }

        #region ILogger 成員

        void ILogger.Write(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => AppendLog(msg)));
                return;
            }

            AppendLog(msg);
        }

        #endregion

        private void AppendLog(string log)
        {
            this.logTextBox.Text += log;
            this.logTextBox.Text += Environment.NewLine;
        }
    }
}
