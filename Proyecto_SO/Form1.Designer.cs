namespace Proyecto_SO
{
    partial class Ventana_inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_Procesos = new System.Windows.Forms.TextBox();
            this.btonIngresarProcesos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese el numero de Procesos \r\nque va a realizar (1-10):\r\n";
            // 
            // Num_Procesos
            // 
            this.Num_Procesos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Procesos.Location = new System.Drawing.Point(12, 108);
            this.Num_Procesos.Name = "Num_Procesos";
            this.Num_Procesos.Size = new System.Drawing.Size(324, 26);
            this.Num_Procesos.TabIndex = 3;
            this.Num_Procesos.TextChanged += new System.EventHandler(this.Num_Procesos_TextChanged);
            // 
            // btonIngresarProcesos
            // 
            this.btonIngresarProcesos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btonIngresarProcesos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonIngresarProcesos.Location = new System.Drawing.Point(239, 196);
            this.btonIngresarProcesos.Name = "btonIngresarProcesos";
            this.btonIngresarProcesos.Size = new System.Drawing.Size(97, 41);
            this.btonIngresarProcesos.TabIndex = 4;
            this.btonIngresarProcesos.Text = "INGRESAR";
            this.btonIngresarProcesos.UseVisualStyleBackColor = false;
            this.btonIngresarProcesos.Click += new System.EventHandler(this.btonIngresarProcesos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shortest Job First (SJF)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ventana_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btonIngresarProcesos);
            this.Controls.Add(this.Num_Procesos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ventana_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "";
            this.Text = "Grupo 2";
            this.Load += new System.EventHandler(this.Ventana_inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Num_Procesos;
        private System.Windows.Forms.Button btonIngresarProcesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

