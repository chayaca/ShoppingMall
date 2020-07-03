namespace WindowsFormsApp1.GUI
{
    partial class FrmHascarot
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
            this.dgvHascarot = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHascarot)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHascarot
            // 
            this.dgvHascarot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHascarot.Location = new System.Drawing.Point(28, 28);
            this.dgvHascarot.MultiSelect = false;
            this.dgvHascarot.Name = "dgvHascarot";
            this.dgvHascarot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHascarot.Size = new System.Drawing.Size(474, 340);
            this.dgvHascarot.TabIndex = 0;
            this.dgvHascarot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmHascarot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHascarot);
            this.Name = "FrmHascarot";
            this.Text = "FrmHascarot";
            this.Load += new System.EventHandler(this.FrmHascarot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHascarot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHascarot;
    }
}