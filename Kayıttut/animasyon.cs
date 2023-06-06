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
    public partial class animasyon : Form
    {
        public animasyon()
        {
            InitializeComponent();
        }
        //Bu formu kullanmamızın sebebi görsellik açısından uygulamaya renk katmak
        bool islem = false;//islem ilk olarak yanlış başlaycak
        private void animasyon_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (!islem)//islem yanlış ise buraya girecek
            {
                this.Opacity += 0.009;//oplaklık başta 0 bu artacak ve resim görünür olacak
            }
            if (this.Opacity == 1)
            {
                islem = true;
            }
            if (islem)//işlem doğru ise buraya girecek
            {
                this.Opacity -= 0.009;//opaklık 1'den başlayarak 0 olacak
                if (this.Opacity == 0)
                {
                    timer1.Enabled = false;//timer'ı durdurduk
                    Giriş gir = new Giriş();//giriş formundan gir adında nesne ürettik
                    gir.Show();//resim tekrar görünmez olduğu zaman giriş ekranı gelecek
                    
                }
            }
        }
    }
}
