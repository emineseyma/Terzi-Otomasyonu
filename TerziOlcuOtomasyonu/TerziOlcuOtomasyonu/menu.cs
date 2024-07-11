using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TerziOlcuOtomasyonu
{
    public partial class TerziOlcumVeSiparis : Form
    {
        public TerziOlcumVeSiparis()
        {
            InitializeComponent();
        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            MusteriveOlcuİslemi anasayfa = new MusteriveOlcuİslemi();
            anasayfa.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparis f2 = new Siparis();
            f2.Show();
            this.Hide();
        }

        private void TerziOlcumVeSiparis_Load(object sender, EventArgs e)
        {

        }
    }
}
