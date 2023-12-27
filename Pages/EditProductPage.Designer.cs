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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductPage));
            this.Baslik = new System.Windows.Forms.TextBox();
            this.Konum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.MaskedTextBox();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CancelEditButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Baslik
            // 
            this.Baslik.Location = new System.Drawing.Point(703, 99);
            this.Baslik.Multiline = true;
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(586, 38);
            this.Baslik.TabIndex = 30;
            this.Baslik.TextChanged += new System.EventHandler(this.Baslik_TextChanged);
            // 
            // Konum
            // 
            this.Konum.FormattingEnabled = true;
            this.Konum.Location = new System.Drawing.Point(703, 456);
            this.Konum.Name = "Konum";
            this.Konum.Size = new System.Drawing.Size(586, 24);
            this.Konum.TabIndex = 27;
            this.Konum.SelectedIndexChanged += new System.EventHandler(this.Konum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(700, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Konum GUNCELLE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(700, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "FIYAT GUNCELLE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(703, 185);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(586, 140);
            this.Aciklama.TabIndex = 24;
            this.Aciklama.Text = "";
            this.Aciklama.TextChanged += new System.EventHandler(this.Aciklama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Acıklama Guncelle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(700, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Baslık Guncelle";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(703, 376);
            this.Fiyat.Mask = "000000000000000000";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(586, 22);
            this.Fiyat.TabIndex = 21;
            this.Fiyat.Text = "0";
            this.Fiyat.ValidatingType = typeof(int);
            this.Fiyat.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Fiyat_MaskInputRejected);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Font = new System.Drawing.Font("Showcard Gothic", 7.8F);
            this.UpdateProductButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateProductButton.ImageKey = "changes.png";
            this.UpdateProductButton.ImageList = this.ımageList1;
            this.UpdateProductButton.Location = new System.Drawing.Point(1021, 517);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(158, 44);
            this.UpdateProductButton.TabIndex = 32;
            this.UpdateProductButton.Text = "GUNCELLE";
            this.UpdateProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "changes.png");
            // 
            // CancelEditButton
            // 
            this.CancelEditButton.Font = new System.Drawing.Font("Showcard Gothic", 7.8F);
            this.CancelEditButton.ForeColor = System.Drawing.Color.Black;
            this.CancelEditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelEditButton.ImageKey = "cancel.png";
            this.CancelEditButton.ImageList = this.ımageList1;
            this.CancelEditButton.Location = new System.Drawing.Point(772, 517);
            this.CancelEditButton.Name = "CancelEditButton";
            this.CancelEditButton.Size = new System.Drawing.Size(146, 44);
            this.CancelEditButton.TabIndex = 33;
            this.CancelEditButton.Text = "iptal";
            this.CancelEditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelEditButton.UseVisualStyleBackColor = true;
            this.CancelEditButton.Click += new System.EventHandler(this.CancelEditButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1354, 620);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelEditButton);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.Baslik);
            this.Controls.Add(this.Konum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fiyat);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "EditProductPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditProductPage";
            this.Load += new System.EventHandler(this.EditProductPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button CancelEditButton;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}