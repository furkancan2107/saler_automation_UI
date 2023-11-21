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
    public partial class MyOrdersPage : Form
    {
        public MyOrdersPage()
        {
            InitializeComponent();
        }
       private async Task<List<Order>> GetOrders()
        {
            List<Order> orders = new List<Order>();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Order/"+İnformation.id;
                    HttpResponseMessage response = await client.GetAsync(apiURL);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        orders = JsonConvert.DeserializeObject<List<Order>>(json);





                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return orders;
        }
        private async void ShowMyProducts()
        {
            List<Order> orders = await GetOrders();

            foreach (var order in orders)
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Size = Card.Size;
                card.BackColor = Card.BackColor;
                card.AutoScroll = true;

                PictureBox imageBox = new PictureBox();
                imageBox.ImageLocation = order.Product.Image;
                imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imageBox.Size = Resim.Size;
                imageBox.Location = Resim.Location;

                Label titleLabel = new Label();
                titleLabel.Text = order.Product.Title;
                titleLabel.Font = Baslik.Font;
                titleLabel.ForeColor = Baslik.ForeColor;
                titleLabel.Size = Baslik.Size;

                titleLabel.Location = Baslik.Location;

                Label descriptionLabel = new Label();
                descriptionLabel.Text = order.OrderStatus;
                descriptionLabel.ForeColor = Status.ForeColor;
                descriptionLabel.Font = Status.Font;
                descriptionLabel.Size = descriptionLabel.Size;
                descriptionLabel.Location = Status.Location;

                Label price = new Label();
                price.Text = order.Product.Price + " Tl";
                price.Font = Fiyat.Font;
                price.Location = Fiyat.Location;

                Label location = new Label();
                location.Text = order.Product.Location;
                location.Font = konum.Font;
                location.Location = konum.Location;


                Button cancelOrder = new Button();
                cancelOrders.Tag = order.Id;
                cancelOrder.Text = "Siparişi İptal Et";
                cancelOrder.Font = cancelOrders.Font;
                cancelOrder.Size = cancelOrders.Size;
                cancelOrder.BackColor = cancelOrders.BackColor;
                cancelOrder.Location = cancelOrders.Location;
                cancelOrder.Tag = order.Id;




                /* DeleteButton.Click += DeleteButton_Click;
                 UpdateButton.Click += UpdateButton_Click;*/
                cancelOrder.Click += CancelOrder_Click;




                card.Controls.Add(imageBox);
                card.Controls.Add(titleLabel);
                card.Controls.Add(descriptionLabel);
                card.Controls.Add(cancelOrder);
                card.Controls.Add(price);
                
                card.Controls.Add(location);


                flowLayoutPanel1.Controls.Add(card);
            }
        }
        private async void CancelOrder_Click(object sender, EventArgs e)
        {
            ApiOperations api = new ApiOperations();
            if (sender is Button addButton)
            {
                int orderId = (int)addButton.Tag;
               await api.cancelOrder(orderId);
                MyOrdersPage orders = new MyOrdersPage();
                orders.Show();
                this.Hide();
                

            }
           
        }
        private void linkLabel52_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void linkLabel54_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProductsPagecs myProducts = new MyProductsPagecs();
            myProducts.Show();
            this.Hide();
        }

        private void linkLabel55_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyCarts carts = new MyCarts();
            carts.Show();
            this.Hide();

        }

        private void linkLabel53_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void linkLabel56_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyOrdersPage_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ShowMyProducts();
        }

        private void cancelOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
