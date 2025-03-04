using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SO
{
    public partial class Calculos : Form
    {
        public Calculos()
        {
            InitializeComponent();
        }

        //EN EL FORMULARIO 3 SOLO SE TIENE EL BOTON REGRESAR
        private void btonRegresar_Click(object sender, EventArgs e)
        {
            Ventana_Datos obj = new Ventana_Datos(null);

            //cierra todos los formularios, menos el incial
            this.Close();
            obj.cantidadProceso = 1;
            Tabla1.Rows.Clear();
            Tabla2.Rows.Clear();
            Tabla3.Rows.Clear();
            if (Application.OpenForms["Calculos"] != null)
            {
                Application.OpenForms["Calculos"].Close();
            }
            if (Application.OpenForms["Ventana_Grafica"] != null)
            {
                Application.OpenForms["Ventana_Grafica"].Close();
            }
        }

        private void Tabla3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
