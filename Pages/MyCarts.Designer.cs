﻿namespace Ui.Pages
{
    partial class MyCarts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCarts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Anasayfa = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MyProducts = new System.Windows.Forms.LinkLabel();
            this.Carts = new System.Windows.Forms.LinkLabel();
            this.Giris = new System.Windows.Forms.LinkLabel();
            this.toplamfiyat = new System.Windows.Forms.Label();
            this.Öde = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Card = new System.Windows.Forms.Panel();
            this.Fiyat = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Baslik = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.addCart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
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
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1642, 82);
            this.panel1.TabIndex = 7;
            // 
            // Anasayfa
            // 
            this.Anasayfa.AutoSize = true;
            this.Anasayfa.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anasayfa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Anasayfa.LinkColor = System.Drawing.Color.Black;
            this.Anasayfa.Location = new System.Drawing.Point(36, 19);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(159, 21);
            this.Anasayfa.TabIndex = 4;
            this.Anasayfa.TabStop = true;
            this.Anasayfa.Text = "Ana Sayfa";
            this.Anasayfa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Anasayfa_LinkClicked_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(996, 19);
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
            this.MyProducts.Location = new System.Drawing.Point(336, 19);
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
            this.Carts.Location = new System.Drawing.Point(699, 19);
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
            this.Giris.Location = new System.Drawing.Point(1331, 19);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(148, 21);
            this.Giris.TabIndex = 0;
            this.Giris.TabStop = true;
            this.Giris.Text = "Cikis Yap";
            this.Giris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Giris_LinkClicked);
            // 
            // toplamfiyat
            // 
            this.toplamfiyat.AutoSize = true;
            this.toplamfiyat.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplamfiyat.Location = new System.Drawing.Point(1223, 163);
            this.toplamfiyat.Name = "toplamfiyat";
            this.toplamfiyat.Size = new System.Drawing.Size(151, 25);
            this.toplamfiyat.TabIndex = 5;
            this.toplamfiyat.Text = "Toplam Fiyat : 0 tl";
            // 
            // Öde
            // 
            this.Öde.BackColor = System.Drawing.Color.White;
            this.Öde.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Öde.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Öde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Öde.ImageKey = "payment-method.png";
            this.Öde.ImageList = this.ımageList1;
            this.Öde.Location = new System.Drawing.Point(1228, 219);
            this.Öde.Name = "Öde";
            this.Öde.Size = new System.Drawing.Size(114, 46);
            this.Öde.TabIndex = 9;
            this.Öde.Text = "Öde";
            this.Öde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Öde.UseVisualStyleBackColor = false;
            this.Öde.Click += new System.EventHandler(this.Öde_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cargo.png");
            this.ımageList1.Images.SetKeyName(1, "payment-method.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Card);
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(95, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1064, 676);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.Transparent;
            this.Card.Controls.Add(this.Fiyat);
            this.Card.Controls.Add(this.Description);
            this.Card.Controls.Add(this.Baslik);
            this.Card.Controls.Add(this.Resim);
            this.Card.Controls.Add(this.addCart);
            this.Card.ForeColor = System.Drawing.Color.White;
            this.Card.Location = new System.Drawing.Point(3, 3);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(491, 394);
            this.Card.TabIndex = 1;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fiyat.Location = new System.Drawing.Point(31, 304);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(50, 25);
            this.Fiyat.TabIndex = 4;
            this.Fiyat.Text = "Fiyat";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(23, 235);
            this.Description.MaximumSize = new System.Drawing.Size(5000, 50);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(445, 25);
            this.Description.TabIndex = 3;
            this.Description.Text = "Açıklama.....................................................................";
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baslik.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Baslik.Location = new System.Drawing.Point(25, 202);
            this.Baslik.MaximumSize = new System.Drawing.Size(1000, 40);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(443, 18);
            this.Baslik.TabIndex = 2;
            this.Baslik.Text = "Baslik..................................................";
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(28, 3);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(423, 170);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resim.TabIndex = 1;
            this.Resim.TabStop = false;
            // 
            // addCart
            // 
            this.addCart.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCart.ForeColor = System.Drawing.Color.Black;
            this.addCart.Location = new System.Drawing.Point(289, 284);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(156, 45);
            this.addCart.TabIndex = 0;
            this.addCart.Text = "Sepete Ekle";
            this.addCart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1282, 719);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "cargo.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(1228, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Siparislerim";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1228, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Gelen Siparisler";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MyCarts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1554, 777);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toplamfiyat);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Öde);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MyCarts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCarts";
            this.Load += new System.EventHandler(this.MyCarts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Card;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Baslik;
        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.Label toplamfiyat;
        private System.Windows.Forms.Button Öde;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList1;
    }
}