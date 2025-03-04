using System.Windows.Forms;

namespace Proyecto_SO
{
    partial class Calculos
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
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculos));
            this.label2 = new System.Windows.Forms.Label();
            this.Tabla2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabla3 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabla1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btonRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shortest Job First (SJF)";
            // 
            // Tabla2
            // 
            this.Tabla2.AllowUserToAddRows = false;
            this.Tabla2.AllowUserToDeleteRows = false;
            this.Tabla2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.Tabla2.Location = new System.Drawing.Point(123, 31);
            this.Tabla2.Name = "Tabla2";
            this.Tabla2.ReadOnly = true;
            this.Tabla2.RowHeadersVisible = false;
            this.Tabla2.Size = new System.Drawing.Size(104, 261);
            this.Tabla2.TabIndex = 10;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tiempo de Espera";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Tabla3
            // 
            this.Tabla3.AllowUserToAddRows = false;
            this.Tabla3.AllowUserToDeleteRows = false;
            this.Tabla3.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.Tabla3.Location = new System.Drawing.Point(233, 31);
            this.Tabla3.Name = "Tabla3";
            this.Tabla3.ReadOnly = true;
            this.Tabla3.RowHeadersVisible = false;
            this.Tabla3.Size = new System.Drawing.Size(148, 67);
            this.Tabla3.TabIndex = 11;
            this.Tabla3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla3_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TiemProEspera";
            this.Column3.MinimumWidth = 45;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 145;
            // 
            // Tabla1
            // 
            this.Tabla1.AllowUserToAddRows = false;
            this.Tabla1.AllowUserToDeleteRows = false;
            this.Tabla1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.Tabla1.Location = new System.Drawing.Point(13, 31);
            this.Tabla1.Name = "Tabla1";
            this.Tabla1.ReadOnly = true;
            this.Tabla1.RowHeadersVisible = false;
            this.Tabla1.Size = new System.Drawing.Size(104, 261);
            this.Tabla1.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tiempo del Sistema";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btonRegresar
            // 
            this.btonRegresar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btonRegresar.Location = new System.Drawing.Point(277, 245);
            this.btonRegresar.Name = "btonRegresar";
            this.btonRegresar.Size = new System.Drawing.Size(104, 47);
            this.btonRegresar.TabIndex = 13;
            this.btonRegresar.Text = "REGRESAR";
            this.btonRegresar.UseVisualStyleBackColor = false;
            this.btonRegresar.Click += new System.EventHandler(this.btonRegresar_Click);
            // 
            // Calculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 304);
            this.Controls.Add(this.btonRegresar);
            this.Controls.Add(this.Tabla1);
            this.Controls.Add(this.Tabla3);
            this.Controls.Add(this.Tabla2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Grupo 2";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public DataGridView Tabla1Control
        {
            get { return Tabla1; }
        }
        public DataGridView Tabla2Control
        {
            get { return Tabla2; }
        }
        public DataGridView Tabla3Control
        {
            get { return Tabla3; }
        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView Tabla2;
        public System.Windows.Forms.DataGridView Tabla3;
        public System.Windows.Forms.DataGridView Tabla1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Button btonRegresar;
        private DataGridViewTextBoxColumn Column3;
    }
}