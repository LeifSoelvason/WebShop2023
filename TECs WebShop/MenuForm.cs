using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECs_WebShop
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btn_kunde_Click(object sender, EventArgs e)
        {
            this.Hide();
            KundeForm x = new KundeForm();
            x.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_indkøbskurv_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndkøbskurvForm x = new IndkøbskurvForm();
            x.Show();
        }
    }
}
