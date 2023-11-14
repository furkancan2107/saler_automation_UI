namespace Ui.Pages
{
    partial class HomePage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Card = new System.Windows.Forms.Panel();
            this.konum = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Baslik = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.addCart = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Yenile = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Anasayfa = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.MyProducts = new System.Windows.Forms.LinkLabel();
            this.Carts = new System.Windows.Forms.LinkLabel();
            this.Giris = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.Card);
            this.flowLayoutPanel1.Controls.Add(this.checkedListBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1203, 592);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.Transparent;
            this.Card.Controls.Add(this.konum);
            this.Card.Controls.Add(this.Fiyat);
            this.Card.Controls.Add(this.User);
            this.Card.Controls.Add(this.Description);
            this.Card.Controls.Add(this.Baslik);
            this.Card.Controls.Add(this.Resim);
            this.Card.Controls.Add(this.addCart);
            this.Card.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Card.Location = new System.Drawing.Point(3, 3);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(514, 399);
            this.Card.TabIndex = 0;
            this.Card.Paint += new System.Windows.Forms.PaintEventHandler(this.Card_Paint);
            // 
            // konum
            // 
            this.konum.AutoSize = true;
            this.konum.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konum.Location = new System.Drawing.Point(4, 368);
            this.konum.Name = "konum";
            this.konum.Size = new System.Drawing.Size(68, 25);
            this.konum.TabIndex = 5;
            this.konum.Text = "Konum";
            // 
            // Fiyat
            // 
            this.Fiyat.AutoSize = true;
            this.Fiyat.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fiyat.Location = new System.Drawing.Point(4, 314);
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Size = new System.Drawing.Size(50, 25);
            this.Fiyat.TabIndex = 4;
            this.Fiyat.Text = "Fiyat";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User.Location = new System.Drawing.Point(2, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(52, 25);
            this.User.TabIndex = 6;
            this.User.Text = "From";
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(0, 258);
            this.Description.MaximumSize = new System.Drawing.Size(5000, 100);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(475, 25);
            this.Description.TabIndex = 3;
            this.Description.Text = "Açıklama.........................    ........................................... " +
    "..";
            // 
            // Baslik
            // 
            this.Baslik.AutoSize = true;
            this.Baslik.Font = new System.Drawing.Font("Wide Latin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Baslik.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Baslik.Location = new System.Drawing.Point(2, 218);
            this.Baslik.MaximumSize = new System.Drawing.Size(1000, 40);
            this.Baslik.Name = "Baslik";
            this.Baslik.Size = new System.Drawing.Size(87, 40);
            this.Baslik.TabIndex = 2;
            this.Baslik.Text = "Baslik\r\n\r\n\r\n";
            this.Baslik.Click += new System.EventHandler(this.Baslik_Click);
            // 
            // Resim
            // 
            this.Resim.Location = new System.Drawing.Point(31, 27);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(447, 188);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Resim.TabIndex = 1;
            this.Resim.TabStop = false;
            this.Resim.Click += new System.EventHandler(this.Resim_Click);
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(359, 363);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(130, 31);
            this.addCart.TabIndex = 0;
            this.addCart.Text = "Sepete Ekle";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(523, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(10, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Yenile
            // 
            this.Yenile.Font = new System.Drawing.Font("Stencil", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yenile.Location = new System.Drawing.Point(12, 306);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(75, 23);
            this.Yenile.TabIndex = 2;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = true;
            this.Yenile.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 28);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sepetimToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // sepetimToolStripMenuItem
            // 
            this.sepetimToolStripMenuItem.Name = "sepetimToolStripMenuItem";
            this.sepetimToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.sepetimToolStripMenuItem.Text = "Sepetim";
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
            this.panel1.Size = new System.Drawing.Size(1329, 71);
            this.panel1.TabIndex = 5;
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
            this.linkLabel1.Location = new System.Drawing.Point(863, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 21);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ürün Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MyProducts
            // 
            this.MyProducts.AutoSize = true;
            this.MyProducts.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MyProducts.LinkColor = System.Drawing.Color.Black;
            this.MyProducts.Location = new System.Drawing.Point(297, 19);
            this.MyProducts.Name = "MyProducts";
            this.MyProducts.Size = new System.Drawing.Size(167, 21);
            this.MyProducts.TabIndex = 2;
            this.MyProducts.TabStop = true;
            this.MyProducts.Text = "Ürünlerim";
            this.MyProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MyProducts_LinkClicked);
            // 
            // Carts
            // 
            this.Carts.AutoSize = true;
            this.Carts.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Carts.LinkColor = System.Drawing.Color.Black;
            this.Carts.Location = new System.Drawing.Point(599, 19);
            this.Carts.Name = "Carts";
            this.Carts.Size = new System.Drawing.Size(127, 21);
            this.Carts.TabIndex = 1;
            this.Carts.TabStop = true;
            this.Carts.Text = "Sepetim";
            this.Carts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Carts_LinkClicked);
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
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1329, 683);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Yenile);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Panel Card;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Baslik;
        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepetimToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel Anasayfa;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel MyProducts;
        private System.Windows.Forms.LinkLabel Carts;
        private System.Windows.Forms.LinkLabel Giris;
        private System.Windows.Forms.Label konum;
        private System.Windows.Forms.Label User;
    }
}