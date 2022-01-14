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
    public partial class NotGiris2 : Form
    {

        public NotGiris2(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        String id;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        DataTable dtable = new DataTable();
        SqlCommand com;

        public void AdGetir1()
        {
            try
            {
                dtable.Clear();
                conn.Open();
                String query = "SELECT TDERS.HocaID, TNOT.DersID, TOGRENCI.OgrID,TOGRENCI.OgrAd,TNOT.Vize, TNOT.Final, TNOT.Butunleme FROM TNOT INNER JOIN TOGRENCI ON TOGRENCI.OgrID = TNOT.OgrID INNER JOIN TDERS ON TNOT.DersID = TDERS.DersID WHERE TNOT.DersID = '" + id + "'";
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

        private void GectiMi(String a, String b)
        {
            try
            {
                String sorgu = "UPDATE TNOT SET BasariliMi = 1 WHERE(Vize * 0.6 + Final * 0.4) >= 50 AND DersID = '" + a + "'AND OgrID = '" + b + "'";
                com = new SqlCommand(sorgu, conn);
                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdGetir1();
        }

        private void ekle_vize_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Eklemek istediğinize emin misin?","Ekleme", MessageBoxButtons.YesNo);
            String a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String b = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    string sorgu = "UPDATE TNOT SET Vize=@Vize WHERE DersID = '" + a + "' AND OgrID ='" + b + "'";
                    com = new SqlCommand(sorgu, conn);
                    com.Parameters.AddWithValue("@Vize", Convert.ToInt32(textBox1.Text));
                    conn.Open();
                    com.ExecuteNonQuery();
                    conn.Close();
                    AdGetir1();
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

        private void ekle_final_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Eklemek istediğinize emin misin?", "Ekleme", MessageBoxButtons.YesNo);
            String a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String b = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    string sorgu = "UPDATE TNOT SET Final = @Final WHERE DersID = '" + a + "' AND OgrID ='" + b + "'";
                    com = new SqlCommand(sorgu, conn);
                    com.Parameters.AddWithValue("@Final", Convert.ToInt32(textBox2.Text));
                    conn.Open();
                    com.ExecuteNonQuery();
                    conn.Close();
                    AdGetir1();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                }
            }
            else
            {

            }
            GectiMi(a,b);
        }

        private void ekle_butunleme_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Eklemek istediğinize emin misin?", "Ekleme", MessageBoxButtons.YesNo);
            String a = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            String b = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    string sorgu = "UPDATE TNOT SET Butunleme = @Butunleme WHERE DersID = '" + a + "' AND OgrID ='" + b + "'";
                    com = new SqlCommand(sorgu, conn);
                    com.Parameters.AddWithValue("@Butunleme", Convert.ToInt32(textBox3.Text));
                    conn.Open();
                    com.ExecuteNonQuery();
                    conn.Close();
                    AdGetir1();
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
            return dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void geri_don_Click(object sender, EventArgs e)
        {
            String id = listView1_Goster();
            NotGiris form2sec = new NotGiris(id);
            form2sec.Show();
            this.Hide();
        }
    }
}

