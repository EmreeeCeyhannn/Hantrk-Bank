namespace Kayıttut
{
    partial class ParaYatırÇek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaYatırÇek));
            this.parayatır = new Bunifu.Framework.UI.BunifuThinButton2();
            this.paraçek = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bakiyetxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bakiyelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tutartxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.hesapseçcb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // parayatır
            // 
            this.parayatır.ActiveBorderThickness = 1;
            this.parayatır.ActiveCornerRadius = 20;
            this.parayatır.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.parayatır.ActiveForecolor = System.Drawing.Color.White;
            this.parayatır.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.parayatır.BackColor = System.Drawing.Color.White;
            this.parayatır.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("parayatır.BackgroundImage")));
            this.parayatır.ButtonText = "Para Yatır";
            this.parayatır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parayatır.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parayatır.ForeColor = System.Drawing.Color.SeaGreen;
            this.parayatır.IdleBorderThickness = 1;
            this.parayatır.IdleCornerRadius = 20;
            this.parayatır.IdleFillColor = System.Drawing.Color.White;
            this.parayatır.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.parayatır.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.parayatır.Location = new System.Drawing.Point(247, 319);
            this.parayatır.Margin = new System.Windows.Forms.Padding(5);
            this.parayatır.Name = "parayatır";
            this.parayatır.Size = new System.Drawing.Size(181, 41);
            this.parayatır.TabIndex = 1;
            this.parayatır.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parayatır.Click += new System.EventHandler(this.parayatır_Click);
            // 
            // paraçek
            // 
            this.paraçek.ActiveBorderThickness = 1;
            this.paraçek.ActiveCornerRadius = 20;
            this.paraçek.ActiveFillColor = System.Drawing.Color.Red;
            this.paraçek.ActiveForecolor = System.Drawing.Color.White;
            this.paraçek.ActiveLineColor = System.Drawing.Color.Red;
            this.paraçek.BackColor = System.Drawing.Color.White;
            this.paraçek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paraçek.BackgroundImage")));
            this.paraçek.ButtonText = "Para Çek";
            this.paraçek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paraçek.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paraçek.ForeColor = System.Drawing.Color.Red;
            this.paraçek.IdleBorderThickness = 1;
            this.paraçek.IdleCornerRadius = 20;
            this.paraçek.IdleFillColor = System.Drawing.Color.White;
            this.paraçek.IdleForecolor = System.Drawing.Color.Red;
            this.paraçek.IdleLineColor = System.Drawing.Color.Red;
            this.paraçek.Location = new System.Drawing.Point(56, 319);
            this.paraçek.Margin = new System.Windows.Forms.Padding(5);
            this.paraçek.Name = "paraçek";
            this.paraçek.Size = new System.Drawing.Size(181, 41);
            this.paraçek.TabIndex = 1;
            this.paraçek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paraçek.Click += new System.EventHandler(this.paraçek_Click);
            // 
            // bakiyetxt
            // 
            this.bakiyetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bakiyetxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bakiyetxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bakiyetxt.HintForeColor = System.Drawing.Color.Empty;
            this.bakiyetxt.HintText = "";
            this.bakiyetxt.isPassword = false;
            this.bakiyetxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.bakiyetxt.LineIdleColor = System.Drawing.Color.Gray;
            this.bakiyetxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bakiyetxt.LineThickness = 3;
            this.bakiyetxt.Location = new System.Drawing.Point(185, 154);
            this.bakiyetxt.Margin = new System.Windows.Forms.Padding(4);
            this.bakiyetxt.Name = "bakiyetxt";
            this.bakiyetxt.Size = new System.Drawing.Size(142, 44);
            this.bakiyetxt.TabIndex = 3;
            this.bakiyetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bakiyelbl
            // 
            this.bakiyelbl.BackColor = System.Drawing.Color.Transparent;
            this.bakiyelbl.Location = new System.Drawing.Point(12, 180);
            this.bakiyelbl.Name = "bakiyelbl";
            this.bakiyelbl.Size = new System.Drawing.Size(109, 18);
            this.bakiyelbl.TabIndex = 4;
            this.bakiyelbl.Text = "Hesabın Bakiyesi";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(87, 240);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(34, 18);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Tutar";
            // 
            // tutartxt
            // 
            this.tutartxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tutartxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tutartxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tutartxt.HintForeColor = System.Drawing.Color.Empty;
            this.tutartxt.HintText = "";
            this.tutartxt.isPassword = false;
            this.tutartxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.tutartxt.LineIdleColor = System.Drawing.Color.Gray;
            this.tutartxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tutartxt.LineThickness = 3;
            this.tutartxt.Location = new System.Drawing.Point(185, 214);
            this.tutartxt.Margin = new System.Windows.Forms.Padding(4);
            this.tutartxt.Name = "tutartxt";
            this.tutartxt.Size = new System.Drawing.Size(142, 44);
            this.tutartxt.TabIndex = 3;
            this.tutartxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // hesapseçcb
            // 
            this.hesapseçcb.BackColor = System.Drawing.Color.Transparent;
            this.hesapseçcb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hesapseçcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hesapseçcb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hesapseçcb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hesapseçcb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hesapseçcb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.hesapseçcb.ItemHeight = 30;
            this.hesapseçcb.Location = new System.Drawing.Point(187, 31);
            this.hesapseçcb.Name = "hesapseçcb";
            this.hesapseçcb.Size = new System.Drawing.Size(140, 36);
            this.hesapseçcb.TabIndex = 2;
            this.hesapseçcb.SelectedIndexChanged += new System.EventHandler(this.hesapseçcb_SelectedIndexChanged);
            // 
            // ParaYatırÇek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.bakiyelbl);
            this.Controls.Add(this.tutartxt);
            this.Controls.Add(this.bakiyetxt);
            this.Controls.Add(this.hesapseçcb);
            this.Controls.Add(this.paraçek);
            this.Controls.Add(this.parayatır);
            this.Name = "ParaYatırÇek";
            this.Text = "ParaYatırÇek";
            this.Load += new System.EventHandler(this.ParaYatırÇek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 parayatır;
        private Bunifu.Framework.UI.BunifuThinButton2 paraçek;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bakiyetxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel bakiyelbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tutartxt;
        private Guna.UI2.WinForms.Guna2ComboBox hesapseçcb;
    }
}