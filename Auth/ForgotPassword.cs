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
    public partial class ForgotPassword : Form
    {
        public static string _email;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private async void SendForgot_Click(object sender, EventArgs e)
        {
            ForgotPasswordRequest email = new ForgotPasswordRequest
            {
                Email = EmailText.Text
            };
            string jsonEmail = JsonConvert.SerializeObject(email);


            var client = new HttpClient();
            var content = new StringContent(jsonEmail, Encoding.UTF8, "application/json");
            var response = client.PutAsync(Url.url + "User/forgot", content).Result;
            string jsonContent = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(jsonContent);
                ChangePassword change = new ChangePassword();
                change.Show();
                this.Close();
                _email = email.Email;
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
                catch (Newtonsoft.Json.JsonReaderException)
                {

                    MessageBox.Show(jsonContent);
                }

            }
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

