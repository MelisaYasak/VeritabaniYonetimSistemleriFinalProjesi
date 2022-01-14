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

namespace odevOgrenciOtomasyonu
{
    public partial class DanismanOnayEkrani : Form
    {
        String id;
        public DanismanOnayEkrani(String id)
        {
            InitializeComponent();
            this.id = id;
        }
        SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciEkrani oe = new OgrenciEkrani(id);
            oe.Show();
            this.Close();
        }

        private void DanismanOnayEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                String query = "SELECT TDERS.DersID, TDERS.DersAd, THOCA.HocaAd, TDERS.DersYil, TDERS.DersYariyil FROM TDERS INNER JOIN THOCA ON TDERS.HocaID = THOCA.HocaID INNER JOIN TOGRENCI ON TOGRENCI.BolumID = TDERS.BolumID WHERE TOGRENCI.OgrID ='" + id + "'";

                DataTable dtable = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
                sda.Fill(dtable);
                dgwtumders.DataSource = dtable;
                cnn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            string seceltDersid = dgwtumders.CurrentRow.Cells[0].Value.ToString();
            cnn.Open();
            String query = "SELECT TDERS.DersID, TDERS.DersAd, THOCA.HocaAd, TDERS.DersYil, TDERS.DersYariyil FROM TDERS INNER JOIN THOCA ON TDERS.HocaID = THOCA.HocaID INNER JOIN TOGRENCI ON TOGRENCI.BolumID = TDERS.BolumID WHERE TOGRENCI.OgrID ='" + id + "' AND TDERS.DersID='"+seceltDersid+"'";

            DataTable dtable = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            sda.Fill(dtable);
            dgwgonders.DataSource = dtable;
            cnn.Close();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            dgwgonders.DataSource = null;
        }
        private bool deneme()

        {
            try
            {
                string dersId = null;
                dersId = dgwgonders.CurrentRow.Cells[0].Value.ToString();
                String query = "INSERT INTO TDANISMANONAY (DanısmanID, OgrID, DersID, Onaylandi) VALUES (NULL, @id, @dersId, 0)";
                SqlCommand cm = new SqlCommand(query, cnn);
                cm.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                cm.Parameters.AddWithValue("@dersId", Convert.ToInt32(dersId));
            }
            catch
            {
                MessageBox.Show("Danışman onayına göndermek üzere ders seçmelisiniz!", "DERS SEÇİMİ YAPMALISINIZ!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            return true;
        }

        private void btnDanOnayGon_Click(object sender, EventArgs e)
        {
            if (deneme())
            {
                MessageBox.Show("Danışman Onayına Gönderme İşlemi Başarılı!");
            }
            else
            {
                MessageBox.Show("Danışman Onayına Gönderme İşlemi Başarısız!", "Tekrar Deneyiniz!");
            }

        }
    }
}
