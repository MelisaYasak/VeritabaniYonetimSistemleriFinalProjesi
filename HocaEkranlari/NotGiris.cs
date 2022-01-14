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
    public partial class NotGiris : Form
    {
        public NotGiris(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        DataTable dtable = new DataTable();
        String id;

        private void dersSec()
        {
            try
            {
                dtable.Clear();
                conn.Open();
                String query = "Select * From TDERS WHERE HocaID = '" + id + "' AND DersYil like '%" + textBox1.Text + "%' AND DersYariyil like '%" + textBox2.Text + "%'";
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

        private void listele_Click(object sender, EventArgs e)
        {
            dersSec();
        }

        public String listView1_Goster()
        {
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ogrenci_listele_Click(object sender, EventArgs e)
        {
            String y = listView1_Goster();
            NotGiris2 form2sec = new NotGiris2(y);
            form2sec.Show();
            this.Hide();
        }

        private void notGiris_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dtable.Clear();
                String query = "SELECT * FROM TDERS WHERE HocaID = '" + id + "'";
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
        
        private void geri_don_Click(object sender, EventArgs e)
        {
            HocaEkrani form2sec = new HocaEkrani(id);
            form2sec.Show();
            this.Hide();
        }
    }
}
