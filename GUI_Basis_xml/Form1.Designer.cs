namespace GUI_Basis_xml
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bewaarPersonenBtn = new System.Windows.Forms.Button();
            this.personenBox = new System.Windows.Forms.ListBox();
            this.laadPersonen = new System.Windows.Forms.Button();
            this.laadPersonenDOM = new System.Windows.Forms.Button();
            this.personenDataGrid = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.wisGeselecteerdeBtn = new System.Windows.Forms.Button();
            this.invoerBox = new System.Windows.Forms.GroupBox();
            this.geboortedatumDtp = new System.Windows.Forms.DateTimePicker();
            this.naamLbl = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.genereerID = new System.Windows.Forms.Button();
            this.voornaamLbl = new System.Windows.Forms.Label();
            this.voornaamTb = new System.Windows.Forms.TextBox();
            this.geboorteDatumLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.naamTb = new System.Windows.Forms.TextBox();
            this.wisveldenBtn = new System.Windows.Forms.Button();
            this.voegPersoonToeBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gegevensOpslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gegevensInladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voegRecordToeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwijderRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wisVeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.invoerBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bewaarPersonenBtn
            // 
            this.bewaarPersonenBtn.Enabled = false;
            this.bewaarPersonenBtn.Location = new System.Drawing.Point(17, 448);
            this.bewaarPersonenBtn.Name = "bewaarPersonenBtn";
            this.bewaarPersonenBtn.Size = new System.Drawing.Size(174, 60);
            this.bewaarPersonenBtn.TabIndex = 0;
            this.bewaarPersonenBtn.Text = "Bewaar records\r\nmet XmlTextWriter";
            this.bewaarPersonenBtn.UseVisualStyleBackColor = true;
            // 
            // personenBox
            // 
            this.personenBox.FormattingEnabled = true;
            this.personenBox.ItemHeight = 20;
            this.personenBox.Location = new System.Drawing.Point(17, 251);
            this.personenBox.Name = "personenBox";
            this.personenBox.ScrollAlwaysVisible = true;
            this.personenBox.Size = new System.Drawing.Size(918, 184);
            this.personenBox.TabIndex = 1;
            // 
            // laadPersonen
            // 
            this.laadPersonen.Location = new System.Drawing.Point(3, 444);
            this.laadPersonen.Name = "laadPersonen";
            this.laadPersonen.Size = new System.Drawing.Size(204, 64);
            this.laadPersonen.TabIndex = 2;
            this.laadPersonen.Text = "Laad Personen\r\nmet XmlTextReader";
            this.laadPersonen.UseVisualStyleBackColor = true;
            // 
            // laadPersonenDOM
            // 
            this.laadPersonenDOM.Location = new System.Drawing.Point(213, 444);
            this.laadPersonenDOM.Name = "laadPersonenDOM";
            this.laadPersonenDOM.Size = new System.Drawing.Size(204, 64);
            this.laadPersonenDOM.TabIndex = 6;
            this.laadPersonenDOM.Text = "Laad personen\r\nmet DOM";
            this.laadPersonenDOM.UseVisualStyleBackColor = true;
            // 
            // personenDataGrid
            // 
            this.personenDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personenDataGrid.Location = new System.Drawing.Point(6, 6);
            this.personenDataGrid.Name = "personenDataGrid";
            this.personenDataGrid.RowHeadersWidth = 51;
            this.personenDataGrid.RowTemplate.Height = 29;
            this.personenDataGrid.Size = new System.Drawing.Size(943, 432);
            this.personenDataGrid.TabIndex = 7;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 549);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wisGeselecteerdeBtn);
            this.tabPage1.Controls.Add(this.invoerBox);
            this.tabPage1.Controls.Add(this.personenBox);
            this.tabPage1.Controls.Add(this.wisveldenBtn);
            this.tabPage1.Controls.Add(this.bewaarPersonenBtn);
            this.tabPage1.Controls.Add(this.voegPersoonToeBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Persoon toevoegen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // wisGeselecteerdeBtn
            // 
            this.wisGeselecteerdeBtn.Location = new System.Drawing.Point(785, 448);
            this.wisGeselecteerdeBtn.Name = "wisGeselecteerdeBtn";
            this.wisGeselecteerdeBtn.Size = new System.Drawing.Size(150, 60);
            this.wisGeselecteerdeBtn.TabIndex = 26;
            this.wisGeselecteerdeBtn.Text = "Wis geselecteerde\r\nrecord";
            this.wisGeselecteerdeBtn.UseVisualStyleBackColor = true;
            this.wisGeselecteerdeBtn.Click += new System.EventHandler(this.wisGeselecteerdeBtn_Click);
            // 
            // invoerBox
            // 
            this.invoerBox.Controls.Add(this.geboortedatumDtp);
            this.invoerBox.Controls.Add(this.naamLbl);
            this.invoerBox.Controls.Add(this.idTb);
            this.invoerBox.Controls.Add(this.genereerID);
            this.invoerBox.Controls.Add(this.voornaamLbl);
            this.invoerBox.Controls.Add(this.voornaamTb);
            this.invoerBox.Controls.Add(this.geboorteDatumLbl);
            this.invoerBox.Controls.Add(this.idLbl);
            this.invoerBox.Controls.Add(this.naamTb);
            this.invoerBox.Location = new System.Drawing.Point(17, 18);
            this.invoerBox.Name = "invoerBox";
            this.invoerBox.Size = new System.Drawing.Size(760, 217);
            this.invoerBox.TabIndex = 25;
            this.invoerBox.TabStop = false;
            this.invoerBox.Text = "Gegevens";
            // 
            // geboortedatumDtp
            // 
            this.geboortedatumDtp.Location = new System.Drawing.Point(166, 119);
            this.geboortedatumDtp.MaxDate = new System.DateTime(2022, 11, 22, 0, 0, 0, 0);
            this.geboortedatumDtp.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.geboortedatumDtp.Name = "geboortedatumDtp";
            this.geboortedatumDtp.Size = new System.Drawing.Size(250, 27);
            this.geboortedatumDtp.TabIndex = 25;
            this.geboortedatumDtp.Value = new System.DateTime(2022, 11, 22, 0, 0, 0, 0);
            // 
            // naamLbl
            // 
            this.naamLbl.AutoSize = true;
            this.naamLbl.Location = new System.Drawing.Point(114, 38);
            this.naamLbl.Name = "naamLbl";
            this.naamLbl.Size = new System.Drawing.Size(46, 20);
            this.naamLbl.TabIndex = 17;
            this.naamLbl.Text = "naam";
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(165, 157);
            this.idTb.Name = "idTb";
            this.idTb.PlaceholderText = "xxx-xxxxxxx-xx";
            this.idTb.Size = new System.Drawing.Size(245, 27);
            this.idTb.TabIndex = 24;
            this.idTb.TextChanged += new System.EventHandler(this.TextInvoerGewijzigd);
            // 
            // genereerID
            // 
            this.genereerID.Location = new System.Drawing.Point(416, 155);
            this.genereerID.Name = "genereerID";
            this.genereerID.Size = new System.Drawing.Size(105, 29);
            this.genereerID.TabIndex = 15;
            this.genereerID.Text = "genereer ID";
            this.genereerID.UseVisualStyleBackColor = true;
            // 
            // voornaamLbl
            // 
            this.voornaamLbl.AutoSize = true;
            this.voornaamLbl.Location = new System.Drawing.Point(84, 77);
            this.voornaamLbl.Name = "voornaamLbl";
            this.voornaamLbl.Size = new System.Drawing.Size(76, 20);
            this.voornaamLbl.TabIndex = 18;
            this.voornaamLbl.Text = "voornaam";
            // 
            // voornaamTb
            // 
            this.voornaamTb.Location = new System.Drawing.Point(166, 77);
            this.voornaamTb.Name = "voornaamTb";
            this.voornaamTb.Size = new System.Drawing.Size(403, 27);
            this.voornaamTb.TabIndex = 22;
            this.voornaamTb.TextChanged += new System.EventHandler(this.TextInvoerGewijzigd);
            // 
            // geboorteDatumLbl
            // 
            this.geboorteDatumLbl.AutoSize = true;
            this.geboorteDatumLbl.Location = new System.Drawing.Point(46, 119);
            this.geboorteDatumLbl.Name = "geboorteDatumLbl";
            this.geboorteDatumLbl.Size = new System.Drawing.Size(114, 20);
            this.geboorteDatumLbl.TabIndex = 19;
            this.geboorteDatumLbl.Text = "geboortedatum";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(136, 160);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(24, 20);
            this.idLbl.TabIndex = 20;
            this.idLbl.Text = "ID";
            // 
            // naamTb
            // 
            this.naamTb.Location = new System.Drawing.Point(165, 39);
            this.naamTb.Name = "naamTb";
            this.naamTb.Size = new System.Drawing.Size(403, 27);
            this.naamTb.TabIndex = 21;
            this.naamTb.TextChanged += new System.EventHandler(this.TextInvoerGewijzigd);
            // 
            // wisveldenBtn
            // 
            this.wisveldenBtn.Location = new System.Drawing.Point(783, 203);
            this.wisveldenBtn.Name = "wisveldenBtn";
            this.wisveldenBtn.Size = new System.Drawing.Size(152, 32);
            this.wisveldenBtn.TabIndex = 16;
            this.wisveldenBtn.Text = "Wis invoervelden";
            this.wisveldenBtn.UseVisualStyleBackColor = true;
            this.wisveldenBtn.Click += new System.EventHandler(this.wisVeldenBtn_Click);
            // 
            // voegPersoonToeBtn
            // 
            this.voegPersoonToeBtn.Location = new System.Drawing.Point(783, 165);
            this.voegPersoonToeBtn.Name = "voegPersoonToeBtn";
            this.voegPersoonToeBtn.Size = new System.Drawing.Size(152, 32);
            this.voegPersoonToeBtn.TabIndex = 14;
            this.voegPersoonToeBtn.Text = "Voeg record toe";
            this.voegPersoonToeBtn.UseVisualStyleBackColor = true;
            this.voegPersoonToeBtn.Click += new System.EventHandler(this.voegPersoonToeBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.personenDataGrid);
            this.tabPage2.Controls.Add(this.laadPersonenDOM);
            this.tabPage2.Controls.Add(this.laadPersonen);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personen weergeven";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.bewerkenToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gegevensOpslaanToolStripMenuItem,
            this.gegevensInladenToolStripMenuItem,
            this.toolStripSeparator1,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.bestandToolStripMenuItem.Text = "Programma";
            // 
            // gegevensOpslaanToolStripMenuItem
            // 
            this.gegevensOpslaanToolStripMenuItem.Name = "gegevensOpslaanToolStripMenuItem";
            this.gegevensOpslaanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gegevensOpslaanToolStripMenuItem.Text = "Gegevens opslaan";
            this.gegevensOpslaanToolStripMenuItem.Click += new System.EventHandler(this.gegevensOpslaanToolStripMenuItem_Click);
            // 
            // gegevensInladenToolStripMenuItem
            // 
            this.gegevensInladenToolStripMenuItem.Name = "gegevensInladenToolStripMenuItem";
            this.gegevensInladenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gegevensInladenToolStripMenuItem.Text = "Gegevens inladen";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // bewerkenToolStripMenuItem
            // 
            this.bewerkenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voegRecordToeToolStripMenuItem,
            this.verwijderRecordToolStripMenuItem,
            this.wisVeldenToolStripMenuItem});
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            this.bewerkenToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.bewerkenToolStripMenuItem.Text = "Bewerken";
            // 
            // voegRecordToeToolStripMenuItem
            // 
            this.voegRecordToeToolStripMenuItem.Name = "voegRecordToeToolStripMenuItem";
            this.voegRecordToeToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.voegRecordToeToolStripMenuItem.Text = "Voeg record toe";
            this.voegRecordToeToolStripMenuItem.Click += new System.EventHandler(this.voegPersoonToeBtn_Click);
            // 
            // verwijderRecordToolStripMenuItem
            // 
            this.verwijderRecordToolStripMenuItem.Name = "verwijderRecordToolStripMenuItem";
            this.verwijderRecordToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.verwijderRecordToolStripMenuItem.Text = "Verwijder record";
            this.verwijderRecordToolStripMenuItem.Click += new System.EventHandler(this.wisGeselecteerdeBtn_Click);
            // 
            // wisVeldenToolStripMenuItem
            // 
            this.wisVeldenToolStripMenuItem.Name = "wisVeldenToolStripMenuItem";
            this.wisVeldenToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.wisVeldenToolStripMenuItem.Text = "Wis velden";
            this.wisVeldenToolStripMenuItem.Click += new System.EventHandler(this.wisVeldenBtn_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // overToolStripMenuItem
            // 
            this.overToolStripMenuItem.Name = "overToolStripMenuItem";
            this.overToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.overToolStripMenuItem.Text = "Over";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 580);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "XML Basis";
            ((System.ComponentModel.ISupportInitialize)(this.personenDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.invoerBox.ResumeLayout(false);
            this.invoerBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bewaarPersonenBtn;
        private ListBox personenBox;
        private Button laadPersonen;
        private Button laadPersonenDOM;
        private DataGridView personenDataGrid;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox invoerBox;
        private Label naamLbl;
        private TextBox idTb;
        private Button genereerID;
        private Label voornaamLbl;
        private TextBox voornaamTb;
        private Label geboorteDatumLbl;
        private Label idLbl;
        private TextBox naamTb;
        private Button wisveldenBtn;
        private Button voegPersoonToeBtn;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bestandToolStripMenuItem;
        private ToolStripMenuItem bewerkenToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button wisGeselecteerdeBtn;
        private ToolStripMenuItem gegevensOpslaanToolStripMenuItem;
        private ToolStripMenuItem gegevensInladenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem afsluitenToolStripMenuItem;
        private ToolStripMenuItem voegRecordToeToolStripMenuItem;
        private ToolStripMenuItem verwijderRecordToolStripMenuItem;
        private ToolStripMenuItem wisVeldenToolStripMenuItem;
        private ToolStripMenuItem overToolStripMenuItem;
        private DateTimePicker geboortedatumDtp;
    }
}