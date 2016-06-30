namespace RapidApplicationAssignment
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.CurrentDateLabel = new System.Windows.Forms.Label();
            this.MainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.LogApptRadioButton = new System.Windows.Forms.RadioButton();
            this.ViewDirectoryRadioButton = new System.Windows.Forms.RadioButton();
            this.MainMenuToolTipLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.CompanyLogoBox = new System.Windows.Forms.PictureBox();
            this.CreateInvoiceRadioButton = new System.Windows.Forms.RadioButton();
            this.MainMenuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentDateLabel
            // 
            this.CurrentDateLabel.AccessibleDescription = "This label describes the current date.";
            this.CurrentDateLabel.AccessibleName = "CurrentDateLabel";
            this.CurrentDateLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CurrentDateLabel.AutoSize = true;
            this.CurrentDateLabel.Location = new System.Drawing.Point(262, 15);
            this.CurrentDateLabel.Name = "CurrentDateLabel";
            this.CurrentDateLabel.Size = new System.Drawing.Size(36, 13);
            this.CurrentDateLabel.TabIndex = 0;
            this.CurrentDateLabel.Text = "(Date)";
            // 
            // MainMenuGroupBox
            // 
            this.MainMenuGroupBox.AccessibleDescription = "This box displays choices for the user to choose one option from.";
            this.MainMenuGroupBox.AccessibleName = "OptionsBox";
            this.MainMenuGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.MainMenuGroupBox.Controls.Add(this.CreateInvoiceRadioButton);
            this.MainMenuGroupBox.Controls.Add(this.LogApptRadioButton);
            this.MainMenuGroupBox.Controls.Add(this.ViewDirectoryRadioButton);
            this.MainMenuGroupBox.Controls.Add(this.MainMenuToolTipLabel);
            this.MainMenuGroupBox.Location = new System.Drawing.Point(256, 51);
            this.MainMenuGroupBox.Name = "MainMenuGroupBox";
            this.MainMenuGroupBox.Size = new System.Drawing.Size(245, 160);
            this.MainMenuGroupBox.TabIndex = 6;
            this.MainMenuGroupBox.TabStop = false;
            this.MainMenuGroupBox.Text = "What would you like to do?";
            // 
            // LogApptRadioButton
            // 
            this.LogApptRadioButton.AutoSize = true;
            this.LogApptRadioButton.Location = new System.Drawing.Point(9, 91);
            this.LogApptRadioButton.Name = "LogApptRadioButton";
            this.LogApptRadioButton.Size = new System.Drawing.Size(192, 17);
            this.LogApptRadioButton.TabIndex = 2;
            this.LogApptRadioButton.TabStop = true;
            this.LogApptRadioButton.Text = "Log New Appointment for Customer";
            this.LogApptRadioButton.UseVisualStyleBackColor = true;
            // 
            // ViewDirectoryRadioButton
            // 
            this.ViewDirectoryRadioButton.AutoSize = true;
            this.ViewDirectoryRadioButton.Location = new System.Drawing.Point(9, 57);
            this.ViewDirectoryRadioButton.Name = "ViewDirectoryRadioButton";
            this.ViewDirectoryRadioButton.Size = new System.Drawing.Size(140, 17);
            this.ViewDirectoryRadioButton.TabIndex = 1;
            this.ViewDirectoryRadioButton.TabStop = true;
            this.ViewDirectoryRadioButton.Text = "View Customer Directory";
            this.ViewDirectoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuToolTipLabel
            // 
            this.MainMenuToolTipLabel.AutoSize = true;
            this.MainMenuToolTipLabel.Location = new System.Drawing.Point(6, 27);
            this.MainMenuToolTipLabel.Name = "MainMenuToolTipLabel";
            this.MainMenuToolTipLabel.Size = new System.Drawing.Size(200, 13);
            this.MainMenuToolTipLabel.TabIndex = 0;
            this.MainMenuToolTipLabel.Text = "Please choose one option, then click OK";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(396, 217);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 38);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(256, 217);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(101, 38);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AccessibleDescription = "This label describes the current time.";
            this.CurrentTimeLabel.AccessibleName = "CurrentTimeLabel";
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(393, 15);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(36, 13);
            this.CurrentTimeLabel.TabIndex = 0;
            this.CurrentTimeLabel.Text = "(Time)";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // CompanyLogoBox
            // 
            this.CompanyLogoBox.AccessibleDescription = "This is a picture box that  displays the company logo.";
            this.CompanyLogoBox.AccessibleName = "LogoPictureBox";
            this.CompanyLogoBox.Image = global::RapidApplicationAssignment.Properties.Resources.FurzaFlyn_Logo_WebSize;
            this.CompanyLogoBox.Location = new System.Drawing.Point(12, 12);
            this.CompanyLogoBox.Name = "CompanyLogoBox";
            this.CompanyLogoBox.Size = new System.Drawing.Size(229, 236);
            this.CompanyLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyLogoBox.TabIndex = 9;
            this.CompanyLogoBox.TabStop = false;
            // 
            // CreateInvoiceRadioButton
            // 
            this.CreateInvoiceRadioButton.AutoSize = true;
            this.CreateInvoiceRadioButton.Location = new System.Drawing.Point(9, 129);
            this.CreateInvoiceRadioButton.Name = "CreateInvoiceRadioButton";
            this.CreateInvoiceRadioButton.Size = new System.Drawing.Size(156, 17);
            this.CreateInvoiceRadioButton.TabIndex = 3;
            this.CreateInvoiceRadioButton.TabStop = true;
            this.CreateInvoiceRadioButton.Text = "Create Invoice for Customer";
            this.CreateInvoiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(531, 263);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CompanyLogoBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainMenuGroupBox);
            this.Controls.Add(this.CurrentDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MainMenuGroupBox.ResumeLayout(false);
            this.MainMenuGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurrentDateLabel;
        private System.Windows.Forms.GroupBox MainMenuGroupBox;
        private System.Windows.Forms.RadioButton LogApptRadioButton;
        private System.Windows.Forms.RadioButton ViewDirectoryRadioButton;
        private System.Windows.Forms.Label MainMenuToolTipLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox CompanyLogoBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.RadioButton CreateInvoiceRadioButton;
    }
}

