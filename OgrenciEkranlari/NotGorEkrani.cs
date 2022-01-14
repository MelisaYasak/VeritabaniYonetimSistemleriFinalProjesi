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
    public partial class NotGorEkrani : Form
    {
        String id;
        public NotGorEkrani(String id)
        {
            InitializeComponent();
            this.id = id;
        }

        SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");

        private void btnGeri_Click(object sender, EventArgs e)
        {
            OgrenciEkrani oe = new OgrenciEkrani(id);
            oe.Show();
            this.Hide();
        }

        private void NotGorEkrani_Load(object sender, EventArgs e)
        {
            gridviewGoster();

            comboYil();
            comboYariyil();
        }
        private void gridviewGoster()
        {
            try
            {
                String query = "SELECT TNOT.DersID, TDERS.DersAd, TNOT.Vize, TNOT.Final, TNOT.Butunleme FROM TNOT INNER JOIN TDERS  ON TNOT.DersID = TDERS.DersID WHERE TNOT.OgrID = '" + id + "'";

                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwNotGorEkran.DataSource = dt;

                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       private void comboYil()
        {
            try
            {
                String query = "SELECT DISTINCT TDERS.DersYil FROM TDERS";
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbYil.ValueMember = "TDERS";
                cbYil.DisplayMember = "DersYil";
                cbYil.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       
        private void comboYariyil()
        {
            try
            {
                String query = "SELECT DISTINCT DersYariyil FROM TDERS";
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbyariyil.ValueMember = "TDERS";
                cbyariyil.DisplayMember = "DersYariyil";
                cbyariyil.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void selectYil()
        {
           
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                cnn.Open();
                string cbyilSelect = cbYil.Text;
                String query = "SELECT TNOT.DersID, TDERS.DersAd, TNOT.Vize, TNOT.Final, TNOT.Butunleme FROM TNOT INNER JOIN TDERS ON TNOT.DersID = TDERS.DersID WHERE TDERS.DersYil = '" + cbYil.Text + "'  AND TNOT.OgrID = '" + id + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                
                da.Fill(dt);
                dgwNotGorEkran.DataSource = dt;

                cnn.Close();
       
            }
            catch 
            {
                MessageBox.Show("Böyle bir değer bulunamadı!");
            }
        
        }

        private void cbYil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Close();
            try
            {
                DataTable dt = new DataTable();
                cnn.Open();
                string cbyilSelect = cbYil.Text;
                String query = "SELECT TNOT.DersID, TDERS.DersAd, TNOT.Vize, TNOT.Final, TNOT.Butunleme FROM TNOT INNER JOIN TDERS ON TNOT.DersID = TDERS.DersID WHERE TDERS.DersYil = '" + cbyilSelect + "'  AND TNOT.OgrID = '" + id + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

                sda.Fill(dt);
                dgwNotGorEkran.DataSource = dt;

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Böyle bir değer bulunamadı!" + ex);
            }
        }

        private void cbyariyil_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                cnn.Close();
                DataTable dt = new DataTable();
                cnn.Open();
                string cbyariyilSelect = cbyariyil.Text;
                String query = "SELECT TNOT.DersID, TDERS.DersAd, TNOT.Vize, TNOT.Final, TNOT.Butunleme FROM TNOT INNER JOIN TDERS ON TNOT.DersID = TDERS.DersID WHERE TDERS.DersYariyil = "+cbyariyilSelect+" AND TNOT.OgrID = '" + id + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);

                sda.Fill(dt);
                dgwNotGorEkran.DataSource = dt;

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Böyle bir değer bulunamadı!" + ex);
            }
        }
    }
}
