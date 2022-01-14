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
using odevOgrenciOtomasyonu;

namespace odev
{
    public partial class HocaEkrani : Form
    {
        String id;
        public HocaEkrani(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");

        public void AdGetir()
        {
            try
            {
                string query = "Select HocaAd from THOCA WHERE HocaID = '" + id + "'";
                string deger;
                SqlCommand komut = new SqlCommand(query, conn);
                conn.Open();
                deger = (string)komut.ExecuteScalar();
                conn.Close();
                label1.Text = deger;
            }
            catch(Exception ex)
            {
                Console.WriteLine();
            }
        }

        private void not_girisi_Click(object sender, EventArgs e)
        {
            NotGiris formsec = new NotGiris(id);
            formsec.Show();
            this.Hide();
        }

        private void danisman_onay_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query = "SELECT * FROM TDANISMAN WHERE HocaID='" + id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count != 1)
            {
                MessageBox.Show(" Danışman değilsiniz. Giriş Yapamazsınız!", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            else {
                DanismanOnay formsec = new DanismanOnay(id);
                formsec.Show();
                this.Hide();
                conn.Close();
            }
            
        }

        private void profil_goruntule_Click(object sender, EventArgs e)
        {
            ProfilGoruntule formsec = new ProfilGoruntule(id);
            formsec.Show();
            this.Hide();
        }

        private void hocaEkrani_Load(object sender, EventArgs e)
        {
            AdGetir();
        }

        private void cikis_yap_Click(object sender, EventArgs e)
        {
           GirisEkrani formsec = new GirisEkrani();
           formsec.Show();
           this.Hide();
        }
    }
}
