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
    public partial class MyCarts : Form
    {
        decimal total_price = 0;
        ApiOperations api = new ApiOperations();
        public MyCarts()
        {
            InitializeComponent();
            
            
        }

        private void MyCarts_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowProductCards();
           

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

        private void MyProducts_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProductsPagecs productsPage = new MyProductsPagecs();
            productsPage.Show();
            this.Close();
        }

        private void Anasayfa_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void Carts_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
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
        private async Task<List<CartDto>> GetCarts()
        {
            List<CartDto> carts = new List<CartDto>();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Cart/carts/"+İnformation.id;
                    HttpResponseMessage response = await client.GetAsync(apiURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        carts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CartDto>>(json);





                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return carts;
        }
        private async void ShowProductCards()
        {
            List<CartDto>  carts = await GetCarts();

            foreach (CartDto cart in carts)
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Size = Card.Size;
                card.BackColor = Card.BackColor;
                card.AutoScroll = true;

                PictureBox imageBox = new PictureBox();
                imageBox.ImageLocation = cart.Product.Image;
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBox.Size = Resim.Size;
                imageBox.Location = Resim.Location;

                Label titleLabel = new Label();
                titleLabel.Text = cart.Product.Title;
                titleLabel.Font = Baslik.Font;
                titleLabel.ForeColor = Baslik.ForeColor;
                titleLabel.Size = Baslik.Size;

                titleLabel.Location = Baslik.Location;

                Label descriptionLabel = new Label();
                descriptionLabel.Text = cart.Product.Description;
                descriptionLabel.ForeColor = Description.ForeColor;
                descriptionLabel.Font = Description.Font;
                descriptionLabel.Location = Description.Location;
                descriptionLabel.Size = Description.Size;

                Label price = new Label();
                price.Text = cart.Product.Price + " Tl";
                price.Font = Fiyat.Font;
                price.Location = Fiyat.Location;


                Button DeleteCart = new Button();
                addCart.Tag = cart.Id;
                DeleteCart.Text = "Sepetten Kaldir";
                DeleteCart.Font = addCart.Font;
                DeleteCart.Size = addCart.Size;
                DeleteCart.BackColor = addCart.BackColor;
                DeleteCart.Location = addCart.Location;
                DeleteCart.Tag = cart.Id;



                DeleteCart.Click += DeleteCart_Click;



                card.Controls.Add(imageBox);
                card.Controls.Add(titleLabel);
                card.Controls.Add(descriptionLabel);
                card.Controls.Add(DeleteCart);
                card.Controls.Add(price);
                total_price += cart.Product.Price;
                toplamfiyat.Text = "Toplam Fiyat : " + total_price + " tl";

                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private async void DeleteCart_Click(object sender, EventArgs e)
        {
            ApiOperations api = new ApiOperations();
            if (sender is Button addButton)
            {
                int cartId = (int)addButton.Tag;
                if (İnformation.isLogin == false)
                {
                    MessageBox.Show("sepete eklemek için Lütfen giriş yapın");
                }
                else
                {
                    await api.deleteCart(cartId);
                    MyCarts myCarts = new MyCarts();
                    myCarts.Show();
                    this.Close();
                    total_price = 0;
                }

            }
        }

        private void toplamfiyat_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            total_price = 0;
            toplamfiyat.Text = "Toplam Fiyat : " + total_price + " tl";
            ShowProductCards();
        }

        private void addCart_Click(object sender, EventArgs e)
        {

        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Öde_Click(object sender, EventArgs e)
        {
            List<CartDto> carts = await GetCarts();
            foreach(var cart in carts)
            {
                try
                {
                    // siparişlere eklenecek 
                    api.createOrder(İnformation.id, cart.Product.Id);
                    // burada sepettekiller tek tek silinecek
                    api.deleteCart(cart.Id);
                    MyCarts myCarts = new MyCarts();
                    myCarts.Show();
                    this.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyOrdersPage myProducts = new MyOrdersPage();
            myProducts.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InComingOrdersPage ordersPage = new InComingOrdersPage();
            ordersPage.Show();
            this.Hide();
        }
    }
}
