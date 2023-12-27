namespace Ui.Pages
{
    partial class MyOrdersPage
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.linkLabel52 = new System.Windows.Forms.LinkLabel();
            this.linkLabel53 = new System.Windows.Forms.LinkLabel();
            this.linkLabel54 = new System.Windows.Forms.LinkLabel();
            this.linkLabel55 = new System.Windows.Forms.LinkLabel();
            this.linkLabel56 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Card = new System.Windows.Forms.Panel();
            this.Baslik = new System.Windows.Forms.Label();
            this.konum = new System.Windows.Forms.Label();
            this.Fiyat = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.cancelOrders = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel12.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.linkLabel52);
            this.panel12.Controls.Add(this.linkLabel53);
            this.panel12.Controls.Add(this.linkLabel54);
            this.panel12.Controls.Add(this.linkLabel55);
            this.panel12.Controls.Add(this.linkLabel56);
            this.panel12.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel12.Location = new System.Drawing.Point(2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1506, 96);
            this.panel12.TabIndex = 8;
            // 
            // linkLabel52
            // 
            this.linkLabel52.AutoSize = true;
            this.linkLabel52.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel52.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel52.LinkColor = System.Drawing.Color.Black;
            this.linkLabel52.Location = new System.Drawing.Point(36, 19);
            this.linkLabel52.Name = "linkLabel52";
            this.linkLabel52.Size = new System.Drawing.Size(159, 21);
            this.linkLabel52.TabIndex = 4;
            this.linkLabel52.TabStop = true;
            this.linkLabel52.Text = "Ana Sayfa";
            this.linkLabel52.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel52_LinkClicked);
            // 
            // linkLabel53
            // 
            this.linkLabel53.AutoSize = true;
            this.linkLabel53.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel53.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel53.LinkColor = System.Drawing.Color.Black;
            this.linkLabel53.Location = new System.Drawing.Point(910, 19);
            this.linkLabel53.Name = "linkLabel53";
            this.linkLabel53.Size = new System.Drawing.Size(162, 21);
            this.linkLabel53.TabIndex = 3;
            this.linkLabel53.TabStop = true;
            this.linkLabel53.Text = "Ürün Ekle";
            this.linkLabel53.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel53_LinkClicked);
            // 
            // linkLabel54
            // 
            this.linkLabel54.AutoSize = true;
            this.linkLabel54.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel54.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel54.LinkColor = System.Drawing.Color.Black;
            this.linkLabel54.Location = new System.Drawing.Point(316, 19);
            this.linkLabel54.Name = "linkLabel54";
            this.linkLabel54.Size = new System.Drawing.Size(167, 21);
            this.linkLabel54.TabIndex = 2;
            this.linkLabel54.TabStop = true;
            this.linkLabel54.Text = "Ürünlerim";
            this.linkLabel54.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel54_LinkClicked);
            // 
            // linkLabel55
            // 
            this.linkLabel55.AutoSize = true;
            this.linkLabel55.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel55.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel55.LinkColor = System.Drawing.Color.Black;
            this.linkLabel55.Location = new System.Drawing.Point(634, 19);
            this.linkLabel55.Name = "linkLabel55";
            this.linkLabel55.Size = new System.Drawing.Size(127, 21);
            this.linkLabel55.TabIndex = 1;
            this.linkLabel55.TabStop = true;
            this.linkLabel55.Text = "Sepetim";
            this.linkLabel55.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel55_LinkClicked);
            // 
            // linkLabel56
            // 
            this.linkLabel56.AutoSize = true;
            this.linkLabel56.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel56.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel56.LinkColor = System.Drawing.Color.Black;
            this.linkLabel56.Location = new System.Drawing.Point(1177, 19);
            this.linkLabel56.Name = "linkLabel56";
            this.linkLabel56.Size = new System.Drawing.Size(148, 21);
            this.linkLabel56.TabIndex = 0;
            this.linkLabel56.TabStop = true;
            this.linkLabel56.Text = "Cikis Yap";
            this.linkLabel56.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel56_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(590, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "SİPARİŞLERİM";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.Card);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1258, 579);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.DarkOrange;
            this.Card.Controls.Add(this.Baslik);
            this.Card.Controls.Add(this.konum);
            this.Card.Controls.Add(this.Fiyat);
            this.Card.Controls.Add(this.Status);
            this.Card.Controls.Add(this.Resim);
            this.Card.Controls.Add(this.cancelOrders);
            this.Card.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Card.Location = new System.Drawing.Point(3, 3);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(622, 372);
            this.Card.TabIndex = 2;
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
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(3, 233);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(557, 25);
            this.Status.TabIndex = 3;
            this.Status.Text = "Durum............................................................................" +
    "...................";
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
            // cancelOrders
            // 
            this.cancelOrders.Location = new System.Drawing.Point(276, 314);
            this.cancelOrders.Name = "cancelOrders";
            this.cancelOrders.Size = new System.Drawing.Size(284, 42);
            this.cancelOrders.TabIndex = 0;
            this.cancelOrders.Text = "İptal Et";
            this.cancelOrders.UseVisualStyleBackColor = true;
            // 
            // MyOrdersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1352, 765);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel12);
            this.Name = "MyOrdersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyOrdersPage";
            this.Load += new System.EventHandler(this.MyOrdersPage_Load);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.LinkLabel linkLabel52;
        private System.Windows.Forms.LinkLabel linkLabel53;
        private System.Windows.Forms.LinkLabel linkLabel54;
        private System.Windows.Forms.LinkLabel linkLabel55;
        private System.Windows.Forms.LinkLabel linkLabel56;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Card;
        private System.Windows.Forms.Label Baslik;
        private System.Windows.Forms.Label konum;
        private System.Windows.Forms.Label Fiyat;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.PictureBox Resim;
        private System.Windows.Forms.Button cancelOrders;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}