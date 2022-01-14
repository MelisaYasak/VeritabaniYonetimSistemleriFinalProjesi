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
    public partial class OgrenciEkrani : Form
    {
        String id;
        public OgrenciEkrani(String id)
        {
            InitializeComponent();
            this.id = id;
        }
        SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.Show();
            this.Hide();
        }

        private void btnDersKay_Click(object sender, EventArgs e)
        {
            DanismanOnayEkrani doe = new DanismanOnayEkrani(id);
            doe.Show();
            this.Hide();
        }

        private void OgrenciEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                String query = "SELECT OgrID FROM TOGRENCI WHERE OgrID = '" + id + "'";
                SqlCommand sc_q1 = new SqlCommand(query, cnn);
                int s_q1 = Convert.ToInt32(sc_q1.ExecuteScalar());

                String query2 = "SELECT OgrAd FROM TOGRENCI WHERE OgrID = '" + id + "'";
                SqlCommand sc_q2 = new SqlCommand(query2, cnn);
                String s_q2 = (string)sc_q2.ExecuteScalar();

                cnn.Close();

                lblOgrId.Text = "Öğrenci Okul Numarası: " + s_q1.ToString();
                lblOgrAd.Text = "ADI Soyadı: " + s_q2;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnOnDers_Click(object sender, EventArgs e)
        {
            OnayDers od = new OnayDers(id);
            od.Show();
            this.Hide();
        }

        private void btnNotGor_Click_1(object sender, EventArgs e)
        {
            NotGorEkrani nge = new NotGorEkrani(id);
            nge.Show();
            this.Hide();
        }
    }
}
