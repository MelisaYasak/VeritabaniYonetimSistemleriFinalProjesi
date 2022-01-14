using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace odevsena
{ 
        public partial class OgrenciKayitEkrani : Form
        {
            string id;
            SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
            SqlCommand komut;
            SqlDataAdapter da;

            public OgrenciKayitEkrani(string id)
            {
                InitializeComponent();
                this.id = id;
            }


            void OgrenciGetir()
            {

                baglanti.Open();
                da = new SqlDataAdapter("SELECT TOGRENCI.OgrID, TOGRENCI.OgrAd, TOGRENCI.OgrSifre, TOGRENCI.OgrTarih, TBOLUM.BolumAd FROM TOGRENCI INNER JOIN TBOLUM ON TOGRENCI.BolumID = TBOLUM.BolumID ", baglanti);
                DataTable tablo = new DataTable();

                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            public void BolumGetir()
            {

                da = new SqlDataAdapter("SELECT *FROM TBOLUM", baglanti);
                DataTable tablo = new DataTable();

                da.Fill(tablo);
                comboBox_bolum.ValueMember = "BolumID";
                comboBox_bolum.DisplayMember = "BolumAd";
                comboBox_bolum.DataSource = tablo;

            }


            private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
            {
                txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_date.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_pasword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox_bolum.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }

            private void btn_ekle_Click(object sender, EventArgs e)
            {

                string a = select();
                string sorgu = "INSERT INTO TOGRENCI(OgrAd,OgrSifre,OgrTarih,BolumID) VALUES (@OgrAd,@OgrSifre,@OgrTarih,@BolumID)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OgrAd", txt_name.Text);
                komut.Parameters.AddWithValue("@OgrSifre", txt_pasword.Text);
                komut.Parameters.AddWithValue("@OgrTarih", txt_date.Text);
                komut.Parameters.AddWithValue("@BolumID", a);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                OgrenciGetir();

            MessageBox.Show("Başarıyla Eklendi!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Silmek istediğinizden emin misiniz", "Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result1 == DialogResult.OK) { 
                string sorgu = "DELETE FROM TOGRENCI WHERE OgrID = @OgrID";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OgrID", Convert.ToInt32(txt_no.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                OgrenciGetir();
                MessageBox.Show("Başarıyla Silindi!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Güncellemek İstediğinizden Emin misiniz?", "Emin misiniz?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result1 == DialogResult.OK)
            {
                string sorgu = "UPDATE TOGRENCI SET OgrAd = @OgrAd,OgrSifre= @OgrSifre, OgrTarih=@OgrTarih Where OgrID = @OgrID ";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@OgrID ", Convert.ToInt32(txt_no.Text));
                komut.Parameters.AddWithValue("@OgrAd", txt_name.Text);
                komut.Parameters.AddWithValue("@OgrSifre", txt_pasword.Text);
                komut.Parameters.AddWithValue("@OgrTarih", txt_date.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                OgrenciGetir();
                MessageBox.Show("Başarıyla Güncellendi!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private string select()
        {
            int b;
            string a = comboBox_bolum.Text;
            string sorgu = "SELECT BolumID FROM TBOLUM WHERE BolumAd='" + a + "'";
                komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                b = (int)komut.ExecuteScalar();
                baglanti.Close();
                return b.ToString();

            }

            private void btn_bolum_ekle_Click(object sender, EventArgs e)
            {
                YeniBolumOgrenciEkrani frm = new YeniBolumOgrenciEkrani(id);
                //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
                frm.Show();
                this.Hide();
            }

             private void button5_Click(object sender, EventArgs e)
        {
                MemurEkrani frm = new MemurEkrani(id);
                //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
                frm.Show();
                this.Hide();
               }

        private void OgrenciKayitEkrani_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
            BolumGetir();
        }

    }
}




