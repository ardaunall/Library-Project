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
    public partial class yayinEkle : Form
    {
        public yayinEkle()
        {
            InitializeComponent();
        }

        private void yayinBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand yayin = new MySqlCommand("insert into yayinevi (ad) values (@yayinev)", baglanti);
            yayin.Parameters.AddWithValue("@yayinev", txt_yayin.Text);
            if (String.IsNullOrEmpty(txt_yayin.Text))
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                yayin.ExecuteNonQuery();
                MessageBox.Show("Yayın Evi Kayıdı Başarılı");
            }
            baglanti.Close();
        }
    }
}
