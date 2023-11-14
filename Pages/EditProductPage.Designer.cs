namespace Ui.Pages
{
    partial class EditProductPage
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
            this.Baslik = new System.Windows.Forms.TextBox();
            this.Konum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Baslik
            // 
            this.Baslik.Location = new System.Drawing.Point(212, 137);
            this.Baslik.Multiline = true;
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(963, 67);
            this.Baslik.TabIndex = 30;
            // 
            // Konum
            // 
            this.Konum.FormattingEnabled = true;
            this.Konum.Location = new System.Drawing.Point(212, 573);
            this.Konum.Name = "Konum";
            this.Konum.Size = new System.Drawing.Size(963, 24);
            this.Konum.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Konum GUNCELLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "FIYAT GUNCELLE";
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(212, 266);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(963, 180);
            this.Aciklama.TabIndex = 24;
            this.Aciklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Acıklama Guncelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Baslık Guncelle";
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(212, 493);
            this.Fiyat.Mask = "000000000000000000";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(963, 22);
            this.Fiyat.TabIndex = 21;
            this.Fiyat.Text = "0";
            this.Fiyat.ValidatingType = typeof(int);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F);
            this.button2.Location = new System.Drawing.Point(752, 646);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 44);
            this.button2.TabIndex = 32;
            this.button2.Text = "GUNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F);
            this.button1.Location = new System.Drawing.Point(390, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "iptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1354, 722);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Baslik);
            this.Controls.Add(this.Konum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fiyat);
            this.Name = "EditProductPage";
            this.Text = "EditProductPage";
            this.Load += new System.EventHandler(this.EditProductPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Baslik;
        private System.Windows.Forms.ComboBox Konum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Aciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Fiyat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}