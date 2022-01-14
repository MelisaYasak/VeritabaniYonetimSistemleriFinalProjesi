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

namespace odevsena
{

        public partial class MemurEkrani : Form
        {
            string id = "1";
            SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");

            public MemurEkrani(string id)
            {
                InitializeComponent();
                this.id = id;
            }

            private void button1_Click(object sender, EventArgs e)
            {
                OgrenciKayitEkrani frm = new OgrenciKayitEkrani(id);
                //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
                frm.Show();
                this.Hide();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                HocaKayitEkrani frm = new HocaKayitEkrani(id);
                //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
                frm.Show();
                this.Hide();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                DanismanAtamaEkrani frm = new DanismanAtamaEkrani(id);
                //Show metodu ile nesne olarak türettiğim ikinci formumu açıyorum.
                frm.Show();
                this.Hide();
            }

            private void MemurEkrani_Load(object sender, EventArgs e)
            {
                cnn.Open();
                String query2 = "SELECT MemurAd FROM TMEMUR WHERE MemurID = '" + id + "'";
                SqlCommand sc_q2 = new SqlCommand(query2, cnn);
                String s_q2 = (string)sc_q2.ExecuteScalar();
                cnn.Close();
                label.Text = "Merhaba " + s_q2;
            }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.Show();
            this.Hide();
        }

    }
    }



