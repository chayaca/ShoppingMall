namespace WindowsFormsApp1.GUI
{
    partial class FrmHascara
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
            this.cmbMisEsek = new System.Windows.Forms.ComboBox();
            this.dtpKnisa = new System.Windows.Forms.DateTimePicker();
            this.nudZmanChoze = new System.Windows.Forms.NumericUpDown();
            this.chbhaaracha = new System.Windows.Forms.CheckBox();
            this.cmbOfen = new System.Windows.Forms.ComboBox();
            this.grbAshray = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTokef = new System.Windows.Forms.DateTimePicker();
            this.txtMisAshray = new System.Windows.Forms.TextBox();
            this.grbHoraat = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMisCheshbon = new System.Windows.Forms.TextBox();
            this.txtMisBank = new System.Windows.Forms.TextBox();
            this.txtMisSnif = new System.Windows.Forms.TextBox();
            this.txtMisAsmachta = new System.Windows.Forms.TextBox();
            this.lblMisHascara = new System.Windows.Forms.Label();
            this.lblTaarichBakasha = new System.Windows.Forms.Label();
            this.lblMisChanut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMechir = new System.Windows.Forms.Label();
            this.dgvTashlumim = new System.Windows.Forms.DataGridView();
            this.dgvSherutim = new System.Windows.Forms.DataGridView();
            this.chbsherut = new System.Windows.Forms.CheckBox();
            this.cmbSherutim = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudZmanChoze)).BeginInit();
            this.grbAshray.SuspendLayout();
            this.grbHoraat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTashlumim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherutim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMisEsek
            // 
            this.cmbMisEsek.FormattingEnabled = true;
            this.cmbMisEsek.Location = new System.Drawing.Point(706, 92);
            this.cmbMisEsek.Name = "cmbMisEsek";
            this.cmbMisEsek.Size = new System.Drawing.Size(121, 21);
            this.cmbMisEsek.TabIndex = 3;
            this.cmbMisEsek.SelectedIndexChanged += new System.EventHandler(this.cmbMisEsek_SelectedIndexChanged);
            // 
            // dtpKnisa
            // 
            this.dtpKnisa.Location = new System.Drawing.Point(628, 133);
            this.dtpKnisa.Name = "dtpKnisa";
            this.dtpKnisa.Size = new System.Drawing.Size(200, 20);
            this.dtpKnisa.TabIndex = 4;
            // 
            // nudZmanChoze
            // 
            this.nudZmanChoze.Location = new System.Drawing.Point(707, 165);
            this.nudZmanChoze.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudZmanChoze.Name = "nudZmanChoze";
            this.nudZmanChoze.Size = new System.Drawing.Size(120, 20);
            this.nudZmanChoze.TabIndex = 5;
            this.nudZmanChoze.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // chbhaaracha
            // 
            this.chbhaaracha.AutoSize = true;
            this.chbhaaracha.Location = new System.Drawing.Point(814, 203);
            this.chbhaaracha.Name = "chbhaaracha";
            this.chbhaaracha.Size = new System.Drawing.Size(110, 17);
            this.chbhaaracha.TabIndex = 6;
            this.chbhaaracha.Text = "אופציה להארכה";
            this.chbhaaracha.UseVisualStyleBackColor = true;
            // 
            // cmbOfen
            // 
            this.cmbOfen.FormattingEnabled = true;
            this.cmbOfen.Items.AddRange(new object[] {
            "אשראי",
            "הוראת קבע"});
            this.cmbOfen.Location = new System.Drawing.Point(707, 239);
            this.cmbOfen.Name = "cmbOfen";
            this.cmbOfen.Size = new System.Drawing.Size(121, 21);
            this.cmbOfen.TabIndex = 7;
            this.cmbOfen.SelectedIndexChanged += new System.EventHandler(this.cmbOfen_SelectedIndexChanged);
            // 
            // grbAshray
            // 
            this.grbAshray.Controls.Add(this.label13);
            this.grbAshray.Controls.Add(this.label12);
            this.grbAshray.Controls.Add(this.txtCvv);
            this.grbAshray.Controls.Add(this.label11);
            this.grbAshray.Controls.Add(this.dtpTokef);
            this.grbAshray.Controls.Add(this.txtMisAshray);
            this.grbAshray.Location = new System.Drawing.Point(675, 266);
            this.grbAshray.Name = "grbAshray";
            this.grbAshray.Size = new System.Drawing.Size(245, 87);
            this.grbAshray.TabIndex = 8;
            this.grbAshray.TabStop = false;
            this.grbAshray.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(204, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "cvv";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "תוקף";
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(56, 62);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(100, 20);
            this.txtCvv.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "מספר אשראי";
            // 
            // dtpTokef
            // 
            this.dtpTokef.Location = new System.Drawing.Point(0, 36);
            this.dtpTokef.Name = "dtpTokef";
            this.dtpTokef.Size = new System.Drawing.Size(200, 20);
            this.dtpTokef.TabIndex = 1;
            // 
            // txtMisAshray
            // 
            this.txtMisAshray.Location = new System.Drawing.Point(56, 10);
            this.txtMisAshray.Name = "txtMisAshray";
            this.txtMisAshray.Size = new System.Drawing.Size(100, 20);
            this.txtMisAshray.TabIndex = 0;
            // 
            // grbHoraat
            // 
            this.grbHoraat.Controls.Add(this.label17);
            this.grbHoraat.Controls.Add(this.label16);
            this.grbHoraat.Controls.Add(this.label15);
            this.grbHoraat.Controls.Add(this.label14);
            this.grbHoraat.Controls.Add(this.txtMisCheshbon);
            this.grbHoraat.Controls.Add(this.txtMisBank);
            this.grbHoraat.Controls.Add(this.txtMisSnif);
            this.grbHoraat.Controls.Add(this.txtMisAsmachta);
            this.grbHoraat.Location = new System.Drawing.Point(672, 359);
            this.grbHoraat.Name = "grbHoraat";
            this.grbHoraat.Size = new System.Drawing.Size(245, 111);
            this.grbHoraat.TabIndex = 9;
            this.grbHoraat.TabStop = false;
            this.grbHoraat.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(175, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "מספר חשבון";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(182, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "מספר סניף";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "מספר בנק";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(164, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "מספר אסמכתא";
            // 
            // txtMisCheshbon
            // 
            this.txtMisCheshbon.Location = new System.Drawing.Point(56, 88);
            this.txtMisCheshbon.Name = "txtMisCheshbon";
            this.txtMisCheshbon.Size = new System.Drawing.Size(100, 20);
            this.txtMisCheshbon.TabIndex = 4;
            // 
            // txtMisBank
            // 
            this.txtMisBank.Location = new System.Drawing.Point(56, 36);
            this.txtMisBank.Name = "txtMisBank";
            this.txtMisBank.Size = new System.Drawing.Size(100, 20);
            this.txtMisBank.TabIndex = 3;
            // 
            // txtMisSnif
            // 
            this.txtMisSnif.Location = new System.Drawing.Point(56, 62);
            this.txtMisSnif.Name = "txtMisSnif";
            this.txtMisSnif.Size = new System.Drawing.Size(100, 20);
            this.txtMisSnif.TabIndex = 2;
            // 
            // txtMisAsmachta
            // 
            this.txtMisAsmachta.Location = new System.Drawing.Point(56, 8);
            this.txtMisAsmachta.Name = "txtMisAsmachta";
            this.txtMisAsmachta.Size = new System.Drawing.Size(100, 20);
            this.txtMisAsmachta.TabIndex = 0;
            // 
            // lblMisHascara
            // 
            this.lblMisHascara.AutoSize = true;
            this.lblMisHascara.Location = new System.Drawing.Point(805, 9);
            this.lblMisHascara.Name = "lblMisHascara";
            this.lblMisHascara.Size = new System.Drawing.Size(35, 13);
            this.lblMisHascara.TabIndex = 10;
            this.lblMisHascara.Text = "label1";
            // 
            // lblTaarichBakasha
            // 
            this.lblTaarichBakasha.AutoSize = true;
            this.lblTaarichBakasha.Location = new System.Drawing.Point(805, 37);
            this.lblTaarichBakasha.Name = "lblTaarichBakasha";
            this.lblTaarichBakasha.Size = new System.Drawing.Size(35, 13);
            this.lblTaarichBakasha.TabIndex = 11;
            this.lblTaarichBakasha.Text = "label2";
            // 
            // lblMisChanut
            // 
            this.lblMisChanut.AutoSize = true;
            this.lblMisChanut.Location = new System.Drawing.Point(805, 70);
            this.lblMisChanut.Name = "lblMisChanut";
            this.lblMisChanut.Size = new System.Drawing.Size(35, 13);
            this.lblMisChanut.TabIndex = 12;
            this.lblMisChanut.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(860, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "מספר השכרה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "תאריך בקשה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(856, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "מספר חנות";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(859, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "מספר עסק";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(843, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "תאריך כניסה";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(854, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "משך החוזה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(854, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "אופן תשלום";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblMechir
            // 
            this.lblMechir.AutoSize = true;
            this.lblMechir.Location = new System.Drawing.Point(741, 70);
            this.lblMechir.Name = "lblMechir";
            this.lblMechir.Size = new System.Drawing.Size(35, 13);
            this.lblMechir.TabIndex = 21;
            this.lblMechir.Text = "label3";
            this.lblMechir.Click += new System.EventHandler(this.lblMechir_Click);
            // 
            // dgvTashlumim
            // 
            this.dgvTashlumim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTashlumim.Location = new System.Drawing.Point(12, 51);
            this.dgvTashlumim.MultiSelect = false;
            this.dgvTashlumim.Name = "dgvTashlumim";
            this.dgvTashlumim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTashlumim.Size = new System.Drawing.Size(390, 232);
            this.dgvTashlumim.TabIndex = 22;
            this.dgvTashlumim.Visible = false;
            // 
            // dgvSherutim
            // 
            this.dgvSherutim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSherutim.Location = new System.Drawing.Point(12, 338);
            this.dgvSherutim.MultiSelect = false;
            this.dgvSherutim.Name = "dgvSherutim";
            this.dgvSherutim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSherutim.Size = new System.Drawing.Size(390, 232);
            this.dgvSherutim.TabIndex = 23;
            this.dgvSherutim.Visible = false;
            // 
            // chbsherut
            // 
            this.chbsherut.AutoSize = true;
            this.chbsherut.Location = new System.Drawing.Point(809, 476);
            this.chbsherut.Name = "chbsherut";
            this.chbsherut.Size = new System.Drawing.Size(111, 17);
            this.chbsherut.TabIndex = 24;
            this.chbsherut.Text = "שרותים מיוחדים";
            this.chbsherut.UseVisualStyleBackColor = true;
            this.chbsherut.CheckedChanged += new System.EventHandler(this.chbsherut_CheckedChanged);
            // 
            // cmbSherutim
            // 
            this.cmbSherutim.FormattingEnabled = true;
            this.cmbSherutim.Location = new System.Drawing.Point(719, 499);
            this.cmbSherutim.Name = "cmbSherutim";
            this.cmbSherutim.Size = new System.Drawing.Size(121, 21);
            this.cmbSherutim.TabIndex = 25;
            this.cmbSherutim.Visible = false;
            // 
            // FrmHascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 652);
            this.Controls.Add(this.cmbSherutim);
            this.Controls.Add(this.chbsherut);
            this.Controls.Add(this.dgvSherutim);
            this.Controls.Add(this.dgvTashlumim);
            this.Controls.Add(this.lblMechir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMisChanut);
            this.Controls.Add(this.lblTaarichBakasha);
            this.Controls.Add(this.lblMisHascara);
            this.Controls.Add(this.grbHoraat);
            this.Controls.Add(this.grbAshray);
            this.Controls.Add(this.cmbOfen);
            this.Controls.Add(this.chbhaaracha);
            this.Controls.Add(this.nudZmanChoze);
            this.Controls.Add(this.dtpKnisa);
            this.Controls.Add(this.cmbMisEsek);
            this.Name = "FrmHascara";
            this.Text = "FrmHascara";
            this.Load += new System.EventHandler(this.FrmHascara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudZmanChoze)).EndInit();
            this.grbAshray.ResumeLayout(false);
            this.grbAshray.PerformLayout();
            this.grbHoraat.ResumeLayout(false);
            this.grbHoraat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTashlumim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSherutim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMisEsek;
        private System.Windows.Forms.DateTimePicker dtpKnisa;
        private System.Windows.Forms.NumericUpDown nudZmanChoze;
        private System.Windows.Forms.CheckBox chbhaaracha;
        private System.Windows.Forms.ComboBox cmbOfen;
        private System.Windows.Forms.GroupBox grbAshray;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.DateTimePicker dtpTokef;
        private System.Windows.Forms.TextBox txtMisAshray;
        private System.Windows.Forms.GroupBox grbHoraat;
        private System.Windows.Forms.TextBox txtMisCheshbon;
        private System.Windows.Forms.TextBox txtMisBank;
        private System.Windows.Forms.TextBox txtMisSnif;
        private System.Windows.Forms.TextBox txtMisAsmachta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMisHascara;
        private System.Windows.Forms.Label lblTaarichBakasha;
        private System.Windows.Forms.Label lblMisChanut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMechir;
        private System.Windows.Forms.DataGridView dgvTashlumim;
        private System.Windows.Forms.DataGridView dgvSherutim;
        private System.Windows.Forms.ComboBox cmbSherutim;
        private System.Windows.Forms.CheckBox chbsherut;
    }
}