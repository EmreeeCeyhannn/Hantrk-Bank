using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kayıttut
{
    public partial class Yöneticii : Form
    {
        private Form activeForm;
        public Yöneticii()
        {
            InitializeComponent();
        }
        public string MyLabelText//Giriş Yapıldığında kullanıcı adının belli olması için kullanılmıştır
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        //Yandaki butonlara bastığımız zaman panellerin içinı doldurmak için paremetreli metod
        private void küçüksekaç(Form küçük, object sender)
        {
            activeForm = küçük;
            küçük.TopLevel = false;
            küçük.FormBorderStyle = FormBorderStyle.None;
            küçük.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(küçük);
            this.panel1.Tag = küçük;
            küçük.BringToFront();
            küçük.Show();
        }
        private void Yönetici_Load(object sender, EventArgs e)
        {
             
        }
        private void Yonetici_Shown(object sender, EventArgs e)
        {    //Label'daki yazıya göre resim değiştirecek
            if (label1.Text == "Kutlu Türkücü")
            {
                pictureBox1.SendToBack();
            }
            else if (label1.Text == "Emre Ceyhan")
            {
                pictureBox2.SendToBack();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //paneli doldurma işlemleri
            küçüksekaç(new üye_ol(), sender);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            //paneli doldurma işlemleri
            küçüksekaç(new Yönetici.Hesaaplist(), sender);

        }



        private void button5_Click(object sender, EventArgs e)
        {
            //paneli doldurma işlemleri
            küçüksekaç(new Yönetici.İslemGeçmiş(), sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //paneli doldurma işlemleri
            küçüksekaç(new Yönetici.ayarlar(), sender);
        }
    }
}
