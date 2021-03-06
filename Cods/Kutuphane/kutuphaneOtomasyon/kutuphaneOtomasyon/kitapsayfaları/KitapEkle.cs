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
    public partial class KitapEkle : Form
    {
        void KitapListele()
        {
           MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
           baglanti.Open();
           MySqlDataAdapter da = new MySqlDataAdapter("SELECT kitap.id,kitap.kitap_ad,yazar.ad,kategori.kategoritur,yayinevi.ad,konum.kategorikonum,kitap.dil,kitap.sayfasayisi,kitap.yayintarih,kitap.cevirmen,kitap.ciltsayisi,kitap.stok FROM kitap INNER JOIN yazar ON kitap.yazar_id = yazar.id INNER JOIN kategori ON kitap.kategori_id = kategori.id INNER JOIN yayinevi ON kitap.yayinevi_id = yayinevi.id INNER JOIN konum ON kitap.konum_id = konum.id", baglanti);
           DataTable tablo = new DataTable();
           da.Fill(tablo);
           dataGridView1.DataSource = tablo;
           baglanti.Close();

        }
        public KitapEkle()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private MySqlConnection getConnection()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            return baglanti;
        }

        #region Kitap Ekleme
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            #region tablo listeleme
            KitapListele();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazar";
            dataGridView1.Columns[3].HeaderText = "Kategori";
            dataGridView1.Columns[4].HeaderText = "Yayın Evi";
            dataGridView1.Columns[5].HeaderText = "Raf";
            dataGridView1.Columns[6].HeaderText = "Dil";
            dataGridView1.Columns[7].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[8].HeaderText = "Yayın Yılı";
            dataGridView1.Columns[9].HeaderText = "Çevirmen";
            dataGridView1.Columns[10].HeaderText = "Cilt Sayısı";
            dataGridView1.Columns[11].HeaderText = "Stok";
            #endregion
            #region Yazar        
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM yazar ORDER BY ad ASC", baglanti);
            MySqlDataAdapter daCategories = new MySqlDataAdapter(command);
            DataSet dsCategories = new DataSet();
            daCategories.Fill(dsCategories);
            command.ExecuteNonQuery();
            baglanti.Close();
            comboYazar.DataSource = dsCategories.Tables[0];
            comboYazar.DisplayMember = "ad";
            comboYazar.ValueMember = "id";
            comboYazar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboYazar.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboYazar.SelectedIndex = -1;
            #endregion
            #region Kategori
            baglanti.Open();
            MySqlCommand kat = new MySqlCommand("SELECT * FROM kategori ORDER BY kategoritur ASC", baglanti);
            MySqlDataAdapter daCategories2 = new MySqlDataAdapter(kat);
            DataSet dsCategories2 = new DataSet();
            daCategories2.Fill(dsCategories2);
            kat.ExecuteNonQuery();
            baglanti.Close();
            comboKategori.DataSource = dsCategories2.Tables[0];
            comboKategori.DisplayMember = "kategoritur";
            comboKategori.ValueMember = "id";
            comboKategori.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboKategori.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboKategori.SelectedIndex = -1;
            #endregion
            #region Yayın evi
            baglanti.Open();
            MySqlCommand yay = new MySqlCommand("SELECT * FROM yayinevi ORDER BY ad ASC", baglanti);
            MySqlDataAdapter daCategories3 = new MySqlDataAdapter(yay);
            DataSet dsCategories3 = new DataSet();
            daCategories3.Fill(dsCategories3);
            yay.ExecuteNonQuery();
            baglanti.Close();
            comboYayin.DataSource = dsCategories3.Tables[0];
            comboYayin.DisplayMember = "ad";
            comboYayin.ValueMember = "id";
            comboYayin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboYayin.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboYayin.SelectedIndex = -1;
            #endregion
            #region Konum
            baglanti.Open();
            MySqlCommand kon = new MySqlCommand("SELECT * FROM konum ORDER BY kategorikonum ASC", baglanti);
            MySqlDataAdapter daCategories4 = new MySqlDataAdapter(kon);
            DataSet dsCategories4 = new DataSet();
            daCategories4.Fill(dsCategories4);
            kon.ExecuteNonQuery();
            baglanti.Close();
            comboRaf.DataSource = dsCategories4.Tables[0];
            comboRaf.DisplayMember = "kategorikonum";
            comboRaf.ValueMember = "id";
            comboRaf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboRaf.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboRaf.SelectedIndex = -1;
            #endregion
        }
        private void button1_Click(object sender, EventArgs e)
        {
                MySqlConnection baglanti = getConnection();

                MySqlCommand ekle = new MySqlCommand("insert into kitap (yazar_id,kategori_id,yayinevi_id,konum_id,dil,sayfasayisi,yayintarih,ciltsayisi,stok,cevirmen,kitap_ad) values (@yazarId,@kategoriId,@yayinEviId,@konumId,@dil,@sayfa,@yayin,@cilt,@stok,@cevirmen,@ad)", baglanti);
                ekle.Parameters.AddWithValue("@yazarId", comboYazar.SelectedValue.ToString());
                ekle.Parameters.AddWithValue("@kategoriId", comboKategori.SelectedValue.ToString());
                ekle.Parameters.AddWithValue("@yayinEviId", comboYayin.SelectedValue.ToString());
                ekle.Parameters.AddWithValue("@konumId", comboRaf.SelectedValue.ToString());
                ekle.Parameters.AddWithValue("@dil", txt_dil.Text);
                ekle.Parameters.AddWithValue("@sayfa", txt_sayfasayi.Text);
                ekle.Parameters.AddWithValue("@yayin", txt_yayintarih.Text);
                ekle.Parameters.AddWithValue("@cilt", txt_cilt.Text);
                ekle.Parameters.AddWithValue("@stok", txt_stok.Text);
                ekle.Parameters.AddWithValue("@cevirmen", txt_cevirmen.Text);
                ekle.Parameters.AddWithValue("@ad", txt_kitapad.Text);

                if (String.IsNullOrEmpty(txt_dil.Text) || String.IsNullOrEmpty(txt_sayfasayi.Text) || String.IsNullOrEmpty(txt_yayintarih.Text) || String.IsNullOrEmpty(txt_cilt.Text) || String.IsNullOrEmpty(txt_stok.Text) || String.IsNullOrEmpty(txt_cevirmen.Text) || String.IsNullOrEmpty(txt_kitapad.Text))
                {
                    MessageBox.Show("Alanlar Boş Geçilemez.");
                }
                else
                {
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı.");
                }
            baglanti.Close();
            KitapListele();
            
        }
        #endregion
        #region Boş
        private void button5_Click(object sender, EventArgs e)
        {
            yazarekle yz = new yazarekle();
            yz.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            kategoriEkle ktg = new kategoriEkle();
            ktg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yayinEkle yyn = new yayinEkle();
            yyn.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            raf rf = new raf();
            rf.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }
        #endregion

        public int Kontrol(string Sorgu)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            int control;
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand(Sorgu,baglanti);
            control = Convert.ToInt32(cmd.ExecuteScalar());
            baglanti.Close();
            return control;
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            #region Kitap Silme
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            

            int kontrolID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (txt_id.Text == "" || txt_kitapad.Text == "" || comboYazar.Text == "" || comboYayin.Text == "" || comboKategori.Text == "" || comboRaf.Text == "" || txt_dil.Text == "" || txt_sayfasayi.Text == "" || txt_yayintarih.Text == "" || txt_cevirmen.Text == "" || txt_stok.Text == "")
            {
                MessageBox.Show("Silinecek Kitabı Seçiniz.");
            }
            else
            {
                if (Kontrol("SELECT COUNT('') FROM emanetkitap WHERE kitap_id = '"+ kontrolID +"'") == 0)
                {
                    baglanti.Open();
                    MySqlCommand sil = new MySqlCommand("DELETE FROM kitap where id=@kitapID",baglanti);
                    sil.Parameters.AddWithValue("@kitapID", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kitap Başarı İle Silindi.");

                    KitapListele();
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
                    MessageBox.Show("Kitap Emanet Listesinde Bulunduğu İçin Silinemez");
                }
            }
            baglanti.Close();
            KitapListele();
            #endregion
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_kitapad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboYazar.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboYayin.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboRaf.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_dil.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_sayfasayi.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_yayintarih.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_cevirmen.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_cilt.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                txt_stok.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            #region Kitap Güncelleme
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();

            MySqlCommand cmdekle = new MySqlCommand("update kitap set id=@id,yazar_id=@yazarId, kategori_id=@kategoriId, yayinevi_id=@yayinEviId, konum_id=@konumId, dil=@dil, sayfasayisi=@sayfa, yayintarih=@yayin, ciltsayisi=@cilt, stok=@stok, cevirmen=@cevirmen, kitap_ad=@ad where kitap.id=@id", baglanti);
            cmdekle.Parameters.AddWithValue("@id", txt_id.Text);
            cmdekle.Parameters.AddWithValue("@yazarId", comboYazar.SelectedValue.ToString());
            cmdekle.Parameters.AddWithValue("@kategoriId", comboKategori.SelectedValue.ToString());
            cmdekle.Parameters.AddWithValue("@yayinEviId", comboYayin.SelectedValue.ToString());
            cmdekle.Parameters.AddWithValue("@konumId", comboRaf.SelectedValue.ToString());
            cmdekle.Parameters.AddWithValue("@dil", txt_dil.Text);
            cmdekle.Parameters.AddWithValue("@sayfa", txt_sayfasayi.Text);
            cmdekle.Parameters.AddWithValue("@yayin", txt_yayintarih.Text);
            cmdekle.Parameters.AddWithValue("@cilt", txt_cilt.Text);
            cmdekle.Parameters.AddWithValue("@stok", txt_stok.Text);
            cmdekle.Parameters.AddWithValue("@cevirmen", txt_cevirmen.Text);
            cmdekle.Parameters.AddWithValue("@ad", txt_kitapad.Text);

            if (String.IsNullOrEmpty(txt_dil.Text) || String.IsNullOrEmpty(txt_sayfasayi.Text) || String.IsNullOrEmpty(txt_yayintarih.Text) || String.IsNullOrEmpty(txt_cilt.Text) || String.IsNullOrEmpty(txt_stok.Text) || String.IsNullOrEmpty(txt_cevirmen.Text) || String.IsNullOrEmpty(txt_kitapad.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez.");
            }
            else
            {
                cmdekle.ExecuteNonQuery();
                MessageBox.Show("Kitap Güncelleme Başarılı.");
            }
            baglanti.Close();
            KitapListele();
            #endregion
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region Kitap Arama
        public static void kitapAra(string query, DataGridView dgv)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            string sorgu = query;
            baglanti.Open();
            MySqlCommand ogr = new MySqlCommand(sorgu, baglanti);
            MySqlDataAdapter adp = new MySqlDataAdapter(ogr);
            DataTable ogrtbl = new DataTable();
            adp.Fill(ogrtbl);
            dgv.DataSource = ogrtbl;
            baglanti.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kitapAra("SELECT kitap.id,kitap.kitap_ad,yazar.ad,kategori.kategoritur,yayinevi.ad,konum.kategorikonum,kitap.dil,kitap.sayfasayisi,kitap.yayintarih,kitap.cevirmen,kitap.ciltsayisi,kitap.stok FROM kitap INNER JOIN yazar ON kitap.yazar_id = yazar.id INNER JOIN kategori ON kitap.kategori_id = kategori.id INNER JOIN yayinevi ON kitap.yayinevi_id = yayinevi.id INNER JOIN konum ON kitap.konum_id = konum.id WHERE kitap_ad LIKE '%" + textBox1.Text + "%'", dataGridView1);
        }
        #endregion

        private void comboYazar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
