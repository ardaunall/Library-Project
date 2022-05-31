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
        private void ogrListe()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter ema = new MySqlDataAdapter("SELECT ogrenci_id,ad,soyad,bolum_ad,email FROM ogrenci ", baglanti);
            DataTable ematab = new DataTable();
            ema.Fill(ematab);
            dataGridView3.DataSource = ematab;
            baglanti.Close();
            dataGridView3.Columns[0].HeaderText = "Öğrenci No";
            dataGridView3.Columns[1].HeaderText = "Ad";
            dataGridView3.Columns[2].HeaderText = "Soyad";
            dataGridView3.Columns[3].HeaderText = "Bölüm";
            dataGridView3.Columns[4].HeaderText = "Emanet Durumu";
        }
        private void ktpListe()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter ema = new MySqlDataAdapter("SELECT emanetkitap.emanet_id,ogrenci.ogrenci_id,ogrenci.ad,ogrenci.soyad,ogrenci.bolum_ad,emanetkitap.teslimedildi FROM emanetkitap INNER JOIN ogrenci ON emanetkitap.ogrenci_no = ogrenci.ogrenci_id ORDER BY ogrenci.ogrenci_id ASC", baglanti);
            DataTable ematab = new DataTable();
            ema.Fill(ematab);
            dataGridView1.DataSource = ematab;
            baglanti.Close();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Öğrenci No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].HeaderText = "Bölüm";
            dataGridView1.Columns[5].HeaderText = "Emanet Durumu";
        }
        public static void ogrenciAra(string query, DataGridView dgv)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            string sorgu = query;
            MySqlCommand ogr = new MySqlCommand(sorgu, baglanti);
            MySqlDataAdapter adp = new MySqlDataAdapter(ogr);
            DataTable ogrtbl = new DataTable();
            adp.Fill(ogrtbl);
            dgv.DataSource = ogrtbl;
            baglanti.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
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

        public int Kontrol(string Sorgu)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            int control;
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand(Sorgu, baglanti);
            control = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            return control;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            #region Öğrenci Silme İşlemi 
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            int kontrolID = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
            if (textBox7.Text == "" ||textBox2.Text == "" ||  textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Silinecek Öğrenciyi Seçiniz.");
            }
            else
            {
                if (Kontrol("SELECT COUNT('') FROM emanetkitap WHERE ogrenci_no = '" + kontrolID + "'") == 0)
                {
                    baglanti.Open();
                    MySqlCommand sil = new MySqlCommand("DELETE FROM ogrenci where ogrenci_id=@ogrID", baglanti);
                    sil.Parameters.AddWithValue("@ogrID", dataGridView3.CurrentRow.Cells[0].Value.ToString());
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Öğrenci Başarı İle Silindi.");

                    foreach (Control item in Controls)
                    {
                        if (item is TextBox & item is MaskedTextBox)
                        {
                            item.Text = null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci Emanet Listesinde Bulunduğu İçin Silinemez.");
                }
            }
            ogrListe();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region Emanet Sil
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            string sorgu = "DELETE FROM emanetkitap where emanet_id=@id";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Emanet Başarı İle Silindi.");
            ktpListe();
            #endregion
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Ogrenciİsleri_Shown(object sender, EventArgs e)
        {
            ogrListe();
            ktpListe();

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox7.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void txt_ogr_TextChanged(object sender, EventArgs e)
        {
            ogrenciAra("SELECT ogrenci_id,ad,soyad,bolum_ad,email FROM ogrenci WHERE ogrenci_id LIKE '%" + txt_ogr.Text + "%'", dataGridView3);
        }
    }
}
