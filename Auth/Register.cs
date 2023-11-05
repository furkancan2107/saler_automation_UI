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
using Ui.requests;

namespace Ui
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void ForgotLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Show();
            this.Close();
        }

        private async void CreateUser_Click(object sender, EventArgs e)
        {
            CreateUserDto user = new CreateUserDto {
                Email = EmailText.Text,
                Password = PasswordText.Text,
                Username = UsernameTaxt.Text
            };
            string jsonUser = JsonConvert.SerializeObject(user);


            var client = new HttpClient();
            var content = new StringContent(jsonUser, Encoding.UTF8, "application/json");
            var response = client.PostAsync(Url.url + "User/create", content).Result;
            string jsonContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(jsonContent);
                Login login = new Login();
                login.Show();
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
    }
}
