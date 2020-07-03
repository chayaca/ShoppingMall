namespace WindowsFormsApp1.GUI
{
    partial class FrmArim
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
            this.dgvarim = new System.Windows.Forms.DataGridView();
            this.btnChadash = new System.Windows.Forms.Button();
            this.btnMachak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtShem = new System.Windows.Forms.TextBox();
            this.btnOsef = new System.Windows.Forms.Button();
            this.btnAdcen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvarim
            // 
            this.dgvarim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarim.Location = new System.Drawing.Point(35, 82);
            this.dgvarim.MultiSelect = false;
            this.dgvarim.Name = "dgvarim";
            this.dgvarim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarim.Size = new System.Drawing.Size(318, 273);
            this.dgvarim.TabIndex = 0;
            this.dgvarim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarim_CellContentClick);
            this.dgvarim.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarim_CellDoubleClick);
            // 
            // btnChadash
            // 
            this.btnChadash.Location = new System.Drawing.Point(381, 82);
            this.btnChadash.Name = "btnChadash";
            this.btnChadash.Size = new System.Drawing.Size(75, 23);
            this.btnChadash.TabIndex = 1;
            this.btnChadash.Text = "חדש";
            this.btnChadash.UseVisualStyleBackColor = true;
            this.btnChadash.Click += new System.EventHandler(this.btnChadash_Click);
            // 
            // btnMachak
            // 
            this.btnMachak.Location = new System.Drawing.Point(381, 123);
            this.btnMachak.Name = "btnMachak";
            this.btnMachak.Size = new System.Drawing.Size(75, 23);
            this.btnMachak.TabIndex = 2;
            this.btnMachak.Text = "מחק";
            this.btnMachak.UseVisualStyleBackColor = true;
            this.btnMachak.Click += new System.EventHandler(this.btnMachak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKod);
            this.groupBox1.Controls.Add(this.txtShem);
            this.groupBox1.Controls.Add(this.btnOsef);
            this.groupBox1.Controls.Add(this.btnAdcen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(512, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(54, 25);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(47, 13);
            this.lblKod.TabIndex = 12;
            this.lblKod.Text = "קוד עיר";
            this.lblKod.Click += new System.EventHandler(this.lblKod_Click);
            // 
            // txtShem
            // 
            this.txtShem.Location = new System.Drawing.Point(6, 62);
            this.txtShem.Name = "txtShem";
            this.txtShem.Size = new System.Drawing.Size(100, 20);
            this.txtShem.TabIndex = 11;
            // 
            // btnOsef
            // 
            this.btnOsef.Location = new System.Drawing.Point(6, 231);
            this.btnOsef.Name = "btnOsef";
            this.btnOsef.Size = new System.Drawing.Size(95, 38);
            this.btnOsef.TabIndex = 10;
            this.btnOsef.Text = "הוסף";
            this.btnOsef.UseVisualStyleBackColor = true;
            this.btnOsef.Click += new System.EventHandler(this.btnOsef_Click);
            // 
            // btnAdcen
            // 
            this.btnAdcen.Location = new System.Drawing.Point(6, 185);
            this.btnAdcen.Name = "btnAdcen";
            this.btnAdcen.Size = new System.Drawing.Size(95, 40);
            this.btnAdcen.TabIndex = 9;
            this.btnAdcen.Text = "עדכן";
            this.btnAdcen.UseVisualStyleBackColor = true;
            this.btnAdcen.Click += new System.EventHandler(this.btnAdcen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "שם עיר";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "קוד עיר";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmArim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMachak);
            this.Controls.Add(this.btnChadash);
            this.Controls.Add(this.dgvarim);
            this.Name = "FrmArim";
            this.Text = "FrmArim";
            this.Load += new System.EventHandler(this.FrmArim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvarim;
        private System.Windows.Forms.Button btnChadash;
        private System.Windows.Forms.Button btnMachak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txtShem;
        private System.Windows.Forms.Button btnOsef;
        private System.Windows.Forms.Button btnAdcen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}