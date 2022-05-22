using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kutuphaneOtomasyon
{
    public partial class studentKayit : Form
    {
        MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

        public studentKayit()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Öğrenci Ekleme
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();

            MySqlCommand cmdekle = new MySqlCommand("insert into ogrenci (ogrenci_id,ad,soyad,bolum_ad,email) values (@ogrenci_id,@ad,@soyad,@bolum_ad,@email)", baglanti);
            cmdekle.Parameters.AddWithValue("@ogrenci_id", txt_ogrno.Text);
            cmdekle.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmdekle.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmdekle.Parameters.AddWithValue("@bolum_ad", cmb_bolum.Text);
            cmdekle.Parameters.AddWithValue("@email", txt_email.Text);
            

            if (String.IsNullOrEmpty(txt_ogrno.Text) || String.IsNullOrEmpty(txt_ad.Text) || String.IsNullOrEmpty(txt_soyad.Text) || String.IsNullOrEmpty(cmb_bolum.Text) || String.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Boş Geçilemez");           
            }
            else
            {
                cmdekle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
            }
            
            baglanti.Close();

            #endregion
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa don = new anasayfa();
            don.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        DataSet gecici = new DataSet();
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        #region Öğrenci Listeleme
        public static void displayAndSearch(string query, DataGridView dgv)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

            string sql = query;
            MySqlCommand cmd = new MySqlCommand(sql,baglanti);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            baglanti.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            displayAndSearch("SELECT ogrenci_id,ad,soyad,bolum_ad,email FROM ogrenci WHERE ogrenci_id LIKE '%" + textBox4.Text + "%'", dataGridView1);
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
