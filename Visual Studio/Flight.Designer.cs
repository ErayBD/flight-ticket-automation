namespace Proje {
	partial class Flight {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.p_left1 = new System.Windows.Forms.Panel();
			this.pb_left = new System.Windows.Forms.PictureBox();
			this.lb_ArrowT1 = new System.Windows.Forms.Label();
			this.p_leftMain2 = new System.Windows.Forms.Panel();
			this.pb_right = new System.Windows.Forms.PictureBox();
			this.p_leftMain = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bt_close = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.bt_ucusListe = new System.Windows.Forms.Button();
			this.p_right_id = new System.Windows.Forms.Panel();
			this.cb_nereden = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cb_nereye = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
			this.datagrid_ucusListe = new System.Windows.Forms.DataGridView();
			this.button9 = new System.Windows.Forms.Button();
			this.p_left1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_left)).BeginInit();
			this.p_leftMain2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_right)).BeginInit();
			this.p_leftMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.p_right_id.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagrid_ucusListe)).BeginInit();
			this.SuspendLayout();
			// 
			// p_left1
			// 
			this.p_left1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_left1.Controls.Add(this.pb_left);
			this.p_left1.Location = new System.Drawing.Point(0, 0);
			this.p_left1.Name = "p_left1";
			this.p_left1.Size = new System.Drawing.Size(50, 970);
			this.p_left1.TabIndex = 15;
			this.p_left1.Visible = false;
			// 
			// pb_left
			// 
			this.pb_left.Image = global::Proje.Properties.Resources.menuRB;
			this.pb_left.Location = new System.Drawing.Point(0, 460);
			this.pb_left.Name = "pb_left";
			this.pb_left.Size = new System.Drawing.Size(50, 50);
			this.pb_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_left.TabIndex = 0;
			this.pb_left.TabStop = false;
			this.pb_left.Click += new System.EventHandler(this.pb_left_Click);
			this.pb_left.MouseLeave += new System.EventHandler(this.pb_left_MouseLeave);
			this.pb_left.MouseHover += new System.EventHandler(this.pb_left_MouseHover);
			// 
			// lb_ArrowT1
			// 
			this.lb_ArrowT1.AutoSize = true;
			this.lb_ArrowT1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ArrowT1.ForeColor = System.Drawing.Color.White;
			this.lb_ArrowT1.Location = new System.Drawing.Point(150, 261);
			this.lb_ArrowT1.Name = "lb_ArrowT1";
			this.lb_ArrowT1.Size = new System.Drawing.Size(112, 34);
			this.lb_ArrowT1.TabIndex = 14;
			this.lb_ArrowT1.Text = "GaziFly";
			// 
			// p_leftMain2
			// 
			this.p_leftMain2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_leftMain2.Controls.Add(this.pb_right);
			this.p_leftMain2.Location = new System.Drawing.Point(430, 0);
			this.p_leftMain2.Name = "p_leftMain2";
			this.p_leftMain2.Size = new System.Drawing.Size(50, 970);
			this.p_leftMain2.TabIndex = 12;
			// 
			// pb_right
			// 
			this.pb_right.Image = global::Proje.Properties.Resources.menuLB;
			this.pb_right.Location = new System.Drawing.Point(0, 460);
			this.pb_right.Name = "pb_right";
			this.pb_right.Size = new System.Drawing.Size(50, 50);
			this.pb_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_right.TabIndex = 0;
			this.pb_right.TabStop = false;
			this.pb_right.Click += new System.EventHandler(this.pb_right_Click);
			this.pb_right.MouseLeave += new System.EventHandler(this.pb_right_MouseLeave);
			this.pb_right.MouseHover += new System.EventHandler(this.pb_right_MouseHover);
			// 
			// p_leftMain
			// 
			this.p_leftMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_leftMain.Controls.Add(this.button4);
			this.p_leftMain.Controls.Add(this.button3);
			this.p_leftMain.Controls.Add(this.button6);
			this.p_leftMain.Controls.Add(this.button7);
			this.p_leftMain.Controls.Add(this.button5);
			this.p_leftMain.Controls.Add(this.button2);
			this.p_leftMain.Controls.Add(this.lb_ArrowT1);
			this.p_leftMain.Controls.Add(this.p_leftMain2);
			this.p_leftMain.Controls.Add(this.pictureBox1);
			this.p_leftMain.Location = new System.Drawing.Point(0, 0);
			this.p_leftMain.Name = "p_leftMain";
			this.p_leftMain.Size = new System.Drawing.Size(480, 970);
			this.p_leftMain.TabIndex = 14;
			// 
			// button4
			// 
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(100, 760);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(230, 70);
			this.button4.TabIndex = 21;
			this.button4.Text = " Manage Booking";
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(100, 670);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(230, 70);
			this.button3.TabIndex = 20;
			this.button3.Text = "  Booking";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button6
			// 
			this.button6.AutoSize = true;
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(110)))), ((int)(((byte)(185)))));
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Location = new System.Drawing.Point(100, 400);
			this.button6.Margin = new System.Windows.Forms.Padding(4);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(230, 70);
			this.button6.TabIndex = 19;
			this.button6.Text = "   Search Flight";
			this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new System.Drawing.Point(100, 850);
			this.button7.Margin = new System.Windows.Forms.Padding(4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(230, 70);
			this.button7.TabIndex = 18;
			this.button7.Text = "  Profile";
			this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button5
			// 
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.Location = new System.Drawing.Point(100, 490);
			this.button5.Margin = new System.Windows.Forms.Padding(4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(230, 70);
			this.button5.TabIndex = 17;
			this.button5.Text = "   Sign In";
			this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(100, 580);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(230, 70);
			this.button2.TabIndex = 16;
			this.button2.Text = "  Sign Up";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Proje.Properties.Resources.plane;
			this.pictureBox1.Location = new System.Drawing.Point(12, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(412, 235);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// bt_close
			// 
			this.bt_close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bt_close.FlatAppearance.BorderSize = 0;
			this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_close.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_close.ForeColor = System.Drawing.Color.White;
			this.bt_close.Location = new System.Drawing.Point(1332, 0);
			this.bt_close.Name = "bt_close";
			this.bt_close.Size = new System.Drawing.Size(66, 55);
			this.bt_close.TabIndex = 13;
			this.bt_close.Text = "X";
			this.bt_close.UseVisualStyleBackColor = true;
			this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Proje.Properties.Resources.backgroundBlur;
			this.pictureBox2.Location = new System.Drawing.Point(50, 56);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1350, 914);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// bt_ucusListe
			// 
			this.bt_ucusListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_ucusListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_ucusListe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_ucusListe.ForeColor = System.Drawing.Color.White;
			this.bt_ucusListe.Location = new System.Drawing.Point(1100, 832);
			this.bt_ucusListe.Name = "bt_ucusListe";
			this.bt_ucusListe.Size = new System.Drawing.Size(133, 108);
			this.bt_ucusListe.TabIndex = 58;
			this.bt_ucusListe.Text = "List the Flights";
			this.bt_ucusListe.UseVisualStyleBackColor = false;
			this.bt_ucusListe.Click += new System.EventHandler(this.bt_ucusListe_Click);
			// 
			// p_right_id
			// 
			this.p_right_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_right_id.Controls.Add(this.cb_nereden);
			this.p_right_id.Controls.Add(this.textBox1);
			this.p_right_id.Location = new System.Drawing.Point(501, 832);
			this.p_right_id.Name = "p_right_id";
			this.p_right_id.Size = new System.Drawing.Size(240, 108);
			this.p_right_id.TabIndex = 1;
			// 
			// cb_nereden
			// 
			this.cb_nereden.FormattingEnabled = true;
			this.cb_nereden.Items.AddRange(new object[] {
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
			this.cb_nereden.Location = new System.Drawing.Point(20, 62);
			this.cb_nereden.Name = "cb_nereden";
			this.cb_nereden.Size = new System.Drawing.Size(188, 24);
			this.cb_nereden.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(70, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(87, 27);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "From";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.panel1.Controls.Add(this.cb_nereye);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Location = new System.Drawing.Point(810, 832);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 108);
			this.panel1.TabIndex = 2;
			// 
			// cb_nereye
			// 
			this.cb_nereye.FormattingEnabled = true;
			this.cb_nereye.Items.AddRange(new object[] {
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
			this.cb_nereye.Location = new System.Drawing.Point(20, 62);
			this.cb_nereye.Name = "cb_nereye";
			this.cb_nereye.Size = new System.Drawing.Size(188, 24);
			this.cb_nereye.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(70, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(87, 27);
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "To";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// npgsqlDataAdapter1
			// 
			this.npgsqlDataAdapter1.DeleteCommand = null;
			this.npgsqlDataAdapter1.InsertCommand = null;
			this.npgsqlDataAdapter1.SelectCommand = null;
			this.npgsqlDataAdapter1.UpdateCommand = null;
			// 
			// datagrid_ucusListe
			// 
			this.datagrid_ucusListe.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.datagrid_ucusListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.datagrid_ucusListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid_ucusListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.datagrid_ucusListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagrid_ucusListe.DefaultCellStyle = dataGridViewCellStyle2;
			this.datagrid_ucusListe.Location = new System.Drawing.Point(486, 68);
			this.datagrid_ucusListe.Name = "datagrid_ucusListe";
			this.datagrid_ucusListe.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagrid_ucusListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.datagrid_ucusListe.RowHeadersWidth = 51;
			this.datagrid_ucusListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.datagrid_ucusListe.RowTemplate.Height = 24;
			this.datagrid_ucusListe.Size = new System.Drawing.Size(902, 718);
			this.datagrid_ucusListe.TabIndex = 61;
			this.datagrid_ucusListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_ucusListe_CellClick);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.ForeColor = System.Drawing.Color.White;
			this.button9.Location = new System.Drawing.Point(1255, 832);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(133, 108);
			this.button9.TabIndex = 62;
			this.button9.Text = "Select";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// Flight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.ClientSize = new System.Drawing.Size(1400, 970);
			this.ControlBox = false;
			this.Controls.Add(this.button9);
			this.Controls.Add(this.datagrid_ucusListe);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.p_right_id);
			this.Controls.Add(this.bt_ucusListe);
			this.Controls.Add(this.p_left1);
			this.Controls.Add(this.p_leftMain);
			this.Controls.Add(this.bt_close);
			this.Controls.Add(this.pictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Flight";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Flight";
			this.p_left1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_left)).EndInit();
			this.p_leftMain2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_right)).EndInit();
			this.p_leftMain.ResumeLayout(false);
			this.p_leftMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.p_right_id.ResumeLayout(false);
			this.p_right_id.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagrid_ucusListe)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel p_left1;
		private System.Windows.Forms.PictureBox pb_left;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.PictureBox pb_right;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label lb_ArrowT1;
		private System.Windows.Forms.Panel p_leftMain2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel p_leftMain;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.Button bt_ucusListe;
		private System.Windows.Forms.Panel p_right_id;
		private System.Windows.Forms.ComboBox cb_nereden;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cb_nereye;
		private System.Windows.Forms.TextBox textBox2;
		private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
		private System.Windows.Forms.DataGridView datagrid_ucusListe;
		private System.Windows.Forms.Button button9;
	}
}