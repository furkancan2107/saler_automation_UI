namespace Ui
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.NewPasswordText = new System.Windows.Forms.TextBox();
            this.ActivationText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.ActivationLabel = new System.Windows.Forms.Label();
            this.UpdatePassword = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.RegisterLink.LinkColor = System.Drawing.Color.Maroon;
            this.RegisterLink.LinkVisited = true;
            this.RegisterLink.Location = new System.Drawing.Point(403, 386);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(91, 20);
            this.RegisterLink.TabIndex = 13;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Register";
            this.RegisterLink.VisitedLinkColor = System.Drawing.Color.White;
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.LoginLink.LinkColor = System.Drawing.Color.Maroon;
            this.LoginLink.LinkVisited = true;
            this.LoginLink.Location = new System.Drawing.Point(653, 386);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(58, 20);
            this.LoginLink.TabIndex = 12;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Login";
            this.LoginLink.VisitedLinkColor = System.Drawing.Color.White;
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // NewPasswordText
            // 
            this.NewPasswordText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordText.Location = new System.Drawing.Point(407, 161);
            this.NewPasswordText.Multiline = true;
            this.NewPasswordText.Name = "NewPasswordText";
            this.NewPasswordText.PasswordChar = '*';
            this.NewPasswordText.Size = new System.Drawing.Size(304, 56);
            this.NewPasswordText.TabIndex = 11;
            // 
            // ActivationText
            // 
            this.ActivationText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivationText.Location = new System.Drawing.Point(407, 63);
            this.ActivationText.Multiline = true;
            this.ActivationText.Name = "ActivationText";
            this.ActivationText.Size = new System.Drawing.Size(304, 56);
            this.ActivationText.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(403, 138);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(138, 20);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "NEW password";
            // 
            // ActivationLabel
            // 
            this.ActivationLabel.AutoSize = true;
            this.ActivationLabel.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.ActivationLabel.ForeColor = System.Drawing.Color.White;
            this.ActivationLabel.Location = new System.Drawing.Point(403, 40);
            this.ActivationLabel.Name = "ActivationLabel";
            this.ActivationLabel.Size = new System.Drawing.Size(153, 20);
            this.ActivationLabel.TabIndex = 8;
            this.ActivationLabel.Text = "ACTIVATION CODE";
            // 
            // UpdatePassword
            // 
            this.UpdatePassword.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.UpdatePassword.Location = new System.Drawing.Point(407, 271);
            this.UpdatePassword.Name = "UpdatePassword";
            this.UpdatePassword.Size = new System.Drawing.Size(304, 56);
            this.UpdatePassword.TabIndex = 7;
            this.UpdatePassword.Text = "SEND";
            this.UpdatePassword.UseVisualStyleBackColor = true;
            this.UpdatePassword.Click += new System.EventHandler(this.UpdatePassword_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(635, 223);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 24);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.NewPasswordText);
            this.Controls.Add(this.ActivationText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.ActivationLabel);
            this.Controls.Add(this.UpdatePassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.TextBox NewPasswordText;
        private System.Windows.Forms.TextBox ActivationText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label ActivationLabel;
        private System.Windows.Forms.Button UpdatePassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}