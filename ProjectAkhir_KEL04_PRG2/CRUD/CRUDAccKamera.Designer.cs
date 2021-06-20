namespace ProjectAkhir_KEL04_PRG2.CRUD
{
    partial class CRUDAccKamera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.dgAcc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbSearch = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.tokoKameraDataSet = new ProjectAkhir_KEL04_PRG2.TokoKameraDataSet();
            this.tbKategoriAccBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbKategoriAccTableAdapter = new ProjectAkhir_KEL04_PRG2.TokoKameraDataSetTableAdapters.tbKategoriAccTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoKameraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKategoriAccBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.AutoRoundedCorners = true;
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderRadius = 16;
            this.btnHapus.CheckedState.Parent = this.btnHapus;
            this.btnHapus.CustomImages.Parent = this.btnHapus;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.DisabledState.Parent = this.btnHapus;
            this.btnHapus.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHapus.HoverState.Parent = this.btnHapus;
            this.btnHapus.Location = new System.Drawing.Point(415, 223);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ShadowDecoration.Parent = this.btnHapus;
            this.btnHapus.Size = new System.Drawing.Size(102, 35);
            this.btnHapus.TabIndex = 35;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnHapus.Visible = false;
            // 
            // dgAcc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgAcc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAcc.BackgroundColor = System.Drawing.Color.White;
            this.dgAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgAcc.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAcc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgAcc.EnableHeadersVisualStyles = false;
            this.dgAcc.GridColor = System.Drawing.Color.White;
            this.dgAcc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgAcc.Location = new System.Drawing.Point(30, 357);
            this.dgAcc.Name = "dgAcc";
            this.dgAcc.RowHeadersVisible = false;
            this.dgAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAcc.Size = new System.Drawing.Size(585, 150);
            this.dgAcc.TabIndex = 34;
            this.dgAcc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgAcc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgAcc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgAcc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgAcc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgAcc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgAcc.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgAcc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgAcc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgAcc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgAcc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgAcc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgAcc.ThemeStyle.HeaderStyle.Height = 4;
            this.dgAcc.ThemeStyle.ReadOnly = false;
            this.dgAcc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgAcc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgAcc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgAcc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgAcc.ThemeStyle.RowsStyle.Height = 22;
            this.dgAcc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgAcc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnUbah
            // 
            this.btnUbah.AutoRoundedCorners = true;
            this.btnUbah.BackColor = System.Drawing.Color.Transparent;
            this.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUbah.BorderColor = System.Drawing.Color.Transparent;
            this.btnUbah.BorderRadius = 16;
            this.btnUbah.CheckedState.Parent = this.btnUbah;
            this.btnUbah.CustomImages.Parent = this.btnUbah;
            this.btnUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUbah.DisabledState.Parent = this.btnUbah;
            this.btnUbah.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnUbah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUbah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUbah.HoverState.Parent = this.btnUbah;
            this.btnUbah.Location = new System.Drawing.Point(415, 175);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.ShadowDecoration.Parent = this.btnUbah;
            this.btnUbah.Size = new System.Drawing.Size(102, 35);
            this.btnUbah.TabIndex = 33;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnUbah.Tile = true;
            this.btnUbah.Visible = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.AutoRoundedCorners = true;
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BorderRadius = 16;
            this.btnSimpan.CheckedState.Parent = this.btnSimpan;
            this.btnSimpan.CustomImages.Parent = this.btnSimpan;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.DisabledState.Parent = this.btnSimpan;
            this.btnSimpan.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSimpan.HoverState.Parent = this.btnSimpan;
            this.btnSimpan.Location = new System.Drawing.Point(415, 125);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.ShadowDecoration.Parent = this.btnSimpan;
            this.btnSimpan.Size = new System.Drawing.Size(102, 35);
            this.btnSimpan.TabIndex = 31;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.AutoRoundedCorners = true;
            this.btnBatal.BackColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderRadius = 16;
            this.btnBatal.CheckedState.Parent = this.btnBatal;
            this.btnBatal.CustomImages.Parent = this.btnBatal;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.DisabledState.Parent = this.btnBatal;
            this.btnBatal.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBatal.HoverState.Parent = this.btnBatal;
            this.btnBatal.Location = new System.Drawing.Point(415, 271);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.ShadowDecoration.Parent = this.btnBatal;
            this.btnBatal.Size = new System.Drawing.Size(102, 35);
            this.btnBatal.TabIndex = 32;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::ProjectAkhir_KEL04_PRG2.Properties.Resources.active_search_png;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(347, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(37, 37);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.TextFormatNoPrefix = true;
            this.btnSearch.Tile = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("STHupo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(58, 272);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(60, 21);
            this.guna2HtmlLabel7.TabIndex = 29;
            this.guna2HtmlLabel7.Text = "Jumlah";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("STHupo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(58, 230);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(54, 21);
            this.guna2HtmlLabel6.TabIndex = 28;
            this.guna2HtmlLabel6.Text = "Harga";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("STHupo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(58, 185);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(43, 21);
            this.guna2HtmlLabel5.TabIndex = 27;
            this.guna2HtmlLabel5.Text = "Jenis";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("STHupo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(58, 145);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(51, 21);
            this.guna2HtmlLabel4.TabIndex = 26;
            this.guna2HtmlLabel4.Text = "Nama";
            // 
            // labelID
            // 
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("STHupo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelID.Location = new System.Drawing.Point(30, 66);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(104, 21);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID Aksesoris";
            this.labelID.Visible = false;
            // 
            // txtJumlah
            // 
            this.txtJumlah.AutoRoundedCorners = true;
            this.txtJumlah.BackColor = System.Drawing.Color.Transparent;
            this.txtJumlah.BorderRadius = 17;
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.DefaultText = "";
            this.txtJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.DisabledState.Parent = this.txtJumlah;
            this.txtJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.FocusedState.Parent = this.txtJumlah;
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.HoverState.Parent = this.txtJumlah;
            this.txtJumlah.Location = new System.Drawing.Point(184, 263);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderText = "";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.ShadowDecoration.Parent = this.txtJumlah;
            this.txtJumlah.Size = new System.Drawing.Size(200, 36);
            this.txtJumlah.TabIndex = 22;
            // 
            // txtHarga
            // 
            this.txtHarga.AutoRoundedCorners = true;
            this.txtHarga.BackColor = System.Drawing.Color.Transparent;
            this.txtHarga.BorderRadius = 17;
            this.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarga.DefaultText = "";
            this.txtHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.DisabledState.Parent = this.txtHarga;
            this.txtHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.FocusedState.Parent = this.txtHarga;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.HoverState.Parent = this.txtHarga;
            this.txtHarga.Location = new System.Drawing.Point(184, 221);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.PlaceholderText = "";
            this.txtHarga.SelectedText = "";
            this.txtHarga.ShadowDecoration.Parent = this.txtHarga;
            this.txtHarga.Size = new System.Drawing.Size(200, 36);
            this.txtHarga.TabIndex = 21;
            // 
            // txtNama
            // 
            this.txtNama.AutoRoundedCorners = true;
            this.txtNama.BackColor = System.Drawing.Color.Transparent;
            this.txtNama.BorderRadius = 17;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.Parent = this.txtNama;
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.FocusedState.Parent = this.txtNama;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.HoverState.Parent = this.txtNama;
            this.txtNama.Location = new System.Drawing.Point(184, 137);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(200, 36);
            this.txtNama.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.AutoRoundedCorners = true;
            this.txtID.BackColor = System.Drawing.Color.Transparent;
            this.txtID.BorderRadius = 17;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(140, 56);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(200, 36);
            this.txtID.TabIndex = 20;
            this.txtID.Visible = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("STHupo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(216, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(212, 30);
            this.guna2HtmlLabel1.TabIndex = 17;
            this.guna2HtmlLabel1.Text = "Aksesoris Kamera";
            // 
            // cbSearch
            // 
            this.cbSearch.AutoSize = true;
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.CheckedState.BorderRadius = 0;
            this.cbSearch.CheckedState.BorderThickness = 0;
            this.cbSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.Enabled = false;
            this.cbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbSearch.Location = new System.Drawing.Point(151, 99);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(58, 17);
            this.cbSearch.TabIndex = 36;
            this.cbSearch.Text = "Cari ID";
            this.cbSearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSearch.UncheckedState.BorderRadius = 0;
            this.cbSearch.UncheckedState.BorderThickness = 0;
            this.cbSearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSearch.UseVisualStyleBackColor = false;
            this.cbSearch.CheckedChanged += new System.EventHandler(this.cbSearch_CheckedChanged);
            // 
            // cbJenis
            // 
            this.cbJenis.BackColor = System.Drawing.SystemColors.Control;
            this.cbJenis.DataSource = this.tbKategoriAccBindingSource;
            this.cbJenis.DisplayMember = "nama_kategori";
            this.cbJenis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Location = new System.Drawing.Point(184, 182);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(200, 24);
            this.cbJenis.TabIndex = 37;
            this.cbJenis.ValueMember = "id_kategori";
            // 
            // tokoKameraDataSet
            // 
            this.tokoKameraDataSet.DataSetName = "TokoKameraDataSet";
            this.tokoKameraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbKategoriAccBindingSource
            // 
            this.tbKategoriAccBindingSource.DataMember = "tbKategoriAcc";
            this.tbKategoriAccBindingSource.DataSource = this.tokoKameraDataSet;
            // 
            // tbKategoriAccTableAdapter
            // 
            this.tbKategoriAccTableAdapter.ClearBeforeFill = true;
            // 
            // CRUDAccKamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectAkhir_KEL04_PRG2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 527);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dgAcc);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUDAccKamera";
            this.Text = "CRUDAccKamera";
            this.Load += new System.EventHandler(this.CRUDAccKamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoKameraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbKategoriAccBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2DataGridView dgAcc;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelID;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox cbSearch;
        private System.Windows.Forms.ComboBox cbJenis;
        private TokoKameraDataSet tokoKameraDataSet;
        private System.Windows.Forms.BindingSource tbKategoriAccBindingSource;
        private TokoKameraDataSetTableAdapters.tbKategoriAccTableAdapter tbKategoriAccTableAdapter;
    }
}