namespace WindowsFormsApp1.GUI
{
    partial class FrmAsakim
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShem = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvAsakim = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsakim)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 41);
            this.button4.TabIndex = 15;
            this.button4.Text = "עדכן";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "צפייה";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "הוסף";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(465, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 11);
            this.label1.TabIndex = 12;
            this.label1.Text = "חיפוש לפי שם עסק";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtShem
            // 
            this.txtShem.Location = new System.Drawing.Point(585, 390);
            this.txtShem.Name = "txtShem";
            this.txtShem.Size = new System.Drawing.Size(149, 20);
            this.txtShem.TabIndex = 11;
            this.txtShem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(585, 350);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(149, 20);
            this.txtKod.TabIndex = 10;
            this.txtKod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "חיפוש לפי קוד";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAsakim
            // 
            this.dgvAsakim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsakim.Location = new System.Drawing.Point(66, 12);
            this.dgvAsakim.MultiSelect = false;
            this.dgvAsakim.Name = "dgvAsakim";
            this.dgvAsakim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsakim.Size = new System.Drawing.Size(668, 313);
            this.dgvAsakim.TabIndex = 8;
            this.dgvAsakim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 41);
            this.button5.TabIndex = 16;
            this.button5.Text = "מחק";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmAsakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShem);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAsakim);
            this.Name = "FrmAsakim";
            this.Text = "FrmAsakim";
            this.Load += new System.EventHandler(this.FrmAsakim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsakim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShem;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvAsakim;
        private System.Windows.Forms.Button button5;
    }
}