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
using Ui.Api;
using Ui.requests;

namespace Ui.Pages
{
    public partial class MyProductsPagecs : Form
    {
        public MyProductsPagecs()
        {
            InitializeComponent();
        }

       
        private void Anasayfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

       

       

        

        private void MyProductsPagecs_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowMyProducts();
        }

        private void Giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void MyProducts_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
        }

        private void Carts_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyCarts myCarts = new MyCarts();
            myCarts.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
        }
        private async void ShowMyProducts()
        {
            List<ProductResponse> products = await GetProducts();

            foreach (var product in products)
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

                titleLabel.Location = Baslik.Location;

                Label descriptionLabel = new Label();
                descriptionLabel.Text = product.Description;
                descriptionLabel.ForeColor = Description.ForeColor;
                descriptionLabel.Font = Description.Font;
                descriptionLabel.Location = Description.Location;

                Label price = new Label();
                price.Text = product.Price + " Tl";
                price.Font = Fiyat.Font;
                price.Location = Fiyat.Location;

                Label location = new Label();
                location.Text = product.Location;
                location.Font = konum.Font;
                location.Location = konum.Location;


                Button UpdateButton = new Button();
                update.Tag = product.Id;
                UpdateButton.Text = "Düzenle";
                UpdateButton.Font = update.Font;
                UpdateButton.Size = update.Size;
                UpdateButton.BackColor = update.BackColor;
                UpdateButton.Location = update.Location;
                UpdateButton.Tag = product.Id;

                Button DeleteButton = new Button();
                delete.Tag = product.Id;
                DeleteButton.Text = "Sil";
                DeleteButton.Font = delete.Font;
                DeleteButton.Size = delete.Size;
                DeleteButton.BackColor = delete.BackColor;
                DeleteButton.Location = delete.Location;
                DeleteButton.Tag = product.Id;


                DeleteButton.Click += DeleteButton_Click;
                UpdateButton.Click += UpdateButton_Click;



                card.Controls.Add(imageBox);
                card.Controls.Add(titleLabel);
                card.Controls.Add(descriptionLabel);
                card.Controls.Add(UpdateButton);
                card.Controls.Add(price);
                card.Controls.Add(DeleteButton);
                card.Controls.Add(location);
               

                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ApiOperations api = new ApiOperations();
            if (sender is Button addButton)
            {
                int productId = (int)addButton.Tag;
                if (İnformation.isLogin == false)
                {
                    MessageBox.Show("Ürünü güncellemek için lütfen giriş yapın");
                }
                else
                {
                   
                }

            }
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            ApiOperations api = new ApiOperations();
            if (sender is Button addButton)
            {
                int productId = (int)addButton.Tag;
                if (İnformation.isLogin == false)
                {
                    MessageBox.Show("Ürünü Silmek İçin Lütfen Giriş Yapın...");
                }
                else
                {
                    //  MessageBox.Show(productId.ToString());
                    await api.deleteProduct(productId);
                    MyProductsPagecs productsPagecs = new MyProductsPagecs();
                    productsPagecs.Show();
                    this.Close();
                   
                }

            }
        }
        private async Task<List<ProductResponse>> GetProducts()
        {
            List<ProductResponse> products = new List<ProductResponse>();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Product/products/"+İnformation.id;
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

        private void Card_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
