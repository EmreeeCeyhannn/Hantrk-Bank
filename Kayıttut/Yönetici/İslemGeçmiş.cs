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

namespace Kayıttut.Yönetici
{
    public partial class İslemGeçmiş : Form
    {
        public İslemGeçmiş()
        {
            InitializeComponent();
        }
        //Sql'e bağlanmak ve sorgu yapmak için kullanılan değişkenler
        SqlConnection con = null;        
        SqlDataAdapter da = null;
        DataSet ds = null;
        private void button1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(@"Data Source=EMRECEYHAN\SQLEXPRESS01;Initial Catalog=HanTürkDB;Integrated Security=True");//Sql'e bağlandı
            da = new SqlDataAdapter("select Transfer_Alici.alici_isim,Transfer_Gonderen.gönderen_isim,Transfer_Gonderen.gonderilen_tutar,Transfer_Gonderen.tarih from Transfer_Gonderen inner join Transfer_Alici on Transfer_Gonderen.gonderen_transfer_id = Transfer_Alici.alici_transfer_id ", con);//Textbox'ta yazılı olan kullanıcıların bilgileri 
            ds = new DataSet();
            da.Fill(ds, "transfer_işlemleri");
            dataGridView1.DataSource = ds.Tables["transfer_işlemleri"];//datagridview'de gösterir
        }
    }
}
