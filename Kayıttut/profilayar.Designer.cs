namespace Kayıttut
{
    partial class profilayar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilayar));
            this.guvenlikcvptxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sifretxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Kaydet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soruu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guvenlikcvptxt
            // 
            this.guvenlikcvptxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guvenlikcvptxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.guvenlikcvptxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guvenlikcvptxt.HintForeColor = System.Drawing.Color.Empty;
            this.guvenlikcvptxt.HintText = "";
            this.guvenlikcvptxt.isPassword = false;
            this.guvenlikcvptxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.guvenlikcvptxt.LineIdleColor = System.Drawing.Color.Gray;
            this.guvenlikcvptxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.guvenlikcvptxt.LineThickness = 3;
            this.guvenlikcvptxt.Location = new System.Drawing.Point(13, 191);
            this.guvenlikcvptxt.Margin = new System.Windows.Forms.Padding(4);
            this.guvenlikcvptxt.Name = "guvenlikcvptxt";
            this.guvenlikcvptxt.Size = new System.Drawing.Size(129, 44);
            this.guvenlikcvptxt.TabIndex = 1;
            this.guvenlikcvptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sifretxt
            // 
            this.sifretxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifretxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sifretxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sifretxt.HintForeColor = System.Drawing.Color.Empty;
            this.sifretxt.HintText = "";
            this.sifretxt.isPassword = false;
            this.sifretxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.sifretxt.LineIdleColor = System.Drawing.Color.Gray;
            this.sifretxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sifretxt.LineThickness = 3;
            this.sifretxt.Location = new System.Drawing.Point(13, 303);
            this.sifretxt.Margin = new System.Windows.Forms.Padding(4);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(199, 44);
            this.sifretxt.TabIndex = 2;
            this.sifretxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Kaydet
            // 
            this.Kaydet.ActiveBorderThickness = 1;
            this.Kaydet.ActiveCornerRadius = 20;
            this.Kaydet.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Kaydet.ActiveForecolor = System.Drawing.Color.White;
            this.Kaydet.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Kaydet.BackColor = System.Drawing.Color.White;
            this.Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kaydet.BackgroundImage")));
            this.Kaydet.ButtonText = "Kaydet";
            this.Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kaydet.ForeColor = System.Drawing.Color.SeaGreen;
            this.Kaydet.IdleBorderThickness = 1;
            this.Kaydet.IdleCornerRadius = 20;
            this.Kaydet.IdleFillColor = System.Drawing.Color.White;
            this.Kaydet.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Kaydet.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Kaydet.Location = new System.Drawing.Point(112, 377);
            this.Kaydet.Margin = new System.Windows.Forms.Padding(5);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(181, 41);
            this.Kaydet.TabIndex = 4;
            this.Kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lütfen Güvenlik Sorunuzun Cevabını Belirleyiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lütfen Yeni Şifrenizi Belirleyiniz";
            // 
            // soruu
            // 
            this.soruu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soruu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.soruu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.soruu.HintForeColor = System.Drawing.Color.Empty;
            this.soruu.HintText = "";
            this.soruu.isPassword = false;
            this.soruu.LineFocusedColor = System.Drawing.Color.Blue;
            this.soruu.LineIdleColor = System.Drawing.Color.Gray;
            this.soruu.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.soruu.LineThickness = 3;
            this.soruu.Location = new System.Drawing.Point(17, 97);
            this.soruu.Margin = new System.Windows.Forms.Padding(4);
            this.soruu.Name = "soruu";
            this.soruu.Size = new System.Drawing.Size(330, 44);
            this.soruu.TabIndex = 1;
            this.soruu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lütfen Güvenlik Sorunuzu  Belirleyiniz";
            // 
            // profilayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.soruu);
            this.Controls.Add(this.guvenlikcvptxt);
            this.Name = "profilayar";
            this.Text = "profilayar";
            this.Load += new System.EventHandler(this.profilayar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox guvenlikcvptxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sifretxt;
        private Bunifu.Framework.UI.BunifuThinButton2 Kaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soruu;
        private System.Windows.Forms.Label label3;
    }
}