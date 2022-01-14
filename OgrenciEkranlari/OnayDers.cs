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
    public partial class OnayDers : Form
    {
        String id;
        public OnayDers(String id)
        {
            InitializeComponent();
            this.id = id;
        }
        SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");

        private void OnayDers_Load(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT TNOT.DersID, TDERS.DersAd, TDERS.HocaID FROM TNOT " +
                    "INNER JOIN TDERS ON TNOT.DersID = TDERS.DersID " +
                    "WHERE TNOT.OgrID = '" + id + "' AND (TNOT.BasariliMi>0)";
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                dgvOnayDers.DataSource = dtable;
                cnn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciEkrani oe = new OgrenciEkrani(id);
            oe.Show();
            this.Close();
        }
    }
}
