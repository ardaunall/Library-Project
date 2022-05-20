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
    public partial class yazarekle : Form
    {
        public yazarekle()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

        private void yzreklebtn_Click(object sender, EventArgs e)
        {
            #region Yazar Ekleme
            baglanti.Open();
            MySqlCommand yazar = new MySqlCommand("insert into yazar (ad) values (@ad)", baglanti);
            yazar.Parameters.AddWithValue("@ad", txt_yazar.Text);

            if (String.IsNullOrEmpty(txt_yazar.Text))
            {
                MessageBox.Show("Boş geçilemez");
            }
            else
            {
                yazar.ExecuteNonQuery();
                MessageBox.Show("Yazar Ekleme İşlemi Başarılı");

            }
            baglanti.Close();
            #endregion
        }

        private void yazarekle_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void yazarekle_Load(object sender, EventArgs e)
        {

        }
    }
}
