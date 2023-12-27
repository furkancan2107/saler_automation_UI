namespace Ui
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.SendForgot = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SendForgot
            // 
            this.SendForgot.Location = new System.Drawing.Point(495, 238);
            this.SendForgot.Margin = new System.Windows.Forms.Padding(4);
            this.SendForgot.Name = "SendForgot";
            this.SendForgot.Size = new System.Drawing.Size(400, 58);
            this.SendForgot.TabIndex = 7;
            this.SendForgot.Text = "Send";
            this.SendForgot.UseVisualStyleBackColor = true;
            this.SendForgot.Click += new System.EventHandler(this.SendForgot_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(491, 116);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(59, 20);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "email";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // EmailText
            // 
            this.EmailText.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(495, 155);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(400, 51);
            this.EmailText.TabIndex = 10;
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.LinkColor = System.Drawing.Color.Maroon;
            this.RegisterLink.LinkVisited = true;
            this.RegisterLink.Location = new System.Drawing.Point(491, 347);
            this.RegisterLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.LoginLink.LinkColor = System.Drawing.Color.Maroon;
            this.LoginLink.LinkVisited = true;
            this.LoginLink.Location = new System.Drawing.Point(837, 347);
            this.LoginLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(58, 20);
            this.LoginLink.TabIndex = 12;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Login";
            this.LoginLink.VisitedLinkColor = System.Drawing.Color.White;
            this.LoginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(991, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.SendForgot);
            this.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendForgot;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.LinkLabel LoginLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}