namespace Ui
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.ForgotLink = new System.Windows.Forms.LinkLabel();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(499, 317);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(368, 61);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(495, 69);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 20);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(495, 187);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 20);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "password";
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(499, 92);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(368, 56);
            this.EmailText.TabIndex = 3;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(499, 210);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(368, 56);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // ForgotLink
            // 
            this.ForgotLink.AutoSize = true;
            this.ForgotLink.LinkColor = System.Drawing.Color.Maroon;
            this.ForgotLink.LinkVisited = true;
            this.ForgotLink.Location = new System.Drawing.Point(729, 432);
            this.ForgotLink.Name = "ForgotLink";
            this.ForgotLink.Size = new System.Drawing.Size(168, 20);
            this.ForgotLink.TabIndex = 5;
            this.ForgotLink.TabStop = true;
            this.ForgotLink.Text = "Forgot Password";
            this.ForgotLink.VisitedLinkColor = System.Drawing.Color.White;
            this.ForgotLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotLink_LinkClicked);
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.LinkColor = System.Drawing.Color.White;
            this.RegisterLink.LinkVisited = true;
            this.RegisterLink.Location = new System.Drawing.Point(495, 432);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(91, 20);
            this.RegisterLink.TabIndex = 6;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Register";
            this.RegisterLink.VisitedLinkColor = System.Drawing.Color.White;
            this.RegisterLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLink_LinkClicked);
            // 
            // LoginLogo
            // 
            this.LoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("LoginLogo.Image")));
            this.LoginLogo.Location = new System.Drawing.Point(50, 69);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(320, 319);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginLogo.TabIndex = 7;
            this.LoginLogo.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(807, 272);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1004, 493);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LoginLogo);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.ForgotLink);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.LoginButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.LinkLabel ForgotLink;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

