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
    public partial class Ogrenciİsleri : Form
    {
        public Ogrenciİsleri()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void cikis_yap_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisYap lgn = new GirisYap();
            lgn.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void listele_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            #region Öğrenci Silme İşlemi
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("delete from ogrenci where ogrenci_id='" + textBox1.Text + "'", baglanti);

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarılı");
            }

            baglanti.Close();

            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Emanet Durumu
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter ema = new MySqlDataAdapter("SELECT ogrenci.ogrenci_id,ogrenci.ad,ogrenci.soyad,ogrenci.bolum_ad,emanetkitap.teslimedildi FROM emanetkitap INNER JOIN ogrenci ON emanetkitap.ogrenci_no = ogrenci.ogrenci_id ORDER BY ogrenci.ogrenci_id ASC", baglanti);
            DataTable ematab = new DataTable();
            ema.Fill(ematab);
            dataGridView1.DataSource = ematab;
            baglanti.Close();
            dataGridView1.Columns[0].HeaderText = "Öğrenci No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Bölüm";
            dataGridView1.Columns[4].HeaderText = "Emanet Durumu";
            #endregion
        }
    }
}
