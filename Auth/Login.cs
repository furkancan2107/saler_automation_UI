using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui.requests;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Ui.Pages;

namespace Ui
{
    public partial class Login : Form
    {
        
        public Login()
        {
            
            InitializeComponent();
        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ForgotLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
                  

        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            LoginRequest user = new LoginRequest
            {
                Email = EmailText.Text,
                Password = PasswordText.Text
            
            };

            
            string jsonUser = JsonConvert.SerializeObject(user);

           
            var client = new HttpClient();
            var content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
            var response = client.PostAsync(Url.url+"User/login", content).Result;
            string jsonContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Başari ile giriş yapıldı");
                HomePage homePage = new HomePage();
                homePage.Show();
                İnformation.isLogin = true;
                İnformation.username = user.Email;
                İnformation.id = int.Parse(jsonContent);
                
            }
            else
            {
                try
                {
                    var jsonObject = JObject.Parse(jsonContent);
                    var errors = jsonObject["errors"];
                    if (jsonObject!=null)
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
            
           

            /* if (response.IsSuccessStatusCode)
             {
                 MessageBox.Show("Kullanıcı başarıyla oluşturuldu.");
             }
             else
             {
                 MessageBox.Show("Kullanıcı oluşturma işlemi başarısız oldu.");
             }*/
        }
    }
    public class MyDataModel
    {
        public string PropertyName { get; set; }
    }
}
