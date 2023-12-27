namespace Ui
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.ForgotLink = new System.Windows.Forms.LinkLabel();
            this.UsernameTaxt = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.CreateUser = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLink
            // 
            this.LoginLink.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.LoginLink.AutoSize = true;
            this.LoginLink.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.LoginLink.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.LoginLink.LinkVisited = true;
            this.LoginLink.Location = new System.Drawing.Point(515, 415);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(58, 20);
            this.LoginLink.TabIndex = 13;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Login";
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // ForgotLink
            // 
            this.ForgotLink.AutoSize = true;
            this.ForgotLink.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.ForgotLink.LinkColor = System.Drawing.Color.White;
            this.ForgotLink.LinkVisited = true;
            this.ForgotLink.Location = new System.Drawing.Point(765, 415);
            this.ForgotLink.Name = "ForgotLink";
            this.ForgotLink.Size = new System.Drawing.Size(168, 20);
            this.ForgotLink.TabIndex = 12;
            this.ForgotLink.TabStop = true;
            this.ForgotLink.Text = "Forgot Password";
            this.ForgotLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotLink_LinkClicked);
            // 
            // UsernameTaxt
            // 
            this.UsernameTaxt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTaxt.Location = new System.Drawing.Point(517, 161);
            this.UsernameTaxt.Multiline = true;
            this.UsernameTaxt.Name = "UsernameTaxt";
            this.UsernameTaxt.Size = new System.Drawing.Size(416, 56);
            this.UsernameTaxt.TabIndex = 11;
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(518, 72);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(416, 56);
            this.EmailText.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.passwordLabel.Location = new System.Drawing.Point(514, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 20);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "username";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.emailLabel.Location = new System.Drawing.Point(514, 49);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 20);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "email";
            // 
            // CreateUser
            // 
            this.CreateUser.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.CreateUser.ForeColor = System.Drawing.Color.Black;
            this.CreateUser.Location = new System.Drawing.Point(517, 349);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(416, 61);
            this.CreateUser.TabIndex = 7;
            this.CreateUser.Text = "Register";
            this.CreateUser.UseVisualStyleBackColor = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(517, 257);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(416, 56);
            this.PasswordText.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.label1.Location = new System.Drawing.Point(514, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(857, 319);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 24);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1073, 470);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.ForgotLink);
            this.Controls.Add(this.UsernameTaxt);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.CreateUser);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.LinkLabel ForgotLink;
        private System.Windows.Forms.TextBox UsernameTaxt;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button CreateUser;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}