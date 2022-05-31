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
        void ogrenciListele()
        {
            #region liste data
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * From ogrenci", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            #endregion
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            #region Öğrenci listele
            ogrenciListele();
            dataGridView1.Columns[0].HeaderText = "Öğrenci No";
            dataGridView1.Columns[1].HeaderText = "Ad ";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Bölüm";
            dataGridView1.Columns[4].HeaderText = "E-Mail";
            #endregion
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
            ogrenciListele();
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
        public static void ogrenciAra(string query, DataGridView dgv)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

            string sorgu = query;
            MySqlCommand ogr = new MySqlCommand(sorgu,baglanti);
            MySqlDataAdapter adp = new MySqlDataAdapter(ogr);
            DataTable ogrtbl = new DataTable();
            adp.Fill(ogrtbl);
            dgv.DataSource = ogrtbl;
            baglanti.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ogrenciAra("SELECT ogrenci_id,ad,soyad,bolum_ad,email FROM ogrenci WHERE ogrenci_id LIKE '%" + txt_ograra.Text + "%'", dataGridView1);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
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
        private void button2_Click_2(object sender, EventArgs e)
        {
            #region Öğrenci Güncelleme
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

            int kontrolID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (txt_ogrno.Text == "" || textBox1.Text == "" || txt_ad.Text == "" || txt_soyad.Text == "" || txt_email.Text == "" || cmb_bolum.Text == "")
            {
                MessageBox.Show("Güncellenecek Öğrenciyi Seçiniz");
            }
            else
            {
                if (Kontrol("SELECT COUNT('') FROM emanetkitap WHERE ogrenci_no = '" + kontrolID + "'") == 0)
                {
                    baglanti.Open();
                    MySqlCommand cmdekle = new MySqlCommand("update ogrenci set ogrenci_id=@ogrenci_id, ad=@ad, soyad=@soyad, bolum_ad=@bolum_ad, email=@email WHERE  ogrenci.ogrenci_id = @ogr", baglanti);
                    cmdekle.Parameters.AddWithValue("@ogrenci_id", txt_ogrno.Text);
                    cmdekle.Parameters.AddWithValue("@ogr", textBox1.Text);
                    cmdekle.Parameters.AddWithValue("@ad", txt_ad.Text);
                    cmdekle.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    cmdekle.Parameters.AddWithValue("@bolum_ad", cmb_bolum.Text);
                    cmdekle.Parameters.AddWithValue("@email", txt_email.Text);
                    cmdekle.ExecuteNonQuery();
                    baglanti.Close();
                    ogrenciListele();
                    foreach (Control item in Controls)
                    {
                        if (item is TextBox & item is MaskedTextBox & item is ComboBox)
                        {
                            item.Text = null;
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Öğrenci Emanet Listesinde Bulunduğu İçin Numarası Güncellemez.");
                }

            }
            ogrenciListele();
            baglanti.Close();


            #endregion
        }

        private void cmb_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentKayit_Shown(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_ogrno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmb_bolum.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
