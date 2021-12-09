
namespace Login
{
    partial class Rastrear
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
            this.cmbVista = new System.Windows.Forms.ComboBox();
            this.dtgTabla = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUPF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVista
            // 
            this.cmbVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVista.FormattingEnabled = true;
            this.cmbVista.Items.AddRange(new object[] {
            "General Factura",
            "Personal"});
            this.cmbVista.Location = new System.Drawing.Point(156, 29);
            this.cmbVista.Name = "cmbVista";
            this.cmbVista.Size = new System.Drawing.Size(121, 21);
            this.cmbVista.TabIndex = 0;
            this.cmbVista.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtgTabla
            // 
            this.dtgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTabla.Location = new System.Drawing.Point(21, 56);
            this.dtgTabla.Name = "dtgTabla";
            this.dtgTabla.Size = new System.Drawing.Size(578, 332);
            this.dtgTabla.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Usuario",
            "Cliente",
            "Factura"});
            this.comboBox1.Location = new System.Drawing.Point(613, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Que desea rastrear?";
            // 
            // txtUPF
            // 
            this.txtUPF.Location = new System.Drawing.Point(735, 59);
            this.txtUPF.Name = "txtUPF";
            this.txtUPF.Size = new System.Drawing.Size(152, 20);
            this.txtUPF.TabIndex = 4;
            this.txtUPF.Visible = false;
            this.txtUPF.Click += new System.EventHandler(this.txtUPF_Click);
            this.txtUPF.Enter += new System.EventHandler(this.txtUPF_Enter);
            this.txtUPF.Leave += new System.EventHandler(this.txtUPF_Leave_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(164)))), ((int)(((byte)(245)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(779, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vistas generales:";
            // 
            // Rastrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtgTabla);
            this.Controls.Add(this.cmbVista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rastrear";
            this.Text = "Rastrear";
            this.Load += new System.EventHandler(this.Rastrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVista;
        private System.Windows.Forms.DataGridView dtgTabla;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}