namespace ProjectAkhir_KEL04_PRG2.CRUD
{
    partial class CRUDKategoriAcc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelKategoriAcc = new Guna.UI2.WinForms.Guna2Panel();
            this.CheckID = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgKategoriAcc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUbah = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.LabelID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PanelKategoriAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategoriAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelKategoriAcc
            // 
            this.PanelKategoriAcc.BackColor = System.Drawing.Color.Transparent;
            this.PanelKategoriAcc.BackgroundImage = global::ProjectAkhir_KEL04_PRG2.Properties.Resources.background;
            this.PanelKategoriAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelKategoriAcc.BorderColor = System.Drawing.Color.Transparent;
            this.PanelKategoriAcc.Controls.Add(this.guna2ControlBox2);
            this.PanelKategoriAcc.Controls.Add(this.guna2ControlBox1);
            this.PanelKategoriAcc.Controls.Add(this.CheckID);
            this.PanelKategoriAcc.Controls.Add(this.btnHapus);
            this.PanelKategoriAcc.Controls.Add(this.btnSearch);
            this.PanelKategoriAcc.Controls.Add(this.dgKategoriAcc);
            this.PanelKategoriAcc.Controls.Add(this.btnUbah);
            this.PanelKategoriAcc.Controls.Add(this.guna2HtmlLabel3);
            this.PanelKategoriAcc.Controls.Add(this.btnSimpan);
            this.PanelKategoriAcc.Controls.Add(this.btnBatal);
            this.PanelKategoriAcc.Controls.Add(this.guna2HtmlLabel2);
            this.PanelKategoriAcc.Controls.Add(this.txtNama);
            this.PanelKategoriAcc.Controls.Add(this.LabelID);
            this.PanelKategoriAcc.Controls.Add(this.txtID);
            this.PanelKategoriAcc.CustomBorderColor = System.Drawing.Color.Black;
            this.PanelKategoriAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelKategoriAcc.Location = new System.Drawing.Point(0, 0);
            this.PanelKategoriAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelKategoriAcc.Name = "PanelKategoriAcc";
            this.PanelKategoriAcc.ShadowDecoration.Parent = this.PanelKategoriAcc;
            this.PanelKategoriAcc.Size = new System.Drawing.Size(956, 549);
            this.PanelKategoriAcc.TabIndex = 1;
            this.PanelKategoriAcc.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // CheckID
            // 
            this.CheckID.AutoSize = true;
            this.CheckID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckID.CheckedState.BorderRadius = 0;
            this.CheckID.CheckedState.BorderThickness = 0;
            this.CheckID.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CheckID.Location = new System.Drawing.Point(220, 157);
            this.CheckID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckID.Name = "CheckID";
            this.CheckID.Size = new System.Drawing.Size(88, 24);
            this.CheckID.TabIndex = 18;
            this.CheckID.Text = "Cari ID";
            this.CheckID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckID.UncheckedState.BorderRadius = 0;
            this.CheckID.UncheckedState.BorderThickness = 0;
            this.CheckID.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CheckID.CheckedChanged += new System.EventHandler(this.CheckID_CheckedChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.AutoRoundedCorners = true;
            this.btnHapus.BackColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderColor = System.Drawing.Color.Transparent;
            this.btnHapus.BorderRadius = 26;
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
            this.btnHapus.Location = new System.Drawing.Point(717, 266);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.ShadowDecoration.Parent = this.btnHapus;
            this.btnHapus.Size = new System.Drawing.Size(153, 54);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnHapus.Visible = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnSearch
            // 
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
            this.btnSearch.Location = new System.Drawing.Point(530, 89);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(56, 57);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.TextFormatNoPrefix = true;
            this.btnSearch.Tile = false;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgKategoriAcc
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgKategoriAcc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgKategoriAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKategoriAcc.BackgroundColor = System.Drawing.Color.White;
            this.dgKategoriAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgKategoriAcc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgKategoriAcc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKategoriAcc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgKategoriAcc.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgKategoriAcc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgKategoriAcc.EnableHeadersVisualStyles = false;
            this.dgKategoriAcc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgKategoriAcc.Location = new System.Drawing.Point(82, 300);
            this.dgKategoriAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgKategoriAcc.Name = "dgKategoriAcc";
            this.dgKategoriAcc.RowHeadersVisible = false;
            this.dgKategoriAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKategoriAcc.Size = new System.Drawing.Size(597, 180);
            this.dgKategoriAcc.TabIndex = 7;
            this.dgKategoriAcc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgKategoriAcc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgKategoriAcc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgKategoriAcc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgKategoriAcc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgKategoriAcc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgKategoriAcc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgKategoriAcc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgKategoriAcc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgKategoriAcc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgKategoriAcc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgKategoriAcc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgKategoriAcc.ThemeStyle.HeaderStyle.Height = 4;
            this.dgKategoriAcc.ThemeStyle.ReadOnly = false;
            this.dgKategoriAcc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgKategoriAcc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgKategoriAcc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgKategoriAcc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgKategoriAcc.ThemeStyle.RowsStyle.Height = 22;
            this.dgKategoriAcc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgKategoriAcc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgKategoriAcc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKategoriAcc_CellContentClick);
            // 
            // btnUbah
            // 
            this.btnUbah.AutoRoundedCorners = true;
            this.btnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUbah.BorderColor = System.Drawing.Color.Transparent;
            this.btnUbah.BorderRadius = 26;
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
            this.btnUbah.Location = new System.Drawing.Point(717, 185);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.ShadowDecoration.Parent = this.btnUbah;
            this.btnUbah.Size = new System.Drawing.Size(153, 54);
            this.btnUbah.TabIndex = 6;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnUbah.Tile = true;
            this.btnUbah.Visible = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("STHupo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(183, 18);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(471, 45);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Kategori Akesoris Kamera";
            // 
            // btnSimpan
            // 
            this.btnSimpan.AutoRoundedCorners = true;
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BorderRadius = 26;
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
            this.btnSimpan.Location = new System.Drawing.Point(717, 111);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.ShadowDecoration.Parent = this.btnSimpan;
            this.btnSimpan.Size = new System.Drawing.Size(153, 54);
            this.btnSimpan.TabIndex = 4;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.AutoRoundedCorners = true;
            this.btnBatal.BorderColor = System.Drawing.Color.Transparent;
            this.btnBatal.BorderRadius = 26;
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
            this.btnBatal.Location = new System.Drawing.Point(717, 346);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.ShadowDecoration.Parent = this.btnBatal;
            this.btnBatal.Size = new System.Drawing.Size(153, 54);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("STHupo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(82, 223);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(76, 32);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Nama";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // txtNama
            // 
            this.txtNama.AutoRoundedCorners = true;
            this.txtNama.BorderRadius = 26;
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
            this.txtNama.Location = new System.Drawing.Point(255, 217);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(300, 55);
            this.txtNama.TabIndex = 2;
            // 
            // LabelID
            // 
            this.LabelID.BackColor = System.Drawing.Color.Transparent;
            this.LabelID.Font = new System.Drawing.Font("STHupo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LabelID.Location = new System.Drawing.Point(48, 102);
            this.LabelID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(153, 32);
            this.LabelID.TabIndex = 1;
            this.LabelID.Text = "ID Kategori";
            // 
            // txtID
            // 
            this.txtID.AutoRoundedCorners = true;
            this.txtID.BorderRadius = 26;
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
            this.txtID.Location = new System.Drawing.Point(220, 91);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(300, 55);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(894, 18);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 19;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(814, 18);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 20;
            // 
            // CRUDKategoriAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 542);
            this.Controls.Add(this.PanelKategoriAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CRUDKategoriAcc";
            this.Text = "CRUDKategoriAcc";
            this.Load += new System.EventHandler(this.CRUDKategoriAcc_Load);
            this.PanelKategoriAcc.ResumeLayout(false);
            this.PanelKategoriAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKategoriAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelKategoriAcc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelID;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgKategoriAcc;
        private Guna.UI2.WinForms.Guna2Button btnUbah;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2CheckBox CheckID;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}