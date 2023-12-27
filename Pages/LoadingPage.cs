using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ui.Pages
{
    public partial class LoadingPage : Form
    {
        private int sayac = 0;
        public LoadingPage()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 100)
            {
                timer1.Stop();
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            progressBar1.Value = sayac;
            sayac++;
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
