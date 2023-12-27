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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private async void UpdatePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordRequest change = new ChangePasswordRequest {
                ActivationCode = ActivationText.Text,
                NewPassword = NewPasswordText.Text
            };
            string jsonPassword = JsonConvert.SerializeObject(change);
            var client = new HttpClient();
            var content = new StringContent(jsonPassword, Encoding.UTF8, "application/json");
            //var response = client.PutAsync(Url.url + "User/forgot", content).Result;
            var response =client.PutAsync(Url.url + "User/changePassword/"+ForgotPassword._email, content).Result;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {

                NewPasswordText.PasswordChar = '\0';
            }
            else
            {

                NewPasswordText.PasswordChar = '*';
            }
        }
    }
}
