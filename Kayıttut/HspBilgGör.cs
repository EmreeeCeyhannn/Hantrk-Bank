using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kayıttut
{
    public partial class HspBilgGör : Form
    {
        private static string sqliddeğeri;
        public int sqliddeğerint;

        public void sqliddeğerim(string value)
        {
            sqliddeğeri = value;
        }
        public HspBilgGör()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");
        private void HspBilgGör_Load(object sender, EventArgs e)
        {          
           
        }

        private void glrbtn_Click(object sender, EventArgs e)
        {
            glrpnl.BringToFront();
        }

        private void gdrbtn_Click(object sender, EventArgs e)
        {
            gdrpnl.BringToFront();
        }

        private void gözat_Click(object sender, EventArgs e)
        {
            // "gözat" butonuna tıklandığında çalışacak metot
            sqliddeğerint = Convert.ToInt32(sqliddeğeri);
            int A = sqliddeğerint;
            baglanti.Open();
            // Gelir tablosunu dolduran komut
            SqlCommand komutglrtbldol = new SqlCommand("gelirtbl", baglanti);
            komutglrtbldol.CommandType = CommandType.StoredProcedure;
            komutglrtbldol.Parameters.AddWithValue("@musteriNo", A);
            komutglrtbldol.Parameters.AddWithValue("@iban", hspibntxt.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(komutglrtbldol);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            GelirGridView1.DataSource = dataTable;
            // Gider tablosunu dolduran komut
            SqlCommand komutgdrtbldol = new SqlCommand("gidertbl", baglanti);
            komutgdrtbldol.CommandType = CommandType.StoredProcedure;
            komutgdrtbldol.Parameters.AddWithValue("@musteriNo", A);
            komutgdrtbldol.Parameters.AddWithValue("@iban", hspibntxt.Text);
            SqlDataAdapter adapter1 = new SqlDataAdapter(komutgdrtbldol);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            GiderGridView1.DataSource = dataTable1;
            // İsim ve bakiye bilgisini getiren komut
            SqlCommand isimal = new SqlCommand("SELECT Alici_Hesap_adi, Bakiye FROM GelirGider WHERE Gelirgider.Iban_no_alici = @ibanNo", baglanti);
            isimal.Parameters.AddWithValue("@ibanNo", hspibntxt.Text);            
            SqlDataReader oku = isimal.ExecuteReader();
            if (oku.Read())
            {
                string adial = oku.GetString(0);
                string bakiyeal = oku.GetString(1);
                hspisimgörlbl.Text = adial;
                hesapBkygör.Text = bakiyeal;
            }
            
            baglanti.Close();

        }
    }
}
