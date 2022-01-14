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
    public partial class HocaKayitEkrani : Form
    {
        string id;
        SqlConnection baglanti=new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        public HocaKayitEkrani(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        void HocaGetir()
        {
            try
            {

                baglanti.Open();
                da = new SqlDataAdapter("SELECT THOCA.HocaID, THOCA.HocaAd, THOCA.HocaSifre, TBOLUM.BolumAd FROM THOCA INNER JOIN TBOLUM ON THoca.BolumID = TBOLUM.BolumID ", baglanti);
                DataTable tablo = new DataTable();

                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
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

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string a = select();
           
                    string sorgu = "INSERT INTO THOCA(HocaAd,HocaSifre,BolumID) VALUES (@HocaAd,@HocaSifre, @BolumID)";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@HocaAd", txt_name.Text);
                    komut.Parameters.AddWithValue("@HocaSifre", txt_pasword.Text);
                    komut.Parameters.AddWithValue("@BolumID", a);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    HocaGetir();
                    MessageBox.Show("Başarıyla Eklendi!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE THOCA SET HocaAd = @HocaAd,HocaSifre= @HocaSifre Where HocaID= @HocaID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@HocaID", txt_no.Text);
            komut.Parameters.AddWithValue("@HocaAd", txt_name.Text);
            komut.Parameters.AddWithValue("@HocaSifre", txt_pasword.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            HocaGetir();
            MessageBox.Show("Başarıyla Güncellendi!", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_pasword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
            YeniBolumHocaEkrani frm = new YeniBolumHocaEkrani(id);
            //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
            frm.Show();
            this.Hide();
        }

        private void HocaKayitEkrani_Load(object sender, EventArgs e)
        {
            HocaGetir();
            BolumGetir();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MemurEkrani frm = new MemurEkrani(id);
            //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
            frm.Show();
            this.Hide();

        }

        
    }
}
