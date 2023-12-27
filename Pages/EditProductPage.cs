using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class EditProductPage : Form
    {
        ProductResponse product = null;
        ApiOperations api = new ApiOperations();
        int _id = 0;
        public EditProductPage(int id)
        {
            InitializeComponent();
            _id = id;

        }

        private async void EditProductPage_Load(object sender, EventArgs e)
        {
            IlListesiEkle();
            product = await api.getProduct(_id);
            Baslik.Text = product.Title;
            Aciklama.Text = product.Description;
            int fiyat = Convert.ToInt32(product.Price);
            Fiyat.Text = fiyat.ToString();
            Konum.Text = product.Location;
        }
        private void IlListesiEkle()
        {

            string[] iller = {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin",
                "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa",
                "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne",
                "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük",
                "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis",
                "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş",
                "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop",
                "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van",
                "Yalova", "Yozgat", "Zonguldak"
            };


            Konum.Items.AddRange(iller);
        }

       

      

        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            page.Show();
            this.Close();
        }

        private async void UpdateProductButton_Click(object sender, EventArgs e)
        {
            UpdateProductRequest update = new UpdateProductRequest
            {
                Title = Baslik.Text,
                Description = Aciklama.Text,
                Price = int.Parse(Fiyat.Text),
                Image = product.Image,
                Location = Konum.Text
            };
            string jsonProduct = JsonConvert.SerializeObject(update);


            var client = new HttpClient();
            var content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");
            var response = client.PutAsync(Url.url + "Product/Update/" + _id, content).Result;
            string jsonContent = await response.Content.ReadAsStringAsync();
            try
            {
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ürün Güncellendi");
                    MyProductsPagecs myProducts = new MyProductsPagecs();
                    myProducts.Show();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Baslik_TextChanged(object sender, EventArgs e)
        {

        }

        private void Konum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Aciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fiyat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
