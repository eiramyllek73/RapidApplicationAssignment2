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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.MainMenuGroupBox = new System.Windows.Forms.GroupBox();
            this.LogApptRadioButton = new System.Windows.Forms.RadioButton();
            this.AddNewRadioButton = new System.Windows.Forms.RadioButton();
            this.ViewDirectoryRadioButton = new System.Windows.Forms.RadioButton();
            this.MainMenuToolTipLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DateTimeTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyLogoBox = new System.Windows.Forms.PictureBox();
            this.MainMenuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AccessibleDescription = "This is a greeting label.";
            this.HelloLabel.AccessibleName = "HelloLabel";
            this.HelloLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(35, 15);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(31, 13);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello";
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AccessibleDescription = "This label describes the current date.";
            this.DateTimeLabel.AccessibleName = "CurrentDateLabel";
            this.DateTimeLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Location = new System.Drawing.Point(333, 15);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(50, 13);
            this.DateTimeLabel.TabIndex = 0;
            this.DateTimeLabel.Text = "Today is:";
            // 
            // MainMenuGroupBox
            // 
            this.MainMenuGroupBox.AccessibleDescription = "This box displays choices for the user to choose one option from.";
            this.MainMenuGroupBox.AccessibleName = "OptionsBox";
            this.MainMenuGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.MainMenuGroupBox.Controls.Add(this.LogApptRadioButton);
            this.MainMenuGroupBox.Controls.Add(this.AddNewRadioButton);
            this.MainMenuGroupBox.Controls.Add(this.ViewDirectoryRadioButton);
            this.MainMenuGroupBox.Controls.Add(this.MainMenuToolTipLabel);
            this.MainMenuGroupBox.Location = new System.Drawing.Point(247, 79);
            this.MainMenuGroupBox.Name = "MainMenuGroupBox";
            this.MainMenuGroupBox.Size = new System.Drawing.Size(245, 132);
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
            this.LogApptRadioButton.TabIndex = 3;
            this.LogApptRadioButton.TabStop = true;
            this.LogApptRadioButton.Text = "Log New Appointment for Customer";
            this.LogApptRadioButton.UseVisualStyleBackColor = true;
            this.LogApptRadioButton.CheckedChanged += new System.EventHandler(this.LogApptRadioButton_CheckedChanged);
            // 
            // AddNewRadioButton
            // 
            this.AddNewRadioButton.AutoSize = true;
            this.AddNewRadioButton.Location = new System.Drawing.Point(9, 67);
            this.AddNewRadioButton.Name = "AddNewRadioButton";
            this.AddNewRadioButton.Size = new System.Drawing.Size(116, 17);
            this.AddNewRadioButton.TabIndex = 2;
            this.AddNewRadioButton.TabStop = true;
            this.AddNewRadioButton.Text = "Add New Customer";
            this.AddNewRadioButton.UseVisualStyleBackColor = true;
            this.AddNewRadioButton.CheckedChanged += new System.EventHandler(this.AddNewRadioButton_CheckedChanged);
            // 
            // ViewDirectoryRadioButton
            // 
            this.ViewDirectoryRadioButton.AutoSize = true;
            this.ViewDirectoryRadioButton.Location = new System.Drawing.Point(9, 43);
            this.ViewDirectoryRadioButton.Name = "ViewDirectoryRadioButton";
            this.ViewDirectoryRadioButton.Size = new System.Drawing.Size(140, 17);
            this.ViewDirectoryRadioButton.TabIndex = 1;
            this.ViewDirectoryRadioButton.TabStop = true;
            this.ViewDirectoryRadioButton.Text = "View Customer Directory";
            this.ViewDirectoryRadioButton.UseVisualStyleBackColor = true;
            this.ViewDirectoryRadioButton.CheckedChanged += new System.EventHandler(this.ViewDirectoryRadioButton_CheckedChanged);
            // 
            // MainMenuToolTipLabel
            // 
            this.MainMenuToolTipLabel.AutoSize = true;
            this.MainMenuToolTipLabel.Location = new System.Drawing.Point(6, 16);
            this.MainMenuToolTipLabel.Name = "MainMenuToolTipLabel";
            this.MainMenuToolTipLabel.Size = new System.Drawing.Size(200, 13);
            this.MainMenuToolTipLabel.TabIndex = 0;
            this.MainMenuToolTipLabel.Text = "Please choose one option, then click OK";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(417, 217);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DateTimeTextBox
            // 
            this.DateTimeTextBox.AccessibleDescription = "This text box displays the current date and time upon application load";
            this.DateTimeTextBox.AccessibleName = "CurrentDateAndTime";
            this.DateTimeTextBox.Location = new System.Drawing.Point(389, 12);
            this.DateTimeTextBox.Name = "DateTimeTextBox";
            this.DateTimeTextBox.ReadOnly = true;
            this.DateTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTimeTextBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(247, 217);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AccessibleDescription = "This texbox will show the name of the user.";
            this.NameTextBox.AccessibleName = "UserNameTextBox";
            this.NameTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.NameTextBox.Location = new System.Drawing.Point(72, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Text = "Wendy";
            // 
            // CompanyLogoBox
            // 
            this.CompanyLogoBox.AccessibleDescription = "This is a picture box that  displays the company logo.";
            this.CompanyLogoBox.AccessibleName = "LogoPictureBox";
            this.CompanyLogoBox.Image = global::RapidApplicationAssignment.Properties.Resources.FurzaFlyn_Logo_WebSize;
            this.CompanyLogoBox.Location = new System.Drawing.Point(38, 79);
            this.CompanyLogoBox.Name = "CompanyLogoBox";
            this.CompanyLogoBox.Size = new System.Drawing.Size(170, 161);
            this.CompanyLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyLogoBox.TabIndex = 9;
            this.CompanyLogoBox.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 257);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CompanyLogoBox);
            this.Controls.Add(this.DateTimeTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MainMenuGroupBox);
            this.Controls.Add(this.DateTimeLabel);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Dashboard";
            this.Text = "Welcome!";
            this.MainMenuGroupBox.ResumeLayout(false);
            this.MainMenuGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.GroupBox MainMenuGroupBox;
        private System.Windows.Forms.RadioButton LogApptRadioButton;
        private System.Windows.Forms.RadioButton AddNewRadioButton;
        private System.Windows.Forms.RadioButton ViewDirectoryRadioButton;
        private System.Windows.Forms.Label MainMenuToolTipLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox DateTimeTextBox;
        private System.Windows.Forms.PictureBox CompanyLogoBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}

