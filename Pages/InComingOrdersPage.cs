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

namespace Ui.Pages
{
    public partial class InComingOrdersPage : Form
    {
        public InComingOrdersPage()
        {
            InitializeComponent();
            
            flowLayoutPanel1.Controls.Clear();
            showInComingOrders();
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
           
        }
        private async void showInComingOrders()
        {
            List<Order> orders = await getComingOrders();
            orders.Reverse();
            foreach(var order in orders)
            {
                Panel card = new Panel();
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Size = Card.Size;
                card.BackColor = Card.BackColor;
                card.AutoScroll = true;

                Label baslik = new Label();
                /*
                 titleLabel.Text = product.Title;
                titleLabel.Font = Baslik.Font;
                titleLabel.ForeColor = Baslik.ForeColor;
                titleLabel.Size = new Size(200,30);
                titleLabel.Location = Baslik.Location;*/
                baslik.Text = order.Product.Title;
                baslik.Font = Title.Font;
                baslik.Size = Title.Size;
                baslik.Location = Title.Location;
                baslik.ForeColor = Title.ForeColor;

                Label Tarih = new Label();
                Tarih.Text = order.DatePosted.ToShortDateString();
                Tarih.Font = Date.Font;
                Tarih.Size = Date.Size;
                Tarih.Location = Date.Location;
                Tarih.ForeColor = Date.ForeColor;

                Label fiyat = new Label();
                fiyat.Text = order.Product.Price.ToString() + " tl";
                fiyat.Location = Price.Location;
                fiyat.Size = Price.Size;
                fiyat.Font = Price.Font;
                fiyat.ForeColor = Price.ForeColor;

                ComboBox durum = new ComboBox();
                FillComboBox(durum);
                durum.SelectedText = order.OrderStatus;
                durum.Font = comboBox1.Font;
                durum.Size = comboBox1.Size;
                durum.Location = comboBox1.Location;
                durum.ForeColor = comboBox1.ForeColor;


                card.Controls.Add(baslik);
                card.Controls.Add(Tarih);
                card.Controls.Add(fiyat);
                card.Controls.Add(durum);
                flowLayoutPanel1.Controls.Add(card);


            }

        }
        private void FillComboBox(ComboBox box)
        {
            // Enum değerlerini ComboBox'a ekle
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
            {
                box.Items.Add(status);
            }
        }
        private async Task<List<Order>> getComingOrders()
        {
            List<Order> orders = new List<Order>();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Order/getOrders/"+İnformation.id;
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

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProductsPagecs myProductsPagecs = new MyProductsPagecs();
            myProductsPagecs.Show();
            this.Hide();
        }

        private void linkLabel29_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyCarts myCarts = new MyCarts();
            myCarts.Show();
            this.Hide();
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddProduct add = new AddProduct();
            add.Show();
            this.Hide();
        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InComingOrdersPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
