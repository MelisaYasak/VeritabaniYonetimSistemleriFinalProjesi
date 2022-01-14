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
    public partial class DanismanOnay : Form
    {
        public DanismanOnay(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        DataTable dtable = new DataTable();
        String id;

        private void dersleriListele()
        {
            try
            {
                conn.Open();
                String query = "SELECT DISTINCT TDANISMANONAY.OgrID, TOGRENCI.OgrAd FROM TDANISMANONAY INNER JOIN TOGRENCI ON TDANISMANONAY.OgrID = TOGRENCI.OgrID INNER JOIN TDERS ON TDANISMANONAY.DersID = TDERS.DersID WHERE TDERS.HocaID ='"+ id+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dtable);
                dataGridView1.DataSource = dtable;
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine();
            }
        }

        public String listView1_Goster()
        {
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void danismanOnay_Load(object sender, EventArgs e)
        {
            dersleriListele();
        }

        private void dersleri_listele_Click(object sender, EventArgs e)
        {
            String id = listView1_Goster();
            Onayla form2sec = new Onayla(id);
            form2sec.Show();
            this.Hide();

        }

        private void geri_don_Click(object sender, EventArgs e)
        {
            HocaEkrani form2sec = new HocaEkrani(id);
            form2sec.Show();
            this.Hide();
        }
    }
}
