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

    public partial class Onayla : Form
    {

        public Onayla(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        DataTable dtable = new DataTable();
        SqlCommand com;
        String id;

        public void AdGetir()
        {
            try
            {
                string sorgu = "Select OgrAd from TOGRENCI WHERE OgrID =  '" + id + "'";
                string deger;
                SqlCommand komut = new SqlCommand(sorgu, conn);
                conn.Open();
                deger = (string)komut.ExecuteScalar();
                conn.Close();
                label1.Text = deger;
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }

        public void DersGetir()
        {
            try
            {
                dtable.Clear();
                conn.Open();
                String query = "SELECT  TDANISMANONAY.OgrID, TDANISMANONAY.DersID, TDERS.DersAd,THOCA.HocaID, THOCA.HocaAd, TDANISMANONAY.Onaylandi FROM TDANISMANONAY INNER JOIN TDERS ON TDANISMANONAY.DersID = TDERS.DersID INNER JOIN THOCA ON THOCA.HocaID = TDERS.HocaID WHERE TDANISMANONAY.OgrID = '" + id + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dtable);
                dataGridView1.DataSource = dtable;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }

        private void onayla_Load(object sender, EventArgs e)
        {
            DersGetir();
            AdGetir();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Onaylamak istediğinize emin misiniz?","ONAY", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    String a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    String b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string sorgu = "UPDATE TDANISMANONAY SET Onaylandi = @Onaylandi WHERE OgrID = '" + a + "'  AND DersID = '" + b + "'";
                    com = new SqlCommand(sorgu, conn);
                    com.Parameters.AddWithValue("@Onaylandi", 1);
                    conn.Open();
                    com.ExecuteNonQuery();
                    conn.Close();
                    DersGetir();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                
            }
            
        }

        public String listView1_Goster()
        {
            return dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void geri_don_Click(object sender, EventArgs e)
        {
            String z = listView1_Goster();
            DanismanOnay form2sec = new DanismanOnay(z);
            form2sec.Show();
            this.Hide();
        }
    }
}
