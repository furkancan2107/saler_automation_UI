namespace Ui.Pages
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Anasayfa = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MyProducts = new System.Windows.Forms.LinkLabel();
            this.Carts = new System.Windows.Forms.LinkLabel();
            this.Giris = new System.Windows.Forms.LinkLabel();
            this.Fiyat = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Aciklama = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Konum = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResimEkle = new System.Windows.Forms.Button();
            this.UrunEkle = new System.Windows.Forms.Button();
            this.Baslik = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Anasayfa);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.MyProducts);
            this.panel1.Controls.Add(this.Carts);
            this.panel1.Controls.Add(this.Giris);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 85);
            this.panel1.TabIndex = 7;
            // 
            // Anasayfa
            // 
            this.Anasayfa.AutoSize = true;
            this.Anasayfa.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anasayfa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Anasayfa.ImageKey = "house-black-silhouette-without-door.png";
            this.Anasayfa.LinkColor = System.Drawing.Color.Black;
            this.Anasayfa.Location = new System.Drawing.Point(31, 19);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(159, 21);
            this.Anasayfa.TabIndex = 4;
            this.Anasayfa.TabStop = true;
            this.Anasayfa.Text = "Ana Sayfa";
            this.Anasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Anasayfa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Anasayfa_LinkClicked_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(910, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 21);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ürün Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // MyProducts
            // 
            this.MyProducts.AutoSize = true;
            this.MyProducts.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MyProducts.LinkColor = System.Drawing.Color.Black;
            this.MyProducts.Location = new System.Drawing.Point(316, 19);
            this.MyProducts.Name = "MyProducts";
            this.MyProducts.Size = new System.Drawing.Size(167, 21);
            this.MyProducts.TabIndex = 2;
            this.MyProducts.TabStop = true;
            this.MyProducts.Text = "Ürünlerim";
            this.MyProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MyProducts_LinkClicked_1);
            // 
            // Carts
            // 
            this.Carts.AutoSize = true;
            this.Carts.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Carts.LinkColor = System.Drawing.Color.Black;
            this.Carts.Location = new System.Drawing.Point(634, 19);
            this.Carts.Name = "Carts";
            this.Carts.Size = new System.Drawing.Size(127, 21);
            this.Carts.TabIndex = 1;
            this.Carts.TabStop = true;
            this.Carts.Text = "Sepetim";
            this.Carts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Carts_LinkClicked_1);
            // 
            // Giris
            // 
            this.Giris.AutoSize = true;
            this.Giris.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Giris.LinkColor = System.Drawing.Color.Black;
            this.Giris.Location = new System.Drawing.Point(1177, 19);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(148, 21);
            this.Giris.TabIndex = 0;
            this.Giris.TabStop = true;
            this.Giris.Text = "Cikis Yap";
            this.Giris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Giris_LinkClicked);
            // 
            // Fiyat
            // 
            this.Fiyat.Location = new System.Drawing.Point(745, 417);
            this.Fiyat.Mask = "000000000000000000";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(555, 22);
            this.Fiyat.TabIndex = 8;
            this.Fiyat.Text = "0";
            this.Fiyat.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "right-arrow.png";
            this.label1.Location = new System.Drawing.Point(744, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Baslık";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Acıklama";
            // 
            // Aciklama
            // 
            this.Aciklama.Location = new System.Drawing.Point(745, 256);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(555, 107);
            this.Aciklama.TabIndex = 12;
            this.Aciklama.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(742, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Konum";
            // 
            // Konum
            // 
            this.Konum.FormattingEnabled = true;
            this.Konum.Location = new System.Drawing.Point(745, 497);
            this.Konum.Name = "Konum";
            this.Konum.Size = new System.Drawing.Size(555, 24);
            this.Konum.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(745, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ResimEkle
            // 
            this.ResimEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResimEkle.ForeColor = System.Drawing.Color.Black;
            this.ResimEkle.Location = new System.Drawing.Point(745, 538);
            this.ResimEkle.Name = "ResimEkle";
            this.ResimEkle.Size = new System.Drawing.Size(110, 35);
            this.ResimEkle.TabIndex = 17;
            this.ResimEkle.Text = "Resim Ekle";
            this.ResimEkle.UseVisualStyleBackColor = true;
            this.ResimEkle.Click += new System.EventHandler(this.ResimEkle_Click);
            // 
            // UrunEkle
            // 
            this.UrunEkle.ForeColor = System.Drawing.Color.Black;
            this.UrunEkle.Location = new System.Drawing.Point(1031, 626);
            this.UrunEkle.Name = "UrunEkle";
            this.UrunEkle.Size = new System.Drawing.Size(153, 51);
            this.UrunEkle.TabIndex = 18;
            this.UrunEkle.Text = "Ürünü Ekle";
            this.UrunEkle.UseVisualStyleBackColor = true;
            this.UrunEkle.Click += new System.EventHandler(this.UrunEkle_Click);
            // 
            // Baslik
            // 
            this.Baslik.Location = new System.Drawing.Point(745, 171);
            this.Baslik.Multiline = true;
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(555, 38);
            this.Baslik.TabIndex = 19;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "house-black-silhouette-without-door.png");
            this.ımageList1.Images.SetKeyName(1, "right-arrow.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(89, 193);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(508, 484);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1518, 823);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Baslik);
            this.Controls.Add(this.UrunEkle);
            this.Controls.Add(this.ResimEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Konum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fiyat);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel Anasayfa;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel MyProducts;
        private System.Windows.Forms.LinkLabel Carts;
        private System.Windows.Forms.LinkLabel Giris;
        private System.Windows.Forms.MaskedTextBox Fiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Aciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Konum;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ResimEkle;
        private System.Windows.Forms.Button UrunEkle;
        private System.Windows.Forms.TextBox Baslik;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}