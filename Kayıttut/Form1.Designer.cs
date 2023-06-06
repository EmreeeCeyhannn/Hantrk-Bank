namespace Kayıttut
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Baslık = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hspaçbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BilgiAd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Profilayar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.prtrnsfrbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.paraçekytr = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Hesapbil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.küçükpan = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Baslık);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(963, 107);
            this.panel2.TabIndex = 3;
            //this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(932, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Baslık
            // 
            this.Baslık.AutoSize = true;
            this.Baslık.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslık.ForeColor = System.Drawing.Color.White;
            this.Baslık.Location = new System.Drawing.Point(375, 21);
            this.Baslık.Name = "Baslık";
            this.Baslık.Size = new System.Drawing.Size(213, 34);
            this.Baslık.TabIndex = 0;
            this.Baslık.Text = "HanTürk Banka";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.hspaçbtn);
            this.panel3.Controls.Add(this.BilgiAd);
            this.panel3.Controls.Add(this.Profilayar);
            this.panel3.Controls.Add(this.prtrnsfrbtn);
            this.panel3.Controls.Add(this.paraçekytr);
            this.panel3.Controls.Add(this.Hesapbil);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 488);
            this.panel3.TabIndex = 4;
            // 
            // hspaçbtn
            // 
            this.hspaçbtn.ActiveBorderThickness = 1;
            this.hspaçbtn.ActiveCornerRadius = 20;
            this.hspaçbtn.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.hspaçbtn.ActiveForecolor = System.Drawing.Color.White;
            this.hspaçbtn.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.hspaçbtn.BackColor = System.Drawing.Color.Teal;
            this.hspaçbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hspaçbtn.BackgroundImage")));
            this.hspaçbtn.ButtonText = "Yeni Hesap Aç";
            this.hspaçbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hspaçbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hspaçbtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.hspaçbtn.IdleBorderThickness = 1;
            this.hspaçbtn.IdleCornerRadius = 20;
            this.hspaçbtn.IdleFillColor = System.Drawing.Color.White;
            this.hspaçbtn.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.hspaçbtn.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.hspaçbtn.Location = new System.Drawing.Point(0, 53);
            this.hspaçbtn.Margin = new System.Windows.Forms.Padding(5);
            this.hspaçbtn.Name = "hspaçbtn";
            this.hspaçbtn.Size = new System.Drawing.Size(214, 65);
            this.hspaçbtn.TabIndex = 5;
            this.hspaçbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hspaçbtn.Click += new System.EventHandler(this.hspaçbtn_Click);
            // 
            // BilgiAd
            // 
            this.BilgiAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BilgiAd.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BilgiAd.HintForeColor = System.Drawing.Color.Empty;
            this.BilgiAd.HintText = "";
            this.BilgiAd.isPassword = false;
            this.BilgiAd.LineFocusedColor = System.Drawing.Color.Lime;
            this.BilgiAd.LineIdleColor = System.Drawing.Color.Lime;
            this.BilgiAd.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.BilgiAd.LineThickness = 3;
            this.BilgiAd.Location = new System.Drawing.Point(0, -12);
            this.BilgiAd.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.BilgiAd.Name = "BilgiAd";
            this.BilgiAd.Size = new System.Drawing.Size(214, 55);
            this.BilgiAd.TabIndex = 4;
            this.BilgiAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Profilayar
            // 
            this.Profilayar.ActiveBorderThickness = 1;
            this.Profilayar.ActiveCornerRadius = 20;
            this.Profilayar.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.Profilayar.ActiveForecolor = System.Drawing.Color.White;
            this.Profilayar.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.Profilayar.BackColor = System.Drawing.Color.Teal;
            this.Profilayar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Profilayar.BackgroundImage")));
            this.Profilayar.ButtonText = "Profil Ayarları";
            this.Profilayar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profilayar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profilayar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Profilayar.IdleBorderThickness = 1;
            this.Profilayar.IdleCornerRadius = 20;
            this.Profilayar.IdleFillColor = System.Drawing.Color.White;
            this.Profilayar.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.Profilayar.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.Profilayar.Location = new System.Drawing.Point(-2, 353);
            this.Profilayar.Margin = new System.Windows.Forms.Padding(5);
            this.Profilayar.Name = "Profilayar";
            this.Profilayar.Size = new System.Drawing.Size(216, 65);
            this.Profilayar.TabIndex = 3;
            this.Profilayar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Profilayar.Click += new System.EventHandler(this.Profilayar_Click);
            // 
            // prtrnsfrbtn
            // 
            this.prtrnsfrbtn.ActiveBorderThickness = 1;
            this.prtrnsfrbtn.ActiveCornerRadius = 20;
            this.prtrnsfrbtn.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.prtrnsfrbtn.ActiveForecolor = System.Drawing.Color.White;
            this.prtrnsfrbtn.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.prtrnsfrbtn.BackColor = System.Drawing.Color.Teal;
            this.prtrnsfrbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prtrnsfrbtn.BackgroundImage")));
            this.prtrnsfrbtn.ButtonText = "Para Transferi";
            this.prtrnsfrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prtrnsfrbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prtrnsfrbtn.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.prtrnsfrbtn.IdleBorderThickness = 1;
            this.prtrnsfrbtn.IdleCornerRadius = 20;
            this.prtrnsfrbtn.IdleFillColor = System.Drawing.Color.White;
            this.prtrnsfrbtn.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.prtrnsfrbtn.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.prtrnsfrbtn.Location = new System.Drawing.Point(0, 278);
            this.prtrnsfrbtn.Margin = new System.Windows.Forms.Padding(5);
            this.prtrnsfrbtn.Name = "prtrnsfrbtn";
            this.prtrnsfrbtn.Size = new System.Drawing.Size(214, 65);
            this.prtrnsfrbtn.TabIndex = 2;
            this.prtrnsfrbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prtrnsfrbtn.Click += new System.EventHandler(this.prtrnsfrbtn_Click);
            // 
            // paraçekytr
            // 
            this.paraçekytr.ActiveBorderThickness = 1;
            this.paraçekytr.ActiveCornerRadius = 20;
            this.paraçekytr.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.paraçekytr.ActiveForecolor = System.Drawing.Color.White;
            this.paraçekytr.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.paraçekytr.BackColor = System.Drawing.Color.Teal;
            this.paraçekytr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paraçekytr.BackgroundImage")));
            this.paraçekytr.ButtonText = "ParaÇek/Yatır";
            this.paraçekytr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paraçekytr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraçekytr.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.paraçekytr.IdleBorderThickness = 1;
            this.paraçekytr.IdleCornerRadius = 20;
            this.paraçekytr.IdleFillColor = System.Drawing.Color.White;
            this.paraçekytr.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.paraçekytr.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.paraçekytr.Location = new System.Drawing.Point(-2, 203);
            this.paraçekytr.Margin = new System.Windows.Forms.Padding(5);
            this.paraçekytr.Name = "paraçekytr";
            this.paraçekytr.Size = new System.Drawing.Size(214, 65);
            this.paraçekytr.TabIndex = 1;
            this.paraçekytr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paraçekytr.Click += new System.EventHandler(this.paraçekytr_Click);
            // 
            // Hesapbil
            // 
            this.Hesapbil.ActiveBorderThickness = 1;
            this.Hesapbil.ActiveCornerRadius = 20;
            this.Hesapbil.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.Hesapbil.ActiveForecolor = System.Drawing.Color.White;
            this.Hesapbil.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.Hesapbil.BackColor = System.Drawing.Color.Teal;
            this.Hesapbil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hesapbil.BackgroundImage")));
            this.Hesapbil.ButtonText = "Hesap Bilgilerini Gör";
            this.Hesapbil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hesapbil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hesapbil.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Hesapbil.IdleBorderThickness = 1;
            this.Hesapbil.IdleCornerRadius = 20;
            this.Hesapbil.IdleFillColor = System.Drawing.Color.White;
            this.Hesapbil.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.Hesapbil.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.Hesapbil.Location = new System.Drawing.Point(0, 128);
            this.Hesapbil.Margin = new System.Windows.Forms.Padding(5);
            this.Hesapbil.Name = "Hesapbil";
            this.Hesapbil.Size = new System.Drawing.Size(214, 65);
            this.Hesapbil.TabIndex = 0;
            this.Hesapbil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hesapbil.Click += new System.EventHandler(this.Hesapbil_Click);
            // 
            // küçükpan
            // 
            this.küçükpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(190)))), ((int)(((byte)(194)))));
            this.küçükpan.ForeColor = System.Drawing.Color.Black;
            this.küçükpan.Location = new System.Drawing.Point(214, 107);
            this.küçükpan.Name = "küçükpan";
            this.küçükpan.Size = new System.Drawing.Size(749, 486);
            this.küçükpan.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 595);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.küçükpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Baslık;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 Hesapbil;
        private Bunifu.Framework.UI.BunifuThinButton2 Profilayar;
        private Bunifu.Framework.UI.BunifuThinButton2 prtrnsfrbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 paraçekytr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BilgiAd;
        private Bunifu.Framework.UI.BunifuThinButton2 hspaçbtn;
        private System.Windows.Forms.Panel küçükpan;
    }
}

