﻿using System;
using System.Windows.Forms;
using Playground.PushSharp.Core;

namespace Playground.PushSharp.WindowsForm
{
    public partial class Main : Form
    {
        private PushMessageManager Manager { get; set; }

        public Main()
        {
            InitializeComponent();
            Manager = PushMessageManager.Create();
        }

        private void ChooseAppleCertificate_Click(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Manager.AppleCertificateLocation = openFileDialog.SafeFileName;
                    this.appleCertificateLocation.Text = Manager.AppleCertificateLocation;
                }
            }
        }

        private void pushButton_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.appleTokenBox.Text)) { MessageBox.Show("Token not provided"); return; }
            if (!string.IsNullOrWhiteSpace(this.alertBodyTextBox.Text)) { MessageBox.Show("Alert Body not provided"); return; }
            if (this.badgeNumericUpDown.Value < 0) { MessageBox.Show("Badge value must > 0"); return; }

            Manager.AppleDeviceToken = this.appleTokenBox.Text;
            Manager.Send(this.alertBodyTextBox.Text, Convert.ToInt32(this.badgeNumericUpDown.Value));
        }
    }
}
