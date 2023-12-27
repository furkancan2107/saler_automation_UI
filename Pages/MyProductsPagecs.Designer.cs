namespace Ui.Pages
{
    partial class MyProductsPagecs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Anasayfa = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MyProducts = new System.Windows.Forms.LinkLabel();
            this.Carts = new System.Windows.Forms.LinkLabel();
            this.Giris = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Card = new System.Windows.Forms.Panel();
            this.Baslik = new System.Windows.Forms.Label();
            this.konum = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.Fiyat = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
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
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1481, 68);
            this.panel1.TabIndex = 6;
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
            this.Anasayfa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Anasayfa_LinkClicked);
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
            this.Giris.Location = new System.Drawing.Point(1149, 19);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(148, 21);
            this.Giris.TabIndex = 0;
            this.Giris.TabStop = true;
            this.Giris.Text = "Cikis Yap";
            this.Giris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Giris_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.Card);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(118, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1306, 615);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.DarkOrange;
            this.Card.Controls.Add(this.Baslik);
            this.Card.Controls.Add(this.konum);
            this.Card.Controls.Add(this.delete);
            this.Card.Controls.Add(this.Fiyat);
            this.Card.Controls.Add(this.Description);
            this.Card.Controls.Add(this.Resim);
            this.Card.Controls.Add(this.update);
            this.Card.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Card.Location = new System.Drawing.Point(3, 3);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(622, 372);
            this.Card.TabIndex = 1;
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baslik.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Baslik.Location = new System.Drawing.Point(5, 192);
            this.Baslik.MaximumSize = new System.Drawing.Size(1000, 40);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(506, 18);
            this.Baslik.TabIndex = 7;
            this.Baslik.Text = "Baslik...........................................................";
            // 
            // konum
            // 
            this.konum.AutoSize = true;
            this.konum.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konum.Location = new System.Drawing.Point(7, 283);
            this.konum.Name = "konum";
            this.konum.Size = new System.Drawing.Size(68, 25);
            this.konum.TabIndex = 6;
            this.konum.Text = "Konum";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(449, 331);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(156, 25);
            this.delete.TabIndex = 5;
            this.delete.Text = "Sil";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fiyat.Location = new System.Drawing.Point(7, 331);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(50, 25);
            this.Fiyat.TabIndex = 4;
            this.Fiyat.Text = "Fiyat";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(3, 233);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(610, 25);
            this.Description.TabIndex = 3;
            this.Description.Text = "Aciklama........................................................................." +
    ".............................";
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(3, 3);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(602, 174);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resim.TabIndex = 1;
            this.Resim.TabStop = false;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(276, 331);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(156, 25);
            this.update.TabIndex = 0;
            this.update.Text = "Düzenle";
            this.update.UseVisualStyleBackColor = true;
            // 
            // MyProductsPagecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1436, 697);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MyProductsPagecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProductsPagecs";
            this.Load += new System.EventHandler(this.MyProductsPagecs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label konum;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label Baslik;
    }
}