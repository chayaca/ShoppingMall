namespace WindowsFormsApp1.GUI
{
    partial class FrmChanuyot
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
            System.Windows.Forms.Button button5;
            this.dgvChanuyot = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.chbMechir = new System.Windows.Forms.CheckBox();
            this.chbShetach = new System.Windows.Forms.CheckBox();
            this.chbMachsan = new System.Windows.Forms.CheckBox();
            this.chbSug = new System.Windows.Forms.CheckBox();
            this.txtMechir = new System.Windows.Forms.TextBox();
            this.txtShetach = new System.Windows.Forms.TextBox();
            this.cmbSug = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanuyot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(713, 12);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "סינון";
            button5.UseVisualStyleBackColor = true;
            button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvChanuyot
            // 
            this.dgvChanuyot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChanuyot.Location = new System.Drawing.Point(12, 12);
            this.dgvChanuyot.MultiSelect = false;
            this.dgvChanuyot.Name = "dgvChanuyot";
            this.dgvChanuyot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChanuyot.Size = new System.Drawing.Size(448, 342);
            this.dgvChanuyot.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "חדש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "עדכון";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "מחק";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "צפייה";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chbMechir
            // 
            this.chbMechir.AutoSize = true;
            this.chbMechir.Location = new System.Drawing.Point(192, 9);
            this.chbMechir.Name = "chbMechir";
            this.chbMechir.Size = new System.Drawing.Size(99, 17);
            this.chbMechir.TabIndex = 6;
            this.chbMechir.Text = "מחיר מקסימלי";
            this.chbMechir.UseVisualStyleBackColor = true;
            this.chbMechir.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbShetach
            // 
            this.chbShetach.AutoSize = true;
            this.chbShetach.Location = new System.Drawing.Point(192, 41);
            this.chbShetach.Name = "chbShetach";
            this.chbShetach.Size = new System.Drawing.Size(93, 17);
            this.chbShetach.TabIndex = 7;
            this.chbShetach.Text = "שטח מינימלי";
            this.chbShetach.UseVisualStyleBackColor = true;
            this.chbShetach.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chbMachsan
            // 
            this.chbMachsan.AutoSize = true;
            this.chbMachsan.Location = new System.Drawing.Point(192, 73);
            this.chbMachsan.Name = "chbMachsan";
            this.chbMachsan.Size = new System.Drawing.Size(52, 17);
            this.chbMachsan.TabIndex = 8;
            this.chbMachsan.Text = "מחסן";
            this.chbMachsan.UseVisualStyleBackColor = true;
            // 
            // chbSug
            // 
            this.chbSug.AutoSize = true;
            this.chbSug.Location = new System.Drawing.Point(192, 108);
            this.chbSug.Name = "chbSug";
            this.chbSug.Size = new System.Drawing.Size(71, 17);
            this.chbSug.TabIndex = 9;
            this.chbSug.Text = "סוג חנות";
            this.chbSug.UseVisualStyleBackColor = true;
            this.chbSug.CheckedChanged += new System.EventHandler(this.chbSug_CheckedChanged);
            // 
            // txtMechir
            // 
            this.txtMechir.Location = new System.Drawing.Point(41, 7);
            this.txtMechir.Name = "txtMechir";
            this.txtMechir.Size = new System.Drawing.Size(100, 20);
            this.txtMechir.TabIndex = 10;
            this.txtMechir.Visible = false;
            this.txtMechir.TextChanged += new System.EventHandler(this.txtMechir_TextChanged);
            // 
            // txtShetach
            // 
            this.txtShetach.Location = new System.Drawing.Point(41, 39);
            this.txtShetach.Name = "txtShetach";
            this.txtShetach.Size = new System.Drawing.Size(100, 20);
            this.txtShetach.TabIndex = 11;
            this.txtShetach.Visible = false;
            this.txtShetach.TextChanged += new System.EventHandler(this.txtShetach_TextChanged);
            // 
            // cmbSug
            // 
            this.cmbSug.FormattingEnabled = true;
            this.cmbSug.Items.AddRange(new object[] {
            "רגיל",
            "דוכן"});
            this.cmbSug.Location = new System.Drawing.Point(41, 108);
            this.cmbSug.Name = "cmbSug";
            this.cmbSug.Size = new System.Drawing.Size(121, 21);
            this.cmbSug.TabIndex = 12;
            this.cmbSug.UseWaitCursor = true;
            this.cmbSug.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.chbMechir);
            this.groupBox1.Controls.Add(this.cmbSug);
            this.groupBox1.Controls.Add(this.txtMechir);
            this.groupBox1.Controls.Add(this.chbSug);
            this.groupBox1.Controls.Add(this.txtShetach);
            this.groupBox1.Controls.Add(this.chbMachsan);
            this.groupBox1.Controls.Add(this.chbShetach);
            this.groupBox1.Location = new System.Drawing.Point(491, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 183);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 154);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "בצע חפוש";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(611, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "השכרה חדשה";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // FrmChanuyot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvChanuyot);
            this.Name = "FrmChanuyot";
            this.Text = "FrmChanuyot";
            this.Load += new System.EventHandler(this.FrmChanuyot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChanuyot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChanuyot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chbMechir;
        private System.Windows.Forms.CheckBox chbShetach;
        private System.Windows.Forms.CheckBox chbMachsan;
        private System.Windows.Forms.CheckBox chbSug;
        private System.Windows.Forms.TextBox txtMechir;
        private System.Windows.Forms.TextBox txtShetach;
        private System.Windows.Forms.ComboBox cmbSug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
    }
}