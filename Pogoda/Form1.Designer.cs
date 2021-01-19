
namespace Pogoda
{
    partial class Pogoda
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pogoda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tempminlabel = new System.Windows.Forms.Label();
            this.tempmaxlabel = new System.Windows.Forms.Label();
            this.sunriseLabel = new System.Windows.Forms.Label();
            this.sunsetLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.coordsLabel = new System.Windows.Forms.Label();
            this.displJsonDataCheckBox = new System.Windows.Forms.CheckBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.jsonWeatherRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pogodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażPogodęDlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.białegostokuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bydgoszczyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gdańskaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gorzowaWielkopolskiegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katowicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kielcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krakowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lublinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.łodziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mińskaMazowieckiegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olsztynaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poznaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rzeszowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zczecinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warszawyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrocławiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPorogramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cities);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 474);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Cities
            // 
            this.Cities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cities.FormattingEnabled = true;
            this.Cities.ItemHeight = 25;
            this.Cities.Items.AddRange(new object[] {
            "Białystok",
            "Bydgoszcz",
            "Gdańsk",
            "Gorzów Wielkopolski",
            "Katowice",
            "Kielce",
            "Kraków",
            "Lublin",
            "Łódź",
            "Mińsk Mazowiecki",
            "Olsztyn",
            "Opole",
            "Poznań",
            "Rzeszów",
            "Szczecin",
            "Warszawa",
            "Wrocław"});
            this.Cities.Location = new System.Drawing.Point(12, 42);
            this.Cities.Name = "Cities";
            this.Cities.Size = new System.Drawing.Size(264, 429);
            this.Cities.TabIndex = 2;
            this.Cities.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz miasto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.BackgroundImage = global::Pogoda.Properties.Resources.pogoda2;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.tempminlabel);
            this.groupBox2.Controls.Add(this.tempmaxlabel);
            this.groupBox2.Controls.Add(this.sunriseLabel);
            this.groupBox2.Controls.Add(this.sunsetLabel);
            this.groupBox2.Controls.Add(this.weatherLabel);
            this.groupBox2.Controls.Add(this.pressureLabel);
            this.groupBox2.Controls.Add(this.humidityLabel);
            this.groupBox2.Controls.Add(this.tempLabel);
            this.groupBox2.Controls.Add(this.cityLabel);
            this.groupBox2.Controls.Add(this.coordsLabel);
            this.groupBox2.Controls.Add(this.displJsonDataCheckBox);
            this.groupBox2.Controls.Add(this.Picture);
            this.groupBox2.Location = new System.Drawing.Point(286, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 474);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tempminlabel
            // 
            this.tempminlabel.AutoSize = true;
            this.tempminlabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.tempminlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempminlabel.ForeColor = System.Drawing.Color.Black;
            this.tempminlabel.Location = new System.Drawing.Point(6, 362);
            this.tempminlabel.Name = "tempminlabel";
            this.tempminlabel.Size = new System.Drawing.Size(258, 25);
            this.tempminlabel.TabIndex = 17;
            this.tempminlabel.Text = "Temperatura minimalna";
            // 
            // tempmaxlabel
            // 
            this.tempmaxlabel.AutoSize = true;
            this.tempmaxlabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.tempmaxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempmaxlabel.ForeColor = System.Drawing.Color.Black;
            this.tempmaxlabel.Location = new System.Drawing.Point(6, 387);
            this.tempmaxlabel.Name = "tempmaxlabel";
            this.tempmaxlabel.Size = new System.Drawing.Size(282, 25);
            this.tempmaxlabel.TabIndex = 16;
            this.tempmaxlabel.Text = "Temperatura maksymalna";
            // 
            // sunriseLabel
            // 
            this.sunriseLabel.AutoSize = true;
            this.sunriseLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.sunriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sunriseLabel.ForeColor = System.Drawing.Color.Black;
            this.sunriseLabel.Location = new System.Drawing.Point(6, 264);
            this.sunriseLabel.Name = "sunriseLabel";
            this.sunriseLabel.Size = new System.Drawing.Size(91, 25);
            this.sunriseLabel.TabIndex = 15;
            this.sunriseLabel.Text = "wschód";
            // 
            // sunsetLabel
            // 
            this.sunsetLabel.AutoSize = true;
            this.sunsetLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.sunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sunsetLabel.ForeColor = System.Drawing.Color.Black;
            this.sunsetLabel.Location = new System.Drawing.Point(6, 289);
            this.sunsetLabel.Name = "sunsetLabel";
            this.sunsetLabel.Size = new System.Drawing.Size(88, 25);
            this.sunsetLabel.TabIndex = 14;
            this.sunsetLabel.Text = "zachód";
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.weatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weatherLabel.ForeColor = System.Drawing.Color.Black;
            this.weatherLabel.Location = new System.Drawing.Point(6, 314);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(212, 25);
            this.weatherLabel.TabIndex = 13;
            this.weatherLabel.Text = "Warunki pogodowe";
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pressureLabel.ForeColor = System.Drawing.Color.Black;
            this.pressureLabel.Location = new System.Drawing.Point(6, 189);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(106, 25);
            this.pressureLabel.TabIndex = 12;
            this.pressureLabel.Text = "ciśnienie";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.humidityLabel.ForeColor = System.Drawing.Color.Black;
            this.humidityLabel.Location = new System.Drawing.Point(6, 214);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(123, 25);
            this.humidityLabel.TabIndex = 11;
            this.humidityLabel.Text = "wilgotność";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempLabel.ForeColor = System.Drawing.Color.Black;
            this.tempLabel.Location = new System.Drawing.Point(6, 164);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(138, 25);
            this.tempLabel.TabIndex = 10;
            this.tempLabel.Text = "temperatura";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cityLabel.ForeColor = System.Drawing.Color.Black;
            this.cityLabel.Location = new System.Drawing.Point(6, 19);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(81, 25);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "miasto";
            // 
            // coordsLabel
            // 
            this.coordsLabel.AutoSize = true;
            this.coordsLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.coordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.coordsLabel.ForeColor = System.Drawing.Color.Black;
            this.coordsLabel.Location = new System.Drawing.Point(6, 56);
            this.coordsLabel.Name = "coordsLabel";
            this.coordsLabel.Size = new System.Drawing.Size(114, 25);
            this.coordsLabel.TabIndex = 5;
            this.coordsLabel.Text = "położenie";
            // 
            // displJsonDataCheckBox
            // 
            this.displJsonDataCheckBox.AutoSize = true;
            this.displJsonDataCheckBox.BackColor = System.Drawing.Color.Red;
            this.displJsonDataCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displJsonDataCheckBox.ForeColor = System.Drawing.Color.White;
            this.displJsonDataCheckBox.Location = new System.Drawing.Point(229, 450);
            this.displJsonDataCheckBox.Name = "displJsonDataCheckBox";
            this.displJsonDataCheckBox.Size = new System.Drawing.Size(129, 17);
            this.displJsonDataCheckBox.TabIndex = 2;
            this.displJsonDataCheckBox.Text = "Pokaż dane JSON";
            this.displJsonDataCheckBox.UseVisualStyleBackColor = false;
            this.displJsonDataCheckBox.Visible = false;
            this.displJsonDataCheckBox.CheckedChanged += new System.EventHandler(this.displJsonDataCheckBox_CheckedChanged);
            // 
            // Picture
            // 
            this.Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Picture.BackColor = System.Drawing.Color.Transparent;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picture.Location = new System.Drawing.Point(389, 85);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(185, 166);
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            // 
            // jsonWeatherRichTxtBox
            // 
            this.jsonWeatherRichTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.jsonWeatherRichTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jsonWeatherRichTxtBox.ForeColor = System.Drawing.Color.White;
            this.jsonWeatherRichTxtBox.Location = new System.Drawing.Point(12, 516);
            this.jsonWeatherRichTxtBox.Name = "jsonWeatherRichTxtBox";
            this.jsonWeatherRichTxtBox.ReadOnly = true;
            this.jsonWeatherRichTxtBox.Size = new System.Drawing.Size(860, 237);
            this.jsonWeatherRichTxtBox.TabIndex = 0;
            this.jsonWeatherRichTxtBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pogodaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pogodaToolStripMenuItem
            // 
            this.pogodaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażPogodęDlaToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.pogodaToolStripMenuItem.Name = "pogodaToolStripMenuItem";
            this.pogodaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.pogodaToolStripMenuItem.Text = "Pogoda";
            // 
            // pokażPogodęDlaToolStripMenuItem
            // 
            this.pokażPogodęDlaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.białegostokuToolStripMenuItem,
            this.bydgoszczyToolStripMenuItem,
            this.gdańskaToolStripMenuItem,
            this.gorzowaWielkopolskiegoToolStripMenuItem,
            this.katowicToolStripMenuItem,
            this.kielcToolStripMenuItem,
            this.krakowaToolStripMenuItem,
            this.lublinaToolStripMenuItem,
            this.łodziToolStripMenuItem,
            this.mińskaMazowieckiegoToolStripMenuItem,
            this.olsztynaToolStripMenuItem,
            this.opolaToolStripMenuItem,
            this.poznaniaToolStripMenuItem,
            this.rzeszowaToolStripMenuItem,
            this.zczecinaToolStripMenuItem,
            this.warszawyToolStripMenuItem,
            this.wrocławiaToolStripMenuItem});
            this.pokażPogodęDlaToolStripMenuItem.Name = "pokażPogodęDlaToolStripMenuItem";
            this.pokażPogodęDlaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.pokażPogodęDlaToolStripMenuItem.Text = "Pokaż pogodę dla...";
            // 
            // białegostokuToolStripMenuItem
            // 
            this.białegostokuToolStripMenuItem.Name = "białegostokuToolStripMenuItem";
            this.białegostokuToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.białegostokuToolStripMenuItem.Text = "Białegostoku";
            this.białegostokuToolStripMenuItem.Click += new System.EventHandler(this.białegostokuToolStripMenuItem_Click);
            // 
            // bydgoszczyToolStripMenuItem
            // 
            this.bydgoszczyToolStripMenuItem.Name = "bydgoszczyToolStripMenuItem";
            this.bydgoszczyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.bydgoszczyToolStripMenuItem.Text = "Bydgoszczy";
            this.bydgoszczyToolStripMenuItem.Click += new System.EventHandler(this.bydgoszczyToolStripMenuItem_Click);
            // 
            // gdańskaToolStripMenuItem
            // 
            this.gdańskaToolStripMenuItem.Name = "gdańskaToolStripMenuItem";
            this.gdańskaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gdańskaToolStripMenuItem.Text = "Gdańska";
            this.gdańskaToolStripMenuItem.Click += new System.EventHandler(this.gdańskaToolStripMenuItem_Click);
            // 
            // gorzowaWielkopolskiegoToolStripMenuItem
            // 
            this.gorzowaWielkopolskiegoToolStripMenuItem.Name = "gorzowaWielkopolskiegoToolStripMenuItem";
            this.gorzowaWielkopolskiegoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gorzowaWielkopolskiegoToolStripMenuItem.Text = "Gorzowa Wielkopolskiego";
            this.gorzowaWielkopolskiegoToolStripMenuItem.Click += new System.EventHandler(this.gorzowaWielkopolskiegoToolStripMenuItem_Click);
            // 
            // katowicToolStripMenuItem
            // 
            this.katowicToolStripMenuItem.Name = "katowicToolStripMenuItem";
            this.katowicToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.katowicToolStripMenuItem.Text = "Katowic";
            this.katowicToolStripMenuItem.Click += new System.EventHandler(this.katowicToolStripMenuItem_Click);
            // 
            // kielcToolStripMenuItem
            // 
            this.kielcToolStripMenuItem.Name = "kielcToolStripMenuItem";
            this.kielcToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.kielcToolStripMenuItem.Text = "Kielc";
            this.kielcToolStripMenuItem.Click += new System.EventHandler(this.kielcToolStripMenuItem_Click);
            // 
            // krakowaToolStripMenuItem
            // 
            this.krakowaToolStripMenuItem.Name = "krakowaToolStripMenuItem";
            this.krakowaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.krakowaToolStripMenuItem.Text = "Krakowa";
            this.krakowaToolStripMenuItem.Click += new System.EventHandler(this.krakowaToolStripMenuItem_Click);
            // 
            // lublinaToolStripMenuItem
            // 
            this.lublinaToolStripMenuItem.Name = "lublinaToolStripMenuItem";
            this.lublinaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.lublinaToolStripMenuItem.Text = "Lublina";
            this.lublinaToolStripMenuItem.Click += new System.EventHandler(this.lublinaToolStripMenuItem_Click);
            // 
            // łodziToolStripMenuItem
            // 
            this.łodziToolStripMenuItem.Name = "łodziToolStripMenuItem";
            this.łodziToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.łodziToolStripMenuItem.Text = "Łodzi";
            this.łodziToolStripMenuItem.Click += new System.EventHandler(this.łodziToolStripMenuItem_Click);
            // 
            // mińskaMazowieckiegoToolStripMenuItem
            // 
            this.mińskaMazowieckiegoToolStripMenuItem.Name = "mińskaMazowieckiegoToolStripMenuItem";
            this.mińskaMazowieckiegoToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mińskaMazowieckiegoToolStripMenuItem.Text = "Mińska Mazowieckiego";
            this.mińskaMazowieckiegoToolStripMenuItem.Click += new System.EventHandler(this.mińskaMazowieckiegoToolStripMenuItem_Click);
            // 
            // olsztynaToolStripMenuItem
            // 
            this.olsztynaToolStripMenuItem.Name = "olsztynaToolStripMenuItem";
            this.olsztynaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.olsztynaToolStripMenuItem.Text = "Olsztyna";
            this.olsztynaToolStripMenuItem.Click += new System.EventHandler(this.olsztynaToolStripMenuItem_Click);
            // 
            // opolaToolStripMenuItem
            // 
            this.opolaToolStripMenuItem.Name = "opolaToolStripMenuItem";
            this.opolaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.opolaToolStripMenuItem.Text = "Opola";
            this.opolaToolStripMenuItem.Click += new System.EventHandler(this.opolaToolStripMenuItem_Click);
            // 
            // poznaniaToolStripMenuItem
            // 
            this.poznaniaToolStripMenuItem.Name = "poznaniaToolStripMenuItem";
            this.poznaniaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.poznaniaToolStripMenuItem.Text = "Poznania";
            this.poznaniaToolStripMenuItem.Click += new System.EventHandler(this.poznaniaToolStripMenuItem_Click);
            // 
            // rzeszowaToolStripMenuItem
            // 
            this.rzeszowaToolStripMenuItem.Name = "rzeszowaToolStripMenuItem";
            this.rzeszowaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.rzeszowaToolStripMenuItem.Text = "Rzeszowa";
            this.rzeszowaToolStripMenuItem.Click += new System.EventHandler(this.rzeszowaToolStripMenuItem_Click);
            // 
            // zczecinaToolStripMenuItem
            // 
            this.zczecinaToolStripMenuItem.Name = "zczecinaToolStripMenuItem";
            this.zczecinaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.zczecinaToolStripMenuItem.Text = "Szczecina";
            this.zczecinaToolStripMenuItem.Click += new System.EventHandler(this.zczecinaToolStripMenuItem_Click);
            // 
            // warszawyToolStripMenuItem
            // 
            this.warszawyToolStripMenuItem.Name = "warszawyToolStripMenuItem";
            this.warszawyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.warszawyToolStripMenuItem.Text = "Warszawy";
            this.warszawyToolStripMenuItem.Click += new System.EventHandler(this.warszawyToolStripMenuItem_Click);
            // 
            // wrocławiaToolStripMenuItem
            // 
            this.wrocławiaToolStripMenuItem.Name = "wrocławiaToolStripMenuItem";
            this.wrocławiaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.wrocławiaToolStripMenuItem.Text = "Wrocławia";
            this.wrocławiaToolStripMenuItem.Click += new System.EventHandler(this.wrocławiaToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPorogramieToolStripMenuItem,
            this.oAutorzeToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oPorogramieToolStripMenuItem
            // 
            this.oPorogramieToolStripMenuItem.Name = "oPorogramieToolStripMenuItem";
            this.oPorogramieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.oPorogramieToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.oPorogramieToolStripMenuItem.Text = "O orogramie";
            this.oPorogramieToolStripMenuItem.Click += new System.EventHandler(this.oPorogramieToolStripMenuItem_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.oAutorzeToolStripMenuItem.Text = "O autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(872, 510);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.axWindowsMediaPlayer1_ClickEvent);
            // 
            // Pogoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jsonWeatherRichTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pogoda";
            this.Text = "Pogoda";
            this.Load += new System.EventHandler(this.Pogoda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox jsonWeatherRichTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pogodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażPogodęDlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem białegostokuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPorogramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bydgoszczyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gdańskaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gorzowaWielkopolskiegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katowicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kielcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krakowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lublinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem łodziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olsztynaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opolaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poznaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rzeszowaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zczecinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mińskaMazowieckiegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warszawyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wrocławiaToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox Cities;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.CheckBox displJsonDataCheckBox;
        private System.Windows.Forms.Label sunriseLabel;
        private System.Windows.Forms.Label sunsetLabel;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label coordsLabel;
        private System.Windows.Forms.Label tempminlabel;
        private System.Windows.Forms.Label tempmaxlabel;
    }
}

