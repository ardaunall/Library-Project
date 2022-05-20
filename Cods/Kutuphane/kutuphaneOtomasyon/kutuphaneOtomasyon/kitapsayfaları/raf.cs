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
    public partial class raf : Form
    {
        public raf()
        {
            InitializeComponent();
        }

        private void rafeklebtn_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand konum = new MySqlCommand("insert into konum (kategorikonum) values (@konum)", baglanti);
            konum.Parameters.AddWithValue("@konum", txt_raf.Text);
            if (String.IsNullOrEmpty(txt_raf.Text))
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                konum.ExecuteNonQuery();
                MessageBox.Show("Raf Ekleme Başarılı");
            }
            baglanti.Close();
        }
    }
}
