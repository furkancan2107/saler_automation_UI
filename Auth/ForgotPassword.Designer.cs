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
            this.SendForgot = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.RegisterLink = new System.Windows.Forms.LinkLabel();
            this.LoginLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SendForgot
            // 
            this.SendForgot.Location = new System.Drawing.Point(331, 331);
            this.SendForgot.Margin = new System.Windows.Forms.Padding(4);
            this.SendForgot.Name = "SendForgot";
            this.SendForgot.Size = new System.Drawing.Size(418, 76);
            this.SendForgot.TabIndex = 7;
            this.SendForgot.Text = "Send";
            this.SendForgot.UseVisualStyleBackColor = true;
            this.SendForgot.Click += new System.EventHandler(this.SendForgot_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(327, 160);
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
            this.EmailText.Location = new System.Drawing.Point(331, 211);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(416, 69);
            this.EmailText.TabIndex = 10;
            // 
            // RegisterLink
            // 
            this.RegisterLink.AutoSize = true;
            this.RegisterLink.LinkColor = System.Drawing.Color.Maroon;
            this.RegisterLink.LinkVisited = true;
            this.RegisterLink.Location = new System.Drawing.Point(201, 488);
            this.RegisterLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegisterLink.Name = "RegisterLink";
            this.RegisterLink.Size = new System.Drawing.Size(91, 20);
            this.RegisterLink.TabIndex = 13;
            this.RegisterLink.TabStop = true;
            this.RegisterLink.Text = "Register";
            // 
            // LoginLink
            // 
            this.LoginLink.AutoSize = true;
            this.LoginLink.LinkColor = System.Drawing.Color.Maroon;
            this.LoginLink.LinkVisited = true;
            this.LoginLink.Location = new System.Drawing.Point(774, 488);
            this.LoginLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLink.Name = "LoginLink";
            this.LoginLink.Size = new System.Drawing.Size(58, 20);
            this.LoginLink.TabIndex = 12;
            this.LoginLink.TabStop = true;
            this.LoginLink.Text = "Login";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.RegisterLink);
            this.Controls.Add(this.LoginLink);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.SendForgot);
            this.Font = new System.Drawing.Font("Stencil", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendForgot;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.LinkLabel RegisterLink;
        private System.Windows.Forms.LinkLabel LoginLink;
    }
}