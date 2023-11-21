using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui.requests;
using Ui.Api;

namespace Ui.Pages
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Clear();
            ShowProductCards();
        }
      

        

        

       
        

        

        

        private async Task<List<ProductResponse>> GetProducts()
        {
            List<ProductResponse> products = new List<ProductResponse>();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Product/products"; 
                    HttpResponseMessage response = await client.GetAsync(apiURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        products = JsonConvert.DeserializeObject<List<ProductResponse>>(json);
                        
                        



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return products;
        }

       

       
        

        private async void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            
        }
        private async void ShowProductCards()
        {
            List<ProductResponse> products = await GetProducts();

            foreach (ProductResponse product in products)
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Size = Card.Size;
                card.BackColor = Card.BackColor;
                card.AutoScroll = true;
                               
                PictureBox imageBox = new PictureBox();
                imageBox.ImageLocation = product.Image;
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBox.Size = Resim.Size;
                imageBox.Location = Resim.Location;

                Label titleLabel = new Label();
                titleLabel.Text = product.Title;
                titleLabel.Font = Baslik.Font;
                titleLabel.ForeColor = Baslik.ForeColor;
                titleLabel.Size = new Size(200,30);
                titleLabel.Location = Baslik.Location;
           
                Label descriptionLabel = new Label();
                descriptionLabel.Text = product.Description;
                descriptionLabel.ForeColor = Description.ForeColor;
                descriptionLabel.Font = Description.Font;
                descriptionLabel.Size = Description.Size;
                descriptionLabel.Location = Description.Location;

                Label price = new Label();
                price.Text = product.Price + " Tl";
                price.Font = Fiyat.Font;
                price.Location = Fiyat.Location;

                Label location = new Label();
                location.Text = product.Location;
                location.Font = konum.Font;
                location.Location = konum.Location;

                Label user = new Label();
                user.Text = product.User.Username;
                user.Font = User.Font;
                user.Location = User.Location;

                Button AddCart = new Button();
                addCart.Tag = product.Id;
                AddCart.Text = "Sepete Ekle";
                AddCart.Font = addCart.Font;
                AddCart.Size = addCart.Size;
                AddCart.BackColor = addCart.BackColor;
                AddCart.Location = addCart.Location;
                AddCart.Tag = product.Id;

                AddCart.Click += AddCart_Click;

                card.Controls.Add(imageBox);
                card.Controls.Add(titleLabel);
                card.Controls.Add(descriptionLabel);
                card.Controls.Add(AddCart);
                card.Controls.Add(price);
                card.Controls.Add(location);
                card.Controls.Add(user);

                flowLayoutPanel1.Controls.Add(card); 
            }
        }

        private async void AddCart_Click(object sender, EventArgs e)
        {
            ApiOperations api = new ApiOperations();
            if (sender is Button addButton)
            {
                int productId = (int)addButton.Tag;
                ProductResponse db = await api.getProduct(productId);
                if (İnformation.isLogin==false) {
                    MessageBox.Show("sepete eklemek için Lütfen giriş yapın");
                }
                else if (İnformation.id==db.UserId)
                {
                    MessageBox.Show("Kendi Ürününü sepete ekleyemezsin");
                }
                else
                {
                   // MessageBox.Show(İnformation.id.ToString());
                    api.addToCart(İnformation.id, productId);
                }
                                           
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowProductCards();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Resim_Click(object sender, EventArgs e)
        {

        }

        private void Baslik_Click(object sender, EventArgs e)
        {

        }

        private void addCart_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
        }

        private void MyProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProductsPagecs productsPage = new MyProductsPagecs();
            productsPage.Show();
            this.Close();
        }

        private void Carts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyCarts myCarts = new MyCarts();
            myCarts.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void Giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void User_Click(object sender, EventArgs e)
        {

        }
    }
}
