using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui.requests;

namespace Ui.Pages
{
    public partial class AddProduct : Form
    {
        string resimYolu="default";
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Giris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            IlListesiEkle();
            openFileDialog1.RestoreDirectory = true;
        }
        private void Anasayfa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
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





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Close();
        }

        private void Anasayfa_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();


        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Show();
        }

        private void Carts_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyCarts myCarts = new MyCarts();
            myCarts.Show();
            this.Close();
        }

        private void MyProducts_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MyProductsPagecs productsPage = new MyProductsPagecs();
            productsPage.Show();
            this.Close();
        }


        private async void UrunEkle_Click(object sender, EventArgs e)
        {

            byte[] resimBytes = File.ReadAllBytes(resimYolu);
            string base64String = Convert.ToBase64String(resimBytes);

            AddProductRequest product = new AddProductRequest
            {
                Title = Baslik.Text,
                Description = Aciklama.Text,
                Price = int.Parse(Fiyat.Text),
                Image = base64String,
                Location = Konum.Text
            };


            string jsonProduct = JsonConvert.SerializeObject(product);


            var client = new HttpClient();
            var content = new StringContent(jsonProduct, Encoding.UTF8, "application/json");
            var response = client.PostAsync(Url.url + "Product/add/" + İnformation.id, content).Result;
            string jsonContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Başari ile Ürün eklendi");
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Close();


            }
            else
            {
                try
                {
                    var jsonObject = JObject.Parse(jsonContent);
                    var errors = jsonObject["errors"];
                    if (jsonObject != null)
                    {
                        MessageBox.Show(errors.ToString());
                    }
                    else
                    {
                        MessageBox.Show(jsonContent);
                    }
                }
                catch (JsonReaderException)
                {

                    MessageBox.Show(jsonContent);
                }
            }
        }

       

        private void ResimEkle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp|Tüm Dosyalar|*.*";
                string klasorYolu = Path.Combine(Application.StartupPath, "Resimler");

                // Klasör yoksa oluştur
                if (!Directory.Exists(klasorYolu))
                {
                    Directory.CreateDirectory(klasorYolu);
                }


                if (dialog.ShowDialog() == DialogResult.OK)
                {
                  
                    string kaydedilenResimAdi = Guid.NewGuid().ToString() + Path.GetExtension(dialog.FileName);
                    string kayitYolu = Path.Combine(klasorYolu, kaydedilenResimAdi);
                    File.Copy(dialog.FileName, kayitYolu, true);

                    
                    resimYolu = kayitYolu;

                    pictureBox1.Image = Image.FromFile(resimYolu);
                }
            }
        }
    }
}
