namespace LogIn1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxIsim = new System.Windows.Forms.TextBox();
            this.txtboxSoyisim = new System.Windows.Forms.TextBox();
            this.txtboxBolum = new System.Windows.Forms.TextBox();
            this.cmbboxSehir = new System.Windows.Forms.ComboBox();
            this.txtboxePosta = new System.Windows.Forms.TextBox();
            this.txtboxSifre = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDBDataSet2 = new LogIn1.studentsDBDataSet2();
            this.studentsTableTableAdapter = new LogIn1.studentsDBDataSet2TableAdapters.studentsTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bölümDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geldiğiŞehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(14, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2059, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "İŞLEMLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(16, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(17, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şehir:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(17, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "e-Posta:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(17, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 44);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şifre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(15, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 44);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kayıt Tarihi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxIsim
            // 
            this.txtboxIsim.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxIsim.ForeColor = System.Drawing.Color.Purple;
            this.txtboxIsim.Location = new System.Drawing.Point(148, 70);
            this.txtboxIsim.Multiline = true;
            this.txtboxIsim.Name = "txtboxIsim";
            this.txtboxIsim.Size = new System.Drawing.Size(347, 44);
            this.txtboxIsim.TabIndex = 8;
            this.txtboxIsim.TextChanged += new System.EventHandler(this.txtboxIsim_TextChanged);
            // 
            // txtboxSoyisim
            // 
            this.txtboxSoyisim.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtboxSoyisim.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSoyisim.ForeColor = System.Drawing.Color.Purple;
            this.txtboxSoyisim.Location = new System.Drawing.Point(148, 129);
            this.txtboxSoyisim.Multiline = true;
            this.txtboxSoyisim.Name = "txtboxSoyisim";
            this.txtboxSoyisim.Size = new System.Drawing.Size(347, 44);
            this.txtboxSoyisim.TabIndex = 9;
            // 
            // txtboxBolum
            // 
            this.txtboxBolum.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxBolum.ForeColor = System.Drawing.Color.Purple;
            this.txtboxBolum.Location = new System.Drawing.Point(148, 188);
            this.txtboxBolum.Multiline = true;
            this.txtboxBolum.Name = "txtboxBolum";
            this.txtboxBolum.Size = new System.Drawing.Size(347, 44);
            this.txtboxBolum.TabIndex = 10;
            // 
            // cmbboxSehir
            // 
            this.cmbboxSehir.AllowDrop = true;
            this.cmbboxSehir.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxSehir.ForeColor = System.Drawing.Color.Purple;
            this.cmbboxSehir.FormattingEnabled = true;
            this.cmbboxSehir.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ (İZMİT)",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA (ADAPAZARI)",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.cmbboxSehir.Location = new System.Drawing.Point(149, 246);
            this.cmbboxSehir.Name = "cmbboxSehir";
            this.cmbboxSehir.Size = new System.Drawing.Size(346, 27);
            this.cmbboxSehir.TabIndex = 11;
            this.cmbboxSehir.SelectedIndexChanged += new System.EventHandler(this.cmbboxSehir_SelectedIndexChanged);
            // 
            // txtboxePosta
            // 
            this.txtboxePosta.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxePosta.ForeColor = System.Drawing.Color.Purple;
            this.txtboxePosta.Location = new System.Drawing.Point(148, 290);
            this.txtboxePosta.Multiline = true;
            this.txtboxePosta.Name = "txtboxePosta";
            this.txtboxePosta.Size = new System.Drawing.Size(347, 44);
            this.txtboxePosta.TabIndex = 12;
            // 
            // txtboxSifre
            // 
            this.txtboxSifre.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSifre.ForeColor = System.Drawing.Color.Purple;
            this.txtboxSifre.Location = new System.Drawing.Point(147, 347);
            this.txtboxSifre.Multiline = true;
            this.txtboxSifre.Name = "txtboxSifre";
            this.txtboxSifre.PasswordChar = '*';
            this.txtboxSifre.Size = new System.Drawing.Size(348, 44);
            this.txtboxSifre.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 412);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.Color.Purple;
            this.btnListele.Location = new System.Drawing.Point(879, 152);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(287, 44);
            this.btnListele.TabIndex = 16;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Purple;
            this.btnEkle.Location = new System.Drawing.Point(879, 84);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(287, 44);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Purple;
            this.btnTemizle.Location = new System.Drawing.Point(879, 218);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(287, 44);
            this.btnTemizle.TabIndex = 18;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Purple;
            this.btnGuncelle.Location = new System.Drawing.Point(879, 290);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(287, 44);
            this.btnGuncelle.TabIndex = 19;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Purple;
            this.btnSil.Location = new System.Drawing.Point(879, 356);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(287, 44);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.bölümDataGridViewTextBoxColumn,
            this.geldiğiŞehirDataGridViewTextBoxColumn,
            this.ePostaDataGridViewTextBoxColumn,
            this.şifreDataGridViewTextBoxColumn,
            this.kayıtTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1540, 176);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // studentsTableBindingSource
            // 
            this.studentsTableBindingSource.DataMember = "studentsTable";
            this.studentsTableBindingSource.DataSource = this.studentsDBDataSet2;
            // 
            // studentsDBDataSet2
            // 
            this.studentsDBDataSet2.DataSetName = "studentsDBDataSet2";
            this.studentsDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableTableAdapter
            // 
            this.studentsTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(1, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1546, 201);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "İSİM";
            this.isimDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "SOYİSİM";
            this.soyisimDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            // 
            // bölümDataGridViewTextBoxColumn
            // 
            this.bölümDataGridViewTextBoxColumn.DataPropertyName = "bölüm";
            this.bölümDataGridViewTextBoxColumn.HeaderText = "BÖLÜM";
            this.bölümDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bölümDataGridViewTextBoxColumn.Name = "bölümDataGridViewTextBoxColumn";
            // 
            // geldiğiŞehirDataGridViewTextBoxColumn
            // 
            this.geldiğiŞehirDataGridViewTextBoxColumn.DataPropertyName = "geldiğiŞehir";
            this.geldiğiŞehirDataGridViewTextBoxColumn.HeaderText = "ŞEHİR";
            this.geldiğiŞehirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.geldiğiŞehirDataGridViewTextBoxColumn.Name = "geldiğiŞehirDataGridViewTextBoxColumn";
            // 
            // ePostaDataGridViewTextBoxColumn
            // 
            this.ePostaDataGridViewTextBoxColumn.DataPropertyName = "ePosta";
            this.ePostaDataGridViewTextBoxColumn.HeaderText = "e-POSTA";
            this.ePostaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ePostaDataGridViewTextBoxColumn.Name = "ePostaDataGridViewTextBoxColumn";
            // 
            // şifreDataGridViewTextBoxColumn
            // 
            this.şifreDataGridViewTextBoxColumn.DataPropertyName = "şifre";
            this.şifreDataGridViewTextBoxColumn.HeaderText = "ŞİFRE";
            this.şifreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.şifreDataGridViewTextBoxColumn.Name = "şifreDataGridViewTextBoxColumn";
            this.şifreDataGridViewTextBoxColumn.Visible = false;
            // 
            // kayıtTarihiDataGridViewTextBoxColumn
            // 
            this.kayıtTarihiDataGridViewTextBoxColumn.DataPropertyName = "kayıtTarihi";
            this.kayıtTarihiDataGridViewTextBoxColumn.HeaderText = "KAYIT TARİHİ";
            this.kayıtTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kayıtTarihiDataGridViewTextBoxColumn.Name = "kayıtTarihiDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtboxSifre);
            this.Controls.Add(this.txtboxePosta);
            this.Controls.Add(this.cmbboxSehir);
            this.Controls.Add(this.txtboxBolum);
            this.Controls.Add(this.txtboxSoyisim);
            this.Controls.Add(this.txtboxIsim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "ÖĞRENCİ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDBDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxIsim;
        private System.Windows.Forms.TextBox txtboxSoyisim;
        private System.Windows.Forms.TextBox txtboxBolum;
        private System.Windows.Forms.ComboBox cmbboxSehir;
        private System.Windows.Forms.TextBox txtboxePosta;
        private System.Windows.Forms.TextBox txtboxSifre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDBDataSet2 studentsDBDataSet2;
        private System.Windows.Forms.BindingSource studentsTableBindingSource;
        private studentsDBDataSet2TableAdapters.studentsTableTableAdapter studentsTableTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bölümDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geldiğiŞehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayıtTarihiDataGridViewTextBoxColumn;
    }
}