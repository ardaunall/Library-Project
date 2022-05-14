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
    public partial class AdminKayit : Form
    {
        public AdminKayit()
        {
            InitializeComponent();
        }

        private void AdminKayit_Load(object sender, EventArgs e)
        {
            #region Personel türleri
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            cmb_departman.Items.Add("Kütüphane Görevlisi");
            cmb_departman.Items.Add("Öğrenci İşleri");
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Personel Ekleme
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();

            MySqlCommand cmdekle = new MySqlCommand("insert into admin (id,ad,soyad,email,kullaniciadi,sifre,departman) values (@id,@ad,@soyad,@email,@kullaniciadi,@sifre,@departman)", baglanti);
            cmdekle.Parameters.AddWithValue("@id", txt_id.Text);
            cmdekle.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmdekle.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmdekle.Parameters.AddWithValue("@email", txt_email.Text);
            cmdekle.Parameters.AddWithValue("@kullaniciadi", txt_kullaniciadi.Text);
            cmdekle.Parameters.AddWithValue("@sifre", txt_sifre.Text);
            cmdekle.Parameters.AddWithValue("@departman", cmb_departman.Text);
            
            

            if (String.IsNullOrEmpty(txt_id.Text) || String.IsNullOrEmpty(txt_ad.Text) || String.IsNullOrEmpty(txt_soyad.Text) || String.IsNullOrEmpty(txt_email.Text) || String.IsNullOrEmpty(txt_kullaniciadi.Text) || String.IsNullOrEmpty(txt_sifre.Text) || String.IsNullOrEmpty(cmb_departman.Text))
            {
                MessageBox.Show("Boş Geçilemez"); 
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı");

                GirisYap accc = new GirisYap();
                this.Hide();
                accc.Show();
            }
            cmdekle.ExecuteNonQuery();
            baglanti.Close();

            #endregion

        }

        private void cmb_departman_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
