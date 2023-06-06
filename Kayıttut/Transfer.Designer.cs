namespace Kayıttut
{
    partial class Transfer
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
            this.hesapadCbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.hspisimlbl = new System.Windows.Forms.Label();
            this.alicibnaltxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.alıcıbn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gndrbtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.GonderilenPara = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bakiyetxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // hesapadCbox
            // 
            this.hesapadCbox.BackColor = System.Drawing.Color.Transparent;
            this.hesapadCbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hesapadCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hesapadCbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hesapadCbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hesapadCbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hesapadCbox.ForeColor = System.Drawing.Color.Black;
            this.hesapadCbox.ItemHeight = 30;
            this.hesapadCbox.Location = new System.Drawing.Point(107, 68);
            this.hesapadCbox.Name = "hesapadCbox";
            this.hesapadCbox.Size = new System.Drawing.Size(140, 36);
            this.hesapadCbox.TabIndex = 0;
            this.hesapadCbox.SelectedIndexChanged += new System.EventHandler(this.hesapadCbox_SelectedIndexChanged);
            // 
            // hspisimlbl
            // 
            this.hspisimlbl.AutoSize = true;
            this.hspisimlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hspisimlbl.ForeColor = System.Drawing.Color.Black;
            this.hspisimlbl.Location = new System.Drawing.Point(103, 24);
            this.hspisimlbl.Name = "hspisimlbl";
            this.hspisimlbl.Size = new System.Drawing.Size(380, 22);
            this.hspisimlbl.TabIndex = 9;
            this.hspisimlbl.Text = "Lütfen para göndermek istediğiniz hesabı seçin";
            // 
            // alicibnaltxt
            // 
            this.alicibnaltxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alicibnaltxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.alicibnaltxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alicibnaltxt.HintForeColor = System.Drawing.Color.Empty;
            this.alicibnaltxt.HintText = "";
            this.alicibnaltxt.isPassword = false;
            this.alicibnaltxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.alicibnaltxt.LineIdleColor = System.Drawing.Color.Gray;
            this.alicibnaltxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.alicibnaltxt.LineThickness = 3;
            this.alicibnaltxt.Location = new System.Drawing.Point(107, 255);
            this.alicibnaltxt.Margin = new System.Windows.Forms.Padding(4);
            this.alicibnaltxt.Name = "alicibnaltxt";
            this.alicibnaltxt.Size = new System.Drawing.Size(370, 44);
            this.alicibnaltxt.TabIndex = 1;
            this.alicibnaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.alicibnaltxt.OnValueChanged += new System.EventHandler(this.alicibnaltxt_OnValueChanged);
            // 
            // alıcıbn
            // 
            this.alıcıbn.AutoSize = true;
            this.alıcıbn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alıcıbn.ForeColor = System.Drawing.Color.Black;
            this.alıcıbn.Location = new System.Drawing.Point(103, 229);
            this.alıcıbn.Name = "alıcıbn";
            this.alıcıbn.Size = new System.Drawing.Size(274, 22);
            this.alıcıbn.TabIndex = 9;
            this.alıcıbn.Text = "Alıcının IBAN numarasını giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(65, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "TR";
            // 
            // gndrbtn
            // 
            this.gndrbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gndrbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gndrbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gndrbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gndrbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gndrbtn.ForeColor = System.Drawing.Color.White;
            this.gndrbtn.Location = new System.Drawing.Point(176, 443);
            this.gndrbtn.Name = "gndrbtn";
            this.gndrbtn.Size = new System.Drawing.Size(180, 47);
            this.gndrbtn.TabIndex = 11;
            this.gndrbtn.Text = "Gönder";
            this.gndrbtn.Click += new System.EventHandler(this.gndrbtn_Click);
            // 
            // GonderilenPara
            // 
            this.GonderilenPara.BorderColorFocused = System.Drawing.Color.Blue;
            this.GonderilenPara.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GonderilenPara.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.GonderilenPara.BorderThickness = 3;
            this.GonderilenPara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GonderilenPara.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GonderilenPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GonderilenPara.isPassword = false;
            this.GonderilenPara.Location = new System.Drawing.Point(295, 356);
            this.GonderilenPara.Margin = new System.Windows.Forms.Padding(4);
            this.GonderilenPara.Name = "GonderilenPara";
            this.GonderilenPara.Size = new System.Drawing.Size(182, 44);
            this.GonderilenPara.TabIndex = 12;
            this.GonderilenPara.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(113, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hesap Bakiyesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Göndermek istediğiniz ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "para miktarını giriniz";
            // 
            // bakiyetxt
            // 
            this.bakiyetxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bakiyetxt.DefaultText = "";
            this.bakiyetxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bakiyetxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bakiyetxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bakiyetxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bakiyetxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bakiyetxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiyetxt.ForeColor = System.Drawing.Color.Black;
            this.bakiyetxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bakiyetxt.Location = new System.Drawing.Point(107, 159);
            this.bakiyetxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bakiyetxt.Name = "bakiyetxt";
            this.bakiyetxt.PasswordChar = '\0';
            this.bakiyetxt.PlaceholderText = "";
            this.bakiyetxt.SelectedText = "";
            this.bakiyetxt.Size = new System.Drawing.Size(140, 48);
            this.bakiyetxt.TabIndex = 13;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 533);
            this.Controls.Add(this.bakiyetxt);
            this.Controls.Add(this.GonderilenPara);
            this.Controls.Add(this.gndrbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alıcıbn);
            this.Controls.Add(this.alicibnaltxt);
            this.Controls.Add(this.hspisimlbl);
            this.Controls.Add(this.hesapadCbox);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox hesapadCbox;
        private System.Windows.Forms.Label hspisimlbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox alicibnaltxt;
        private System.Windows.Forms.Label alıcıbn;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TileButton gndrbtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox GonderilenPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox bakiyetxt;
    }
}