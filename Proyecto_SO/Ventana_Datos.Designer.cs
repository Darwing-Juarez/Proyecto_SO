namespace Proyecto_SO
{
    partial class Ventana_Datos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_Datos));
            this.label2 = new System.Windows.Forms.Label();
            this.TxNombreProc = new System.Windows.Forms.Label();
            this.boxNombreProceso = new System.Windows.Forms.TextBox();
            this.Tx_RaCPU = new System.Windows.Forms.Label();
            this.boxIngreseRcpu = new System.Windows.Forms.TextBox();
            this.Tx_TiempoLl = new System.Windows.Forms.Label();
            this.boxIngresarTLl = new System.Windows.Forms.TextBox();
            this.btonRegresar = new System.Windows.Forms.Button();
            this.btonIngresarDatos = new System.Windows.Forms.Button();
            this.TablaDeDatos = new System.Windows.Forms.DataGridView();
            this.Nombre_Proceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_Llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btonGrafica = new System.Windows.Forms.Button();
            this.Grafi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shortest Job First (SJF)";
            // 
            // TxNombreProc
            // 
            this.TxNombreProc.AutoSize = true;
            this.TxNombreProc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxNombreProc.Location = new System.Drawing.Point(36, 52);
            this.TxNombreProc.Name = "TxNombreProc";
            this.TxNombreProc.Size = new System.Drawing.Size(279, 19);
            this.TxNombreProc.TabIndex = 7;
            this.TxNombreProc.Text = "Ingrese el nombre del proceso:";
            // 
            // boxNombreProceso
            // 
            this.boxNombreProceso.Location = new System.Drawing.Point(40, 74);
            this.boxNombreProceso.Name = "boxNombreProceso";
            this.boxNombreProceso.Size = new System.Drawing.Size(331, 20);
            this.boxNombreProceso.TabIndex = 8;
            this.boxNombreProceso.TextChanged += new System.EventHandler(this.boxNombreProceso_TextChanged);
            // 
            // Tx_RaCPU
            // 
            this.Tx_RaCPU.AutoSize = true;
            this.Tx_RaCPU.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_RaCPU.Location = new System.Drawing.Point(36, 97);
            this.Tx_RaCPU.Name = "Tx_RaCPU";
            this.Tx_RaCPU.Size = new System.Drawing.Size(279, 38);
            this.Tx_RaCPU.TabIndex = 9;
            this.Tx_RaCPU.Text = "Ingrese el numero de Rafaga de\r\nCPU, para el registro:\r\n";
            // 
            // boxIngreseRcpu
            // 
            this.boxIngreseRcpu.Location = new System.Drawing.Point(40, 138);
            this.boxIngreseRcpu.Name = "boxIngreseRcpu";
            this.boxIngreseRcpu.Size = new System.Drawing.Size(331, 20);
            this.boxIngreseRcpu.TabIndex = 10;
            this.boxIngreseRcpu.TextChanged += new System.EventHandler(this.boxIngreseRcpu_TextChanged);
            // 
            // Tx_TiempoLl
            // 
            this.Tx_TiempoLl.AutoSize = true;
            this.Tx_TiempoLl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tx_TiempoLl.Location = new System.Drawing.Point(36, 161);
            this.Tx_TiempoLl.Name = "Tx_TiempoLl";
            this.Tx_TiempoLl.Size = new System.Drawing.Size(279, 38);
            this.Tx_TiempoLl.TabIndex = 11;
            this.Tx_TiempoLl.Text = "Ingrese el Tiempo de Llegada, \r\npara el registro:\r\n";
            // 
            // boxIngresarTLl
            // 
            this.boxIngresarTLl.Location = new System.Drawing.Point(40, 202);
            this.boxIngresarTLl.Name = "boxIngresarTLl";
            this.boxIngresarTLl.Size = new System.Drawing.Size(336, 20);
            this.boxIngresarTLl.TabIndex = 12;
            this.boxIngresarTLl.TextChanged += new System.EventHandler(this.boxIngresarTLl_TextChanged);
            // 
            // btonRegresar
            // 
            this.btonRegresar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btonRegresar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonRegresar.Location = new System.Drawing.Point(282, 407);
            this.btonRegresar.Name = "btonRegresar";
            this.btonRegresar.Size = new System.Drawing.Size(94, 42);
            this.btonRegresar.TabIndex = 13;
            this.btonRegresar.Text = "REGRESAR";
            this.btonRegresar.UseVisualStyleBackColor = false;
            this.btonRegresar.Click += new System.EventHandler(this.btonRegresar_Click);
            // 
            // btonIngresarDatos
            // 
            this.btonIngresarDatos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btonIngresarDatos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonIngresarDatos.Location = new System.Drawing.Point(28, 407);
            this.btonIngresarDatos.Name = "btonIngresarDatos";
            this.btonIngresarDatos.Size = new System.Drawing.Size(94, 42);
            this.btonIngresarDatos.TabIndex = 14;
            this.btonIngresarDatos.Text = "INGRESAR";
            this.btonIngresarDatos.UseVisualStyleBackColor = false;
            this.btonIngresarDatos.Click += new System.EventHandler(this.btonIngresarDatos_Click);
            // 
            // TablaDeDatos
            // 
            this.TablaDeDatos.AllowUserToAddRows = false;
            this.TablaDeDatos.AllowUserToDeleteRows = false;
            this.TablaDeDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Proceso,
            this.R_CPU,
            this.T_Llegada});
            this.TablaDeDatos.Location = new System.Drawing.Point(28, 243);
            this.TablaDeDatos.Name = "TablaDeDatos";
            this.TablaDeDatos.ReadOnly = true;
            this.TablaDeDatos.Size = new System.Drawing.Size(343, 158);
            this.TablaDeDatos.TabIndex = 15;
            // 
            // Nombre_Proceso
            // 
            this.Nombre_Proceso.HeaderText = "Proceso";
            this.Nombre_Proceso.Name = "Nombre_Proceso";
            this.Nombre_Proceso.ReadOnly = true;
            // 
            // R_CPU
            // 
            this.R_CPU.HeaderText = "Rafaga de CPU";
            this.R_CPU.Name = "R_CPU";
            this.R_CPU.ReadOnly = true;
            // 
            // T_Llegada
            // 
            this.T_Llegada.HeaderText = "Tiempo de LLegada";
            this.T_Llegada.Name = "T_Llegada";
            this.T_Llegada.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // btonGrafica
            // 
            this.btonGrafica.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btonGrafica.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonGrafica.Location = new System.Drawing.Point(128, 407);
            this.btonGrafica.Name = "btonGrafica";
            this.btonGrafica.Size = new System.Drawing.Size(112, 42);
            this.btonGrafica.TabIndex = 16;
            this.btonGrafica.Text = "VISUALIZAR";
            this.btonGrafica.UseVisualStyleBackColor = false;
            this.btonGrafica.Click += new System.EventHandler(this.btonGrafica_Click);
            // 
            // Grafi
            // 
            this.Grafi.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.Grafi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafi.Legends.Add(legend1);
            this.Grafi.Location = new System.Drawing.Point(394, 12);
            this.Grafi.Name = "Grafi";
            this.Grafi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.Grafi.Size = new System.Drawing.Size(600, 437);
            this.Grafi.TabIndex = 17;
            this.Grafi.Text = "chart1";
            // 
            // Ventana_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 461);
            this.Controls.Add(this.Grafi);
            this.Controls.Add(this.btonGrafica);
            this.Controls.Add(this.TablaDeDatos);
            this.Controls.Add(this.btonIngresarDatos);
            this.Controls.Add(this.btonRegresar);
            this.Controls.Add(this.boxIngresarTLl);
            this.Controls.Add(this.Tx_TiempoLl);
            this.Controls.Add(this.boxIngreseRcpu);
            this.Controls.Add(this.Tx_RaCPU);
            this.Controls.Add(this.boxNombreProceso);
            this.Controls.Add(this.TxNombreProc);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ventana_Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Grupo 2";
            this.Load += new System.EventHandler(this.Ventana_Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxNombreProc;
        private System.Windows.Forms.TextBox boxNombreProceso;
        private System.Windows.Forms.Label Tx_RaCPU;
        private System.Windows.Forms.TextBox boxIngreseRcpu;
        private System.Windows.Forms.Label Tx_TiempoLl;
        private System.Windows.Forms.TextBox boxIngresarTLl;
        private System.Windows.Forms.Button btonRegresar;
        private System.Windows.Forms.Button btonIngresarDatos;
        private System.Windows.Forms.DataGridView TablaDeDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn T_Llegada;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button btonGrafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafi;
    }
}