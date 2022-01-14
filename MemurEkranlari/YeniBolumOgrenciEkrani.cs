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
    public partial class YeniBolumOgrenciEkrani : Form
    {
        string id;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        SqlCommand komut;


        public YeniBolumOgrenciEkrani(string id)
        {
            InitializeComponent();
            this.id = id;
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            //string txt_bolum = txt_bolum.Text;
            if (txt_bolum.Text != "")
            {
                baglanti.Close();
                string sorgu = "SELECT * FROM TBOLUM WHERE BolumAd = '" + txt_bolum.Text + "'";
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Columns.Count != 1)
                {
                    string sorgu1 = "INSERT INTO TBOLUM(BolumAd) VALUES (@BolumAd)";
                    komut = new SqlCommand(sorgu1, baglanti);
                    komut.Parameters.AddWithValue("@BolumAd", txt_bolum.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    OgrenciKayitEkrani frm = new OgrenciKayitEkrani(id);
                    frm.BolumGetir();

                    //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
                    frm.Show();
                    this.Hide();
                    MessageBox.Show("Başarıyla Eklendi!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Böyle bir bölüm zaten var. Eklemek istediğiniz bölümü yanlış veya eksik yazmış olabilir misiniz?", "Zaten Böyle Bir Bölüm Var!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();

                }
            }
            else
            {
                MessageBox.Show("Bölüm ismi boş bırakılamaz", "Giriş Kutuları Boş", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
