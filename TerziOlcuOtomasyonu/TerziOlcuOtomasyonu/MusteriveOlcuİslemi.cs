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
using System.Data.Sql;

namespace TerziOlcuOtomasyonu
{
    public partial class MusteriveOlcuİslemi : Form
    {
       

        public MusteriveOlcuİslemi()
        {
            InitializeComponent();
        }

        
        DataTable t = new DataTable();
        sql bag = new sql();
        private void MusteriveOlcuİslemi_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }


        void MusteriGetir()
            {
                t.Clear();
                SqlDataAdapter oda = new SqlDataAdapter("select * from olcum", bag.baglanti());
                oda.Fill(t);
                dataGridView1.DataSource = t;
                bag.baglanti().Close();
            }
         
        



        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
          
            
        }

        private void EKLE_Click(object sender, EventArgs e)
        {
           

            SqlCommand zebercet = new SqlCommand();
            zebercet.Connection = bag.baglanti();
            zebercet.CommandText = "Insert into olcum (AdıSoyadı,Telefon,Adres,Boy,Yaka,Genişlik,Açıklama,ÖlçüAdı,Fiyat) values(@AdıSoyadı,@Telefon,@Adres,@Boy,@Yaka,@Genişlik,@Açıklama,@ÖlçüAdı,@Fiyat)";
            zebercet.Parameters.AddWithValue("@AdıSoyadı", textBox3.Text); ;
            zebercet.Parameters.AddWithValue("@Telefon", textBox4.Text);
            zebercet.Parameters.AddWithValue("@Adres", textBox1.Text);
            zebercet.Parameters.AddWithValue("@Boy", textBox2.Text);
            zebercet.Parameters.AddWithValue("@Yaka", textBox5.Text);
            zebercet.Parameters.AddWithValue("@Genişlik", textBox6.Text);
            zebercet.Parameters.AddWithValue("@Açıklama", textBox7.Text);
            zebercet.Parameters.AddWithValue("@ÖlçüAdı", textBox8.Text);
            zebercet.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            MusteriGetir();
            zebercet.ExecuteNonQuery();
            MessageBox.Show("Müşteri Bilgileri eklendi.");

        }

        private void SİL_Click(object sender, EventArgs e)
        {
           
            t.Clear();
            SqlCommand zebo = new SqlCommand();
            zebo.Connection = bag.baglanti();
            zebo.CommandText = "delete  from  olcum where AdıSoyadı=@AdıSoyadı";
            zebo.Parameters.AddWithValue("@AdıSoyadı", textBox3.Text);
            dataGridView1.DataSource = t;
            MusteriGetir();
            zebo.ExecuteNonQuery();
            MessageBox.Show("kayıt silindi.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlCommand zeb = new SqlCommand();
            zeb.Connection = bag.baglanti();
            zeb.CommandText = "update olcum set AdıSoyadı=@AdıSoyadı,Telefon=@Telefon,Adres=@Adres,Boy=@Boy,Yaka=@Yaka,Genişlik=@Genişlik,Açıklama=@Açıklama,ÖlçüAdı=@ÖlçüAdı,Fiyat=@Fiyat";
            zeb.Parameters.AddWithValue("@AdıSoyadı", textBox3.Text);
            zeb.Parameters.AddWithValue("@Telefon", textBox4.Text);
            zeb.Parameters.AddWithValue("@Adres", textBox1.Text);
            zeb.Parameters.AddWithValue("@Boy", textBox2.Text);
            zeb.Parameters.AddWithValue("@Yaka", textBox5.Text);
            zeb.Parameters.AddWithValue("@Genişlik", textBox6.Text);
            zeb.Parameters.AddWithValue("@Açıklama", textBox7.Text);
            zeb.Parameters.AddWithValue("@ÖlçüAdı", textBox8.Text);
            zeb.Parameters.AddWithValue("@Fiyat", textBox9.Text);       
            zeb.ExecuteNonQuery();
            bag.baglanti().Close();
            MusteriGetir();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TerziOlcumVeSiparis eos = new TerziOlcumVeSiparis();
            eos.Show();
            this.Close();



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
