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

namespace odev
{
    public partial class Profil : Form
    {
        String id;
        public Profil(String id)
        {
            InitializeComponent();
            this.id = id;   
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        DataTable dtable = new DataTable();

        public string a, b;
        public void AdGetir()
        {
            try
            {
                string sorgu = "Select OgrAd from TOGRENCI WHERE OgrID =  '" + a + "'";
                string deger;
                SqlCommand komut = new SqlCommand(sorgu, conn);
                conn.Open();
                deger = (string)komut.ExecuteScalar();
                conn.Close();
                label1.Text = deger;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public void AdGetir1()
        {
            try
            {
                conn.Open();
                String query = "SELECT TNOT.DersID, TDERS.DersAd, THOCA.HocaAd, TNOT.Vize, TNOT.Final, TNOT.Butunleme FROM TNOT INNER JOIN TDERS ON TNOT.DersID = TDERS.DersID INNER JOIN THOCA ON THOCA.HocaID = TDERS.HocaID INNER JOIN TDANISMANONAY ON TDANISMANONAY.DersID = TDERS.DersID WHERE TDANISMANONAY.Onaylandi =1 AND TNOT.OgrID = '" + a + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dtable);
                dataGridView1.DataSource = dtable;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void profil_Load(object sender, EventArgs e)
        {
            AdGetir();
            AdGetir1();
        }


        /*blic String listView1_Goster()
        {
            return 
        }*/

        private void geri_don_Click(object sender, EventArgs e)
        {
            //ring y = listView1_Goster();
            ProfilGoruntule form2sec = new ProfilGoruntule(b);
            form2sec.Show();
            this.Hide();
        }
    }
}
