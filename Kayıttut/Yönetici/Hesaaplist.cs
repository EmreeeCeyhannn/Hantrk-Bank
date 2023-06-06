using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Kayıttut.Yönetici
{
    public partial class Hesaaplist : Form
    {
        public Hesaaplist()
        {
            InitializeComponent();
        }
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        private void Hesaaplist_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            // Giriş tablosundaki verileri okumak için SQL sorgusu
            string query = "SELECT * FROM Giris";

            adapter = new SqlDataAdapter(query, connection);
            table = new DataTable();
            adapter.Fill(table);

            // Verileri DataGridView'e aktarma
            guna2DataGridView1.DataSource = table;

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
