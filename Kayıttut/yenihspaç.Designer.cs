namespace Kayıttut
{
    partial class yenihspaç
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
            this.adialtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.hspadilbl = new System.Windows.Forms.Label();
            this.hesapaçpnl = new System.Windows.Forms.Panel();
            this.müsnoal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hspekl = new Guna.UI2.WinForms.Guna2TileButton();
            this.müştnoal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.hesapaçpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // adialtxt
            // 
            this.adialtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adialtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adialtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adialtxt.HintForeColor = System.Drawing.Color.Empty;
            this.adialtxt.HintText = "";
            this.adialtxt.isPassword = false;
            this.adialtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.adialtxt.LineIdleColor = System.Drawing.Color.Gray;
            this.adialtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adialtxt.LineThickness = 3;
            this.adialtxt.Location = new System.Drawing.Point(13, 76);
            this.adialtxt.Margin = new System.Windows.Forms.Padding(4);
            this.adialtxt.Name = "adialtxt";
            this.adialtxt.Size = new System.Drawing.Size(232, 44);
            this.adialtxt.TabIndex = 17;
            this.adialtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // hspadilbl
            // 
            this.hspadilbl.AutoSize = true;
            this.hspadilbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hspadilbl.Location = new System.Drawing.Point(20, 26);
            this.hspadilbl.Name = "hspadilbl";
            this.hspadilbl.Size = new System.Drawing.Size(212, 21);
            this.hspadilbl.TabIndex = 14;
            this.hspadilbl.Text = "Lütfen açmak istediğiniz ";
            // 
            // hesapaçpnl
            // 
            this.hesapaçpnl.Controls.Add(this.müsnoal);
            this.hesapaçpnl.Controls.Add(this.label2);
            this.hesapaçpnl.Controls.Add(this.hspekl);
            this.hesapaçpnl.Controls.Add(this.hspadilbl);
            this.hesapaçpnl.Controls.Add(this.müştnoal);
            this.hesapaçpnl.Controls.Add(this.adialtxt);
            this.hesapaçpnl.Location = new System.Drawing.Point(32, 22);
            this.hesapaçpnl.Name = "hesapaçpnl";
            this.hesapaçpnl.Size = new System.Drawing.Size(273, 403);
            this.hesapaçpnl.TabIndex = 18;
            // 
            // müsnoal
            // 
            this.müsnoal.AutoSize = true;
            this.müsnoal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müsnoal.Location = new System.Drawing.Point(3, 147);
            this.müsnoal.Name = "müsnoal";
            this.müsnoal.Size = new System.Drawing.Size(268, 21);
            this.müsnoal.TabIndex = 22;
            this.müsnoal.Text = "Lütfen müşteri numaranızı giriniz ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "hesabın adını giriniz";
            // 
            // hspekl
            // 
            this.hspekl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hspekl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hspekl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hspekl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hspekl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hspekl.ForeColor = System.Drawing.Color.White;
            this.hspekl.Location = new System.Drawing.Point(35, 326);
            this.hspekl.Name = "hspekl";
            this.hspekl.Size = new System.Drawing.Size(180, 60);
            this.hspekl.TabIndex = 18;
            this.hspekl.Text = "Hesap Aç";
            this.hspekl.Click += new System.EventHandler(this.hspekl_Click);
            // 
            // müştnoal
            // 
            this.müştnoal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.müştnoal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.müştnoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.müştnoal.HintForeColor = System.Drawing.Color.Empty;
            this.müştnoal.HintText = "";
            this.müştnoal.isPassword = false;
            this.müştnoal.LineFocusedColor = System.Drawing.Color.Blue;
            this.müştnoal.LineIdleColor = System.Drawing.Color.Gray;
            this.müştnoal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.müştnoal.LineThickness = 3;
            this.müştnoal.Location = new System.Drawing.Point(13, 202);
            this.müştnoal.Margin = new System.Windows.Forms.Padding(4);
            this.müştnoal.Name = "müştnoal";
            this.müştnoal.Size = new System.Drawing.Size(232, 44);
            this.müştnoal.TabIndex = 17;
            this.müştnoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // yenihspaç
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 460);
            this.Controls.Add(this.hesapaçpnl);
            this.Name = "yenihspaç";
            this.Text = "yenihspaç";
            this.Load += new System.EventHandler(this.yenihspaç_Load);
            this.hesapaçpnl.ResumeLayout(false);
            this.hesapaçpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox adialtxt;
        private System.Windows.Forms.Label hspadilbl;
        private System.Windows.Forms.Panel hesapaçpnl;
        private Guna.UI2.WinForms.Guna2TileButton hspekl;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox müştnoal;
        private System.Windows.Forms.Label müsnoal;
    }
}