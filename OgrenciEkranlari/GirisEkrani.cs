using odev;
using odevsena;
using System.Data;
using System.Data.SqlClient;

namespace odevOgrenciOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection("Data Source=LAPTOP-DVLSNGTV;Initial Catalog=OgrenciOtomasyonu;Integrated Security=True");
        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            txtParola.PasswordChar = '*';
            cboxSifreGoster.Checked = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            String kulAdi = txtKulAdi.Text;
            String parola = txtParola.Text;
            if (kulAdi != "" && parola != "") { 
                cnn.Open();
                
                DataTable dtbl = new DataTable();
                String query_o = "SELECT * FROM TOGRENCI WHERE OgrID = '" + kulAdi + "' AND OgrSifre = '" + parola+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(query_o, cnn);
                sda.Fill(dtbl);

                DataTable dtbl_h = new DataTable();
                String query_h = "SELECT * FROM THOCA WHERE HocaID = '" + kulAdi + "' AND HocaSifre = '" + parola + "'";
                SqlDataAdapter sda_h = new SqlDataAdapter(query_h, cnn);
                sda_h.Fill(dtbl_h);

                DataTable dtbl_m = new DataTable();
                String query_m = "SELECT * FROM TMEMUR WHERE MemurID = '" + kulAdi + "' AND MemurSifre = '" + parola + "'";
                SqlDataAdapter sda_m = new SqlDataAdapter(query_m, cnn);
                sda_m.Fill(dtbl_m);
                cnn.Close();
                if (dtbl.Rows.Count == 1)
                {
                    OgrenciEkrani oe = new OgrenciEkrani(kulAdi);
                    oe.Show();
                    this.Hide();
                }
                else if(dtbl_h.Rows.Count == 1)
                {
                    HocaEkrani he = new HocaEkrani(kulAdi);
                    he.Show();
                    this.Hide();
                }
                else if (dtbl_m.Rows.Count == 1)
                {
                    MemurEkrani me = new MemurEkrani(kulAdi);
                    me.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış veya eksik!", "Kullanıcı Bilgileri Yanlış", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre kutularını boş bırkamazsınız", "Giriş Kutuları Boş", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cboxSifreGoster_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cboxSifreGoster.Checked)
            {
                txtParola.PasswordChar = '\0';
                cboxSifreGoster.Checked = true;
            }
            else
            {
                txtParola.PasswordChar = '*';
                cboxSifreGoster.Checked = false;
            }
        }
    }
}