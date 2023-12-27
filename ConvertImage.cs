
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ui
{
    class ConvertImage
    {
        public static Image GetImageFromBase64(string base64)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
      
                //MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
}