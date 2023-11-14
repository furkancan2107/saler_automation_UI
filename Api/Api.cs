
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ui.requests;

namespace Ui.Api
{
    class ApiOperations
    {
        // sepete ekle
        public async Task addToCart(int userId, int productId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Cart/addCart/" + userId + "/" + productId;
                    HttpResponseMessage response = await client.PostAsync(apiURL,null);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Ürün Sepete Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Ürün sepete eklenemedi. HTTP Hata Kodu: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı veya ürün bulunamadı. Hata: " + ex.ToString());
                }
            }
        }
        // sepetten kaldir 
        public async Task deleteCart(int cartId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Cart/removeCart/" + cartId;
                    HttpResponseMessage response = await client.DeleteAsync(apiURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Ürün Sepetten Kaldirildi");
                    }
                    else
                    {
                        MessageBox.Show("Ürün sepetten kaldirilamadi. HTTP Hata Kodu: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı veya ürün bulunamadı. Hata: " + ex.ToString());
                }
            }

        }
        // ürünü sil 
        public async Task deleteProduct(int productId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Product/delete/" + productId;
                    HttpResponseMessage response = await client.DeleteAsync(apiURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Ürün Silindi");
                    }
                    else
                    {
                        MessageBox.Show("Ürün Silinemedi. HTTP Hata Kodu: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı veya ürün bulunamadı. Hata: " + ex.ToString());
                }
            }
            
        }

        // sipariş al 
        public async Task createOrder(int userId, int productId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiURL = Url.url + "Order/create/" + userId + "/" + productId;
                    HttpResponseMessage response = await client.PostAsync(apiURL, null);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Siparişiniz alındı");
                    }
                    else
                    {
                        MessageBox.Show("Siparişiniz alınamadi. HTTP Hata Kodu: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı veya ürün bulunamadı. Hata: " + ex.ToString());
                }
            }
        }

        public async Task<ProductResponse> getProduct(int productId)
        {
            ProductResponse product = new ProductResponse();
            using (HttpClient client =new HttpClient())
            {
              
                try
                {
                    string apiUrl = Url.url + "Product/get/" + productId;
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        product = JsonConvert.DeserializeObject<ProductResponse>(json);
                    }
                    else
                    {
                        MessageBox.Show("Ürün Bulunamadi. HTTP Hata Kodu: " + response.StatusCode);
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("Kullanıcı veya ürün bulunamadı. Hata: " + ex.ToString());
                }
            }
            return product;
            
        }


    }
}