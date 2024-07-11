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
    public partial class kullanıcıgiris : Form
    {
        public kullanıcıgiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kullanıcıgiris_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                TerziOlcumVeSiparis emlakkayıt = new TerziOlcumVeSiparis();
                emlakkayıt.Show();
                this.Hide();
            }
        }
    }
}
