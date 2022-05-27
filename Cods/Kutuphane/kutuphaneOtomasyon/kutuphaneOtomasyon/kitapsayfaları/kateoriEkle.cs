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
    public partial class kategoriEkle : Form
    {
        public kategoriEkle()
        {
            InitializeComponent();
        }

        private void yzreklebtn_Click(object sender, EventArgs e)
        {
            #region Kategori kayıt
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand chk = new MySqlCommand("select kategoritur from kategori where kategoritur='" + txt_kate.Text + "'", baglanti);
            string ktg = (string)chk.ExecuteScalar();
            if (ktg == txt_kate.Text)
            {
                MessageBox.Show("Kategori Zaten Var");
            }
            else
            {
                MySqlCommand kategori = new MySqlCommand("insert into kategori (kategoritur) values (@tur)", baglanti);
                kategori.Parameters.AddWithValue("@tur", txt_kate.Text);
                if (String.IsNullOrEmpty(txt_kate.Text))
                {
                    MessageBox.Show("Boş Geçilemez");
                }
                else
                {
                    kategori.ExecuteNonQuery();
                    MessageBox.Show("Kategori Ekleme İşlemi Başarılı");
                }
            }
            baglanti.Close();
            #endregion
        }
    }
}
