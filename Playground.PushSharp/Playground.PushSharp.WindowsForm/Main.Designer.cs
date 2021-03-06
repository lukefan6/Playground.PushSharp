﻿namespace Playground.PushSharp.WindowsForm
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.appleCertificate = new System.Windows.Forms.Label();
            this.appleCertificateLocation = new System.Windows.Forms.Label();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.ChooseAppleCertificate = new System.Windows.Forms.Button();
            this.appleTokenBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.badgeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alertBodyTextBox = new System.Windows.Forms.TextBox();
            this.badgeLabel = new System.Windows.Forms.Label();
            this.labelAlertBody = new System.Windows.Forms.Label();
            this.pushButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApplePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGoogleApiKey = new System.Windows.Forms.TextBox();
            this.textBoxGoogleRegId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // appleCertificate
            // 
            this.appleCertificate.AutoSize = true;
            this.appleCertificate.Location = new System.Drawing.Point(24, 40);
            this.appleCertificate.Name = "appleCertificate";
            this.appleCertificate.Size = new System.Drawing.Size(105, 16);
            this.appleCertificate.TabIndex = 0;
            this.appleCertificate.Text = "Apple Certificate:";
            // 
            // appleCertificateLocation
            // 
            this.appleCertificateLocation.AutoEllipsis = true;
            this.appleCertificateLocation.Location = new System.Drawing.Point(132, 40);
            this.appleCertificateLocation.Name = "appleCertificateLocation";
            this.appleCertificateLocation.Size = new System.Drawing.Size(106, 16);
            this.appleCertificateLocation.TabIndex = 1;
            this.appleCertificateLocation.Text = "Not Set";
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Location = new System.Drawing.Point(24, 76);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(49, 16);
            this.tokenLabel.TabIndex = 2;
            this.tokenLabel.Text = "Token: ";
            // 
            // ChooseAppleCertificate
            // 
            this.ChooseAppleCertificate.Location = new System.Drawing.Point(244, 37);
            this.ChooseAppleCertificate.Name = "ChooseAppleCertificate";
            this.ChooseAppleCertificate.Size = new System.Drawing.Size(75, 23);
            this.ChooseAppleCertificate.TabIndex = 3;
            this.ChooseAppleCertificate.Text = "Choose...";
            this.ChooseAppleCertificate.UseVisualStyleBackColor = true;
            this.ChooseAppleCertificate.Click += new System.EventHandler(this.ChooseAppleCertificate_Click);
            // 
            // appleTokenBox
            // 
            this.appleTokenBox.Location = new System.Drawing.Point(77, 73);
            this.appleTokenBox.Name = "appleTokenBox";
            this.appleTokenBox.Size = new System.Drawing.Size(242, 23);
            this.appleTokenBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.badgeNumericUpDown);
            this.groupBox1.Controls.Add(this.alertBodyTextBox);
            this.groupBox1.Controls.Add(this.badgeLabel);
            this.groupBox1.Controls.Add(this.labelAlertBody);
            this.groupBox1.Location = new System.Drawing.Point(27, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // badgeNumericUpDown
            // 
            this.badgeNumericUpDown.Location = new System.Drawing.Point(78, 67);
            this.badgeNumericUpDown.Name = "badgeNumericUpDown";
            this.badgeNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.badgeNumericUpDown.TabIndex = 3;
            // 
            // alertBodyTextBox
            // 
            this.alertBodyTextBox.Location = new System.Drawing.Point(78, 31);
            this.alertBodyTextBox.Name = "alertBodyTextBox";
            this.alertBodyTextBox.Size = new System.Drawing.Size(208, 23);
            this.alertBodyTextBox.TabIndex = 2;
            // 
            // badgeLabel
            // 
            this.badgeLabel.AutoSize = true;
            this.badgeLabel.Location = new System.Drawing.Point(6, 69);
            this.badgeLabel.Name = "badgeLabel";
            this.badgeLabel.Size = new System.Drawing.Size(48, 16);
            this.badgeLabel.TabIndex = 1;
            this.badgeLabel.Text = "Badge:";
            // 
            // labelAlertBody
            // 
            this.labelAlertBody.AutoSize = true;
            this.labelAlertBody.Location = new System.Drawing.Point(6, 34);
            this.labelAlertBody.Name = "labelAlertBody";
            this.labelAlertBody.Size = new System.Drawing.Size(69, 16);
            this.labelAlertBody.TabIndex = 0;
            this.labelAlertBody.Text = "Alert Body:";
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(244, 457);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 23);
            this.pushButton.TabIndex = 6;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(27, 333);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(286, 113);
            this.logTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apple Password:";
            // 
            // textBoxApplePassword
            // 
            this.textBoxApplePassword.Location = new System.Drawing.Point(135, 108);
            this.textBoxApplePassword.Name = "textBoxApplePassword";
            this.textBoxApplePassword.Size = new System.Drawing.Size(184, 23);
            this.textBoxApplePassword.TabIndex = 9;
            this.textBoxApplePassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Google API Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Android RegId:";
            // 
            // textBoxGoogleApiKey
            // 
            this.textBoxGoogleApiKey.Location = new System.Drawing.Point(135, 156);
            this.textBoxGoogleApiKey.Name = "textBoxGoogleApiKey";
            this.textBoxGoogleApiKey.Size = new System.Drawing.Size(184, 23);
            this.textBoxGoogleApiKey.TabIndex = 12;
            // 
            // textBoxGoogleRegId
            // 
            this.textBoxGoogleRegId.Location = new System.Drawing.Point(135, 187);
            this.textBoxGoogleRegId.Name = "textBoxGoogleRegId";
            this.textBoxGoogleRegId.Size = new System.Drawing.Size(184, 23);
            this.textBoxGoogleRegId.TabIndex = 13;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 492);
            this.Controls.Add(this.textBoxGoogleRegId);
            this.Controls.Add(this.textBoxGoogleApiKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApplePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.appleTokenBox);
            this.Controls.Add(this.ChooseAppleCertificate);
            this.Controls.Add(this.tokenLabel);
            this.Controls.Add(this.appleCertificateLocation);
            this.Controls.Add(this.appleCertificate);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "PushSharp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badgeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appleCertificate;
        private System.Windows.Forms.Label appleCertificateLocation;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.Button ChooseAppleCertificate;
        private System.Windows.Forms.TextBox appleTokenBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox alertBodyTextBox;
        private System.Windows.Forms.Label badgeLabel;
        private System.Windows.Forms.Label labelAlertBody;
        private System.Windows.Forms.NumericUpDown badgeNumericUpDown;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApplePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGoogleApiKey;
        private System.Windows.Forms.TextBox textBoxGoogleRegId;

    }
}

