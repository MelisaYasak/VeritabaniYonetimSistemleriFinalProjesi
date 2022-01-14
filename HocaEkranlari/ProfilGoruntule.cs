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
    public partial class ProfilGoruntule : Form
    {
 
        public ProfilGoruntule(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        DataTable dtable = new DataTable();
        SqlDataAdapter sda;
        String id;

        private void profilGoruntule_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dtable.Clear();
                String query = "SELECT DISTINCT TDERS.BolumID,TOGRENCI.OgrID,TOGRENCI.OgrAd,TOGRENCI.OgrTarih FROM TOGRENCI " +
                    "INNER JOIN TDERS ON TDERS.BolumID = TOGRENCI.BolumID " +
                    "WHERE TDERS.HocaID ='" + id + "'";

                sda = new SqlDataAdapter(query, conn);
                sda.Fill(dtable);
                dataGridView1.DataSource = dtable;
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine();
            }
            
        }

        private void Ders()
        {
            try
            {
                dtable.Clear();
                conn.Open();
                String query = "SELECT DISTINCT TDERS.BolumID,TOGRENCI.OgrID,TOGRENCI.OgrAd,TOGRENCI.OgrTarih FROM TOGRENCI " +
                    "INNER JOIN TDERS ON TDERS.BolumID = TOGRENCI.BolumID " +
                    "WHERE (OgrID like '%" + textBox1.Text + "%' AND OgrAd like '%" + textBox2.Text + "%') AND TDERS.HocaID ='" + id + "'";
                sda = new SqlDataAdapter(query, conn);
                sda.Fill(dtable);
                dataGridView1.DataSource = dtable;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }
        private void listele_Click(object sender, EventArgs e)
        {
            Ders();
        }

        private void profil_goruntule_Click(object sender, EventArgs e)
        {
            Profil form2sec = new Profil(id);
            form2sec.a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form2sec.b = id;
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
