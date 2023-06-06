namespace Kayıttut
{
    partial class HspBilgGör
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HspBilgGör));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.glrbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gdrbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gdrpnl = new System.Windows.Forms.Panel();
            this.GiderGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.glrpnl = new System.Windows.Forms.Panel();
            this.GelirGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ibnlbl = new System.Windows.Forms.Label();
            this.hspisimlbl = new System.Windows.Forms.Label();
            this.hspbkylbl = new System.Windows.Forms.Label();
            this.hspibntxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.hanTürkDBDataSet = new Kayıttut.HanTürkDBDataSet();
            this.hanTürkDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gelirGiderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gelirGiderTableAdapter = new Kayıttut.HanTürkDBDataSetTableAdapters.GelirGiderTableAdapter();
            this.gözat = new System.Windows.Forms.Button();
            this.hesapBkygör = new System.Windows.Forms.Label();
            this.hspisimgörlbl = new System.Windows.Forms.Label();
            this.gdrpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiderGridView1)).BeginInit();
            this.glrpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GelirGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanTürkDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanTürkDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // glrbtn
            // 
            this.glrbtn.ActiveBorderThickness = 1;
            this.glrbtn.ActiveCornerRadius = 20;
            this.glrbtn.ActiveFillColor = System.Drawing.Color.LimeGreen;
            this.glrbtn.ActiveForecolor = System.Drawing.Color.White;
            this.glrbtn.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.glrbtn.BackColor = System.Drawing.Color.White;
            this.glrbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("glrbtn.BackgroundImage")));
            this.glrbtn.ButtonText = "Gelir";
            this.glrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glrbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glrbtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.glrbtn.IdleBorderThickness = 1;
            this.glrbtn.IdleCornerRadius = 20;
            this.glrbtn.IdleFillColor = System.Drawing.Color.White;
            this.glrbtn.IdleForecolor = System.Drawing.Color.LimeGreen;
            this.glrbtn.IdleLineColor = System.Drawing.Color.LimeGreen;
            this.glrbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.glrbtn.Location = new System.Drawing.Point(14, 14);
            this.glrbtn.Margin = new System.Windows.Forms.Padding(5);
            this.glrbtn.Name = "glrbtn";
            this.glrbtn.Size = new System.Drawing.Size(181, 41);
            this.glrbtn.TabIndex = 0;
            this.glrbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.glrbtn.Click += new System.EventHandler(this.glrbtn_Click);
            // 
            // gdrbtn
            // 
            this.gdrbtn.ActiveBorderThickness = 1;
            this.gdrbtn.ActiveCornerRadius = 20;
            this.gdrbtn.ActiveFillColor = System.Drawing.Color.Red;
            this.gdrbtn.ActiveForecolor = System.Drawing.Color.White;
            this.gdrbtn.ActiveLineColor = System.Drawing.Color.Red;
            this.gdrbtn.BackColor = System.Drawing.Color.White;
            this.gdrbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gdrbtn.BackgroundImage")));
            this.gdrbtn.ButtonText = "Gider";
            this.gdrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gdrbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdrbtn.ForeColor = System.Drawing.Color.Red;
            this.gdrbtn.IdleBorderThickness = 1;
            this.gdrbtn.IdleCornerRadius = 20;
            this.gdrbtn.IdleFillColor = System.Drawing.Color.White;
            this.gdrbtn.IdleForecolor = System.Drawing.Color.Red;
            this.gdrbtn.IdleLineColor = System.Drawing.Color.Red;
            this.gdrbtn.Location = new System.Drawing.Point(205, 14);
            this.gdrbtn.Margin = new System.Windows.Forms.Padding(5);
            this.gdrbtn.Name = "gdrbtn";
            this.gdrbtn.Size = new System.Drawing.Size(181, 41);
            this.gdrbtn.TabIndex = 1;
            this.gdrbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gdrbtn.Click += new System.EventHandler(this.gdrbtn_Click);
            // 
            // gdrpnl
            // 
            this.gdrpnl.BackColor = System.Drawing.SystemColors.Control;
            this.gdrpnl.Controls.Add(this.GiderGridView1);
            this.gdrpnl.Controls.Add(this.label1);
            this.gdrpnl.Location = new System.Drawing.Point(14, 63);
            this.gdrpnl.Name = "gdrpnl";
            this.gdrpnl.Size = new System.Drawing.Size(686, 227);
            this.gdrpnl.TabIndex = 2;
            // 
            // GiderGridView1
            // 
            this.GiderGridView1.AllowUserToAddRows = false;
            this.GiderGridView1.AllowUserToDeleteRows = false;
            this.GiderGridView1.AllowUserToOrderColumns = true;
            this.GiderGridView1.AllowUserToResizeColumns = false;
            this.GiderGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GiderGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GiderGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GiderGridView1.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GiderGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.GiderGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GiderGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GiderGridView1.Location = new System.Drawing.Point(15, 37);
            this.GiderGridView1.Name = "GiderGridView1";
            this.GiderGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GiderGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GiderGridView1.RowHeadersVisible = false;
            this.GiderGridView1.RowHeadersWidth = 51;
            this.GiderGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GiderGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GiderGridView1.RowTemplate.Height = 24;
            this.GiderGridView1.Size = new System.Drawing.Size(656, 184);
            this.GiderGridView1.TabIndex = 7;
            this.GiderGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GiderGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GiderGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GiderGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GiderGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GiderGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GiderGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GiderGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.GiderGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GiderGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GiderGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GiderGridView1.ThemeStyle.HeaderStyle.Height = 24;
            this.GiderGridView1.ThemeStyle.ReadOnly = true;
            this.GiderGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GiderGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GiderGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GiderGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GiderGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.GiderGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GiderGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giderlerim";
            // 
            // glrpnl
            // 
            this.glrpnl.BackColor = System.Drawing.SystemColors.Control;
            this.glrpnl.Controls.Add(this.GelirGridView1);
            this.glrpnl.Controls.Add(this.label3);
            this.glrpnl.Location = new System.Drawing.Point(14, 63);
            this.glrpnl.Name = "glrpnl";
            this.glrpnl.Size = new System.Drawing.Size(689, 227);
            this.glrpnl.TabIndex = 3;
            // 
            // GelirGridView1
            // 
            this.GelirGridView1.AllowUserToAddRows = false;
            this.GelirGridView1.AllowUserToDeleteRows = false;
            this.GelirGridView1.AllowUserToOrderColumns = true;
            this.GelirGridView1.AllowUserToResizeColumns = false;
            this.GelirGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.GelirGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GelirGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GelirGridView1.ColumnHeadersHeight = 24;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GelirGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.GelirGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GelirGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GelirGridView1.Location = new System.Drawing.Point(15, 34);
            this.GelirGridView1.Name = "GelirGridView1";
            this.GelirGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GelirGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GelirGridView1.RowHeadersVisible = false;
            this.GelirGridView1.RowHeadersWidth = 51;
            this.GelirGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GelirGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GelirGridView1.RowTemplate.Height = 24;
            this.GelirGridView1.Size = new System.Drawing.Size(656, 184);
            this.GelirGridView1.TabIndex = 6;
            this.GelirGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GelirGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GelirGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.GelirGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GelirGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GelirGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GelirGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GelirGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.GelirGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GelirGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GelirGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GelirGridView1.ThemeStyle.HeaderStyle.Height = 24;
            this.GelirGridView1.ThemeStyle.ReadOnly = true;
            this.GelirGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GelirGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GelirGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelirGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GelirGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.GelirGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GelirGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gelirlerim";
            // 
            // ibnlbl
            // 
            this.ibnlbl.AutoSize = true;
            this.ibnlbl.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ibnlbl.ForeColor = System.Drawing.Color.Black;
            this.ibnlbl.Location = new System.Drawing.Point(26, 317);
            this.ibnlbl.Name = "ibnlbl";
            this.ibnlbl.Size = new System.Drawing.Size(120, 34);
            this.ibnlbl.TabIndex = 6;
            this.ibnlbl.Text = "Iban No";
            // 
            // hspisimlbl
            // 
            this.hspisimlbl.AutoSize = true;
            this.hspisimlbl.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hspisimlbl.ForeColor = System.Drawing.Color.Black;
            this.hspisimlbl.Location = new System.Drawing.Point(26, 374);
            this.hspisimlbl.Name = "hspisimlbl";
            this.hspisimlbl.Size = new System.Drawing.Size(159, 34);
            this.hspisimlbl.TabIndex = 8;
            this.hspisimlbl.Text = "Hesap İsmi";
            // 
            // hspbkylbl
            // 
            this.hspbkylbl.AutoSize = true;
            this.hspbkylbl.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hspbkylbl.ForeColor = System.Drawing.Color.Black;
            this.hspbkylbl.Location = new System.Drawing.Point(23, 429);
            this.hspbkylbl.Name = "hspbkylbl";
            this.hspbkylbl.Size = new System.Drawing.Size(210, 34);
            this.hspbkylbl.TabIndex = 9;
            this.hspbkylbl.Text = "Hesap Bakiyesi";
            // 
            // hspibntxt
            // 
            this.hspibntxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hspibntxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.hspibntxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hspibntxt.HintForeColor = System.Drawing.Color.Empty;
            this.hspibntxt.HintText = "";
            this.hspibntxt.isPassword = false;
            this.hspibntxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.hspibntxt.LineIdleColor = System.Drawing.Color.Gray;
            this.hspibntxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.hspibntxt.LineThickness = 3;
            this.hspibntxt.Location = new System.Drawing.Point(279, 307);
            this.hspibntxt.Margin = new System.Windows.Forms.Padding(4);
            this.hspibntxt.Name = "hspibntxt";
            this.hspibntxt.Size = new System.Drawing.Size(161, 44);
            this.hspibntxt.TabIndex = 11;
            this.hspibntxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "TR";
            // 
            // hanTürkDBDataSet
            // 
            this.hanTürkDBDataSet.DataSetName = "HanTürkDBDataSet";
            this.hanTürkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hanTürkDBDataSetBindingSource
            // 
            this.hanTürkDBDataSetBindingSource.DataSource = this.hanTürkDBDataSet;
            this.hanTürkDBDataSetBindingSource.Position = 0;
            // 
            // gelirGiderBindingSource
            // 
            this.gelirGiderBindingSource.DataMember = "GelirGider";
            this.gelirGiderBindingSource.DataSource = this.hanTürkDBDataSetBindingSource;
            // 
            // gelirGiderTableAdapter
            // 
            this.gelirGiderTableAdapter.ClearBeforeFill = true;
            // 
            // gözat
            // 
            this.gözat.Location = new System.Drawing.Point(514, 340);
            this.gözat.Name = "gözat";
            this.gözat.Size = new System.Drawing.Size(152, 48);
            this.gözat.TabIndex = 14;
            this.gözat.Text = "Hesap bilgilerini gör";
            this.gözat.UseVisualStyleBackColor = true;
            this.gözat.Click += new System.EventHandler(this.gözat_Click);
            // 
            // hesapBkygör
            // 
            this.hesapBkygör.AutoSize = true;
            this.hesapBkygör.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapBkygör.Location = new System.Drawing.Point(275, 429);
            this.hesapBkygör.Name = "hesapBkygör";
            this.hesapBkygör.Size = new System.Drawing.Size(0, 23);
            this.hesapBkygör.TabIndex = 15;
            // 
            // hspisimgörlbl
            // 
            this.hspisimgörlbl.AutoSize = true;
            this.hspisimgörlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hspisimgörlbl.Location = new System.Drawing.Point(275, 385);
            this.hspisimgörlbl.Name = "hspisimgörlbl";
            this.hspisimgörlbl.Size = new System.Drawing.Size(0, 23);
            this.hspisimgörlbl.TabIndex = 15;
            // 
            // HspBilgGör
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 551);
            this.Controls.Add(this.hspisimgörlbl);
            this.Controls.Add(this.hesapBkygör);
            this.Controls.Add(this.gözat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hspibntxt);
            this.Controls.Add(this.hspbkylbl);
            this.Controls.Add(this.hspisimlbl);
            this.Controls.Add(this.ibnlbl);
            this.Controls.Add(this.gdrbtn);
            this.Controls.Add(this.glrbtn);
            this.Controls.Add(this.glrpnl);
            this.Controls.Add(this.gdrpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HspBilgGör";
            this.Text = "HspBilgGör";
            this.Load += new System.EventHandler(this.HspBilgGör_Load);
            this.gdrpnl.ResumeLayout(false);
            this.gdrpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiderGridView1)).EndInit();
            this.glrpnl.ResumeLayout(false);
            this.glrpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GelirGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanTürkDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hanTürkDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirGiderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 glrbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 gdrbtn;
        private System.Windows.Forms.Panel gdrpnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel glrpnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ibnlbl;
        private System.Windows.Forms.Label hspisimlbl;
        private System.Windows.Forms.Label hspbkylbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox hspibntxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hanTürkDBDataSetBindingSource;
        private HanTürkDBDataSet hanTürkDBDataSet;
        private Guna.UI2.WinForms.Guna2DataGridView GelirGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView GiderGridView1;
        private System.Windows.Forms.BindingSource gelirGiderBindingSource;
        private HanTürkDBDataSetTableAdapters.GelirGiderTableAdapter gelirGiderTableAdapter;
        private System.Windows.Forms.Button gözat;
        private System.Windows.Forms.Label hesapBkygör;
        private System.Windows.Forms.Label hspisimgörlbl;
    }
}