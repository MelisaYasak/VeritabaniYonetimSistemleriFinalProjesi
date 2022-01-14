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
    public partial class DanismanAtamaEkrani : Form
    {
        string id;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter da;

        public DanismanAtamaEkrani(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        public void BolumGetir()
        {
            try
            {
                conn.Open();

                da = new SqlDataAdapter("SELECT *FROM TBOLUM", conn);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                comboBox_bolum.ValueMember = "BolumID";
                comboBox_bolum.DisplayMember = "BolumAd";
                comboBox_bolum.DataSource = tablo;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void comboBox_bolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            hoca();
            tarih();

        }
        private string select()
        {
            conn.Close();
            int b;
            string a = comboBox_bolum.Text;
            string sorgu = "SELECT BolumID FROM TBOLUM WHERE BolumAd='" + a + "'";
            com = new SqlCommand(sorgu, conn);
            conn.Open();
            b = (int)com.ExecuteScalar();
            conn.Close();
            return b.ToString();

        }
        private string select2()
        {
            conn.Close();
            int b;
            string a = comboBox_hoca.Text;
            string sorgu = "SELECT HocaID FROM THOCA WHERE HocaAd='" + a + "'";
            com = new SqlCommand(sorgu, conn);
            conn.Open();
            b = (int)com.ExecuteScalar();
            conn.Close();
            return b.ToString();

        }


        public void tarih()
        {
            string a = select();

            DataTable tablo = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM TDANISMAN,TBOLUM WHERE TDANISMAN.BolumID=TBOLUM.BolumID AND TDANISMAN.BolumID='" + a + "'", conn);


            da.Fill(tablo);
            conn.Open();
            comboBox_tarih.ValueMember = "DanısmanID";
            comboBox_tarih.DisplayMember = "BolumTarih";
            comboBox_tarih.DataSource = tablo;
            conn.Close();
        }
        public void hoca()
        {
            string a = select();
            DataTable tablo = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM THOCA,TBOLUM WHERE THOCA.BolumID=TBOLUM.BolumID AND THOCA.BolumID='" + a + "'", conn);


            da.Fill(tablo);
            conn.Open();
            comboBox_hoca.ValueMember = "HocaID";
            comboBox_hoca.DisplayMember = "HocaAd";
            comboBox_hoca.DataSource = tablo;
            conn.Close();
        }



        private void btn_ekle_Click(object sender, EventArgs e)
        {

            string b = select2();
            string a = select();
            if (MessageBox.Show("Danışman olarak atanacak. Emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sorgu = "UPDATE TDANISMAN SET BolumID=@BolumID,HocaID=@HocaID WHERE BolumTarih=@BolumTarih";

                com = new SqlCommand(sorgu, conn);

                com.Parameters.AddWithValue("@BolumTarih", Convert.ToInt32(comboBox_tarih.Text));
                com.Parameters.AddWithValue("@HocaID", b);
                com.Parameters.AddWithValue("@BolumID", a);

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
                DanismanAtamaEkrani f = new DanismanAtamaEkrani(id);
                f.Show();
                this.Hide();
                MessageBox.Show("Danışman Atama İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK);
                
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemurEkrani frm = new MemurEkrani(id);
            //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
            frm.Show();
            this.Hide();
        }

        private void DanismanAtamaEkrani_Load(object sender, EventArgs e)
        {
            BolumGetir();
        }
    }

}
