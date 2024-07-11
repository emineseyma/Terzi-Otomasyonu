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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }
        sql bag = new sql();
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenıle();
        }
        DataTable yenıle()
        {


            SqlDataAdapter oda = new SqlDataAdapter("select * from sipariss ", bag.baglanti());
            DataTable t = new DataTable();
            oda.Fill(t);
            bag.baglanti().Close();
            return t;

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
            TerziOlcumVeSiparis eos = new TerziOlcumVeSiparis();
            eos.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand kom = new SqlCommand();
            kom.Connection = bag.baglanti();
            kom.CommandText = "insert into sipariss (SiparisNumarası,ÜrünAdı,ÜrünAdedi,Tutar)values(@SiparisNumarası,@ÜrünAdı,@ÜrünAdedi,@Tutar)";
            kom.Parameters.AddWithValue("@SiparisNumarası", textBox1.Text);
            kom.Parameters.AddWithValue("@ÜrünAdı", textBox2.Text);
            kom.Parameters.AddWithValue("@ÜrünAdedi", textBox3.Text);
            kom.Parameters.AddWithValue("@Tutar", textBox4.Text);
            kom.ExecuteNonQuery();
            bag.baglanti().Close();
            dataGridView1.DataSource = yenıle();
            MessageBox.Show("Müşteri Bilgileri eklendi.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand kom2 = new SqlCommand();
            kom2.Connection = bag.baglanti();
            kom2.CommandText = "DELETE from sipariss where SiparisNumarası=@SiparisNumarası";
            kom2.Parameters.AddWithValue("@SiparisNumarası", textBox1.Text);
            kom2.ExecuteNonQuery();
            bag.baglanti().Close();
            dataGridView1.DataSource = yenıle();
            MessageBox.Show("kayıt silindi.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand kom3 = new SqlCommand();
            kom3.Connection = bag.baglanti();
            kom3.CommandText = "update sipariss set SiparisNumarası=@SiparisNumarası,ÜrünAdı=@ÜrünAdı,ÜrünAdedi=@ÜrünAdedi,Tutar=@Tutar where Tutar=@Tutar";
            kom3.Parameters.AddWithValue("@SiparisNumarası", textBox1.Text);
            kom3.Parameters.AddWithValue("@ÜrünAdı", textBox2.Text);
            kom3.Parameters.AddWithValue("@ÜrünAdedi", textBox3.Text);
            kom3.Parameters.AddWithValue("@Tutar", textBox4.Text);
            kom3.ExecuteNonQuery();
            bag.baglanti().Close();
            dataGridView1.DataSource = yenıle();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
