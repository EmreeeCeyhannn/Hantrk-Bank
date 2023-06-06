using Kayıttut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kayıttut
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private static string sqliddeğeri;
        private int sqliddeğerint;
        public void sqliddeğerim(string value)
        {
            // sqliddeğeri değerini ve sqliddeğerint değişkenini tanımladım
            sqliddeğeri = value;
            sqliddeğerint = Convert.ToInt32(sqliddeğeri);
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {           
            string ad = null; // ad değerini saklamak için bir değişken          
            string soyad = null; // soyad değerini saklamak için bir değişken
                                // SQL bağlantısını oluşturuyorum
            SqlConnection connection = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");
            connection.Open();
            string sqlQuery = @"select Ad,Soyad from Giris where Giris.Id = '" + sqliddeğeri + "'"; // verileri çekiyoruz
            SqlCommand command = new SqlCommand(sqlQuery, connection);            
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                ad = reader.GetString(0); // ad ve soyad değerini okuyup değişkene atadım
                soyad = reader.GetString(1);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            BilgiAd.Text = "     " + ad +" "+soyad;
            MessageBox.Show("Hoşgeldiniz Sn. " + ad+" "+soyad);
        }

        private void küçüksekaç(Form küçük, object sender)
        {
            activeForm = küçük;
            küçük.TopLevel = false;
            küçük.FormBorderStyle = FormBorderStyle.None;
            küçük.Dock = DockStyle.Fill;
            this.küçükpan.Controls.Add(küçük);
            this.küçükpan.Tag = küçük;
            küçük.BringToFront();
            küçük.Show();
        }
        //aşağıdaki butonlar basıldığında ilgili sekme açılır
        private void Hesapbil_Click(object sender, EventArgs e)
        {
            küçüksekaç(new HspBilgGör(), sender);
        }

        private void Kartlarım_Click(object sender, EventArgs e)
        {
            küçüksekaç(new HspBilgGör(), sender);
        }

        private void Yatırımİşlemleri_Click(object sender, EventArgs e)
        {
            küçüksekaç(new HspBilgGör(), sender);
        }


        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hspaçbtn_Click(object sender, EventArgs e)
        {
            küçüksekaç(new yenihspaç(), sender);
        }

        private void Profilayar_Click(object sender, EventArgs e)
        {
            küçüksekaç(new profilayar(), sender);
        }
        

        private void prtrnsfrbtn_Click(object sender, EventArgs e)
        {
            küçüksekaç(new Transfer(), sender);
        }

        private void paraçekytr_Click(object sender, EventArgs e)
        {
            küçüksekaç(new ParaYatırÇek(), sender);
        }
    }
}
