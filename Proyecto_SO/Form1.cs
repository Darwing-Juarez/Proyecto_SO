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
    //HACIENDO PRUEBAS DE GIT
    public partial class Ventana_inicio : Form
    {
        public Ventana_inicio()
        {
            //LLAMA AL FORMULARIO INICIAL, PARA PODER VISUALIZARCE
            InitializeComponent();
        }

        //METODO PARA DESACTIVAR EL BOTON INGRESAR, HASTA QUE 
        //TENGA UN VALOR LA TEXTBOX
        private void Ventana_inicio_Load(object sender, EventArgs e)
        {
            btonIngresarProcesos.Enabled = false;
        }

        //VARIABLE PUBLICA, PARA LLEVAR SU VALOR EL OTRO FORMULARIO
        public int numero;
       
        //METODO PARA COMPROBAR QUE LO QUE SE ESTE INGRESANDO EN LA TEXBOX
        //SEAN UNICAMENTE NUMEROS DEL 1 AL 10
        private void Num_Procesos_TextChanged(object sender, EventArgs e)
        {
            //Condicion para comprobar que solo se ingresen numero del 1 al 10
            if (int.TryParse(Num_Procesos.Text, out numero) && numero >= 1 && numero <= 10)
            {
                //Se activa el boton Ingresar
                btonIngresarProcesos.Enabled = true;
                //Elimina el mensaje de error
                errorProvider1.SetError(Num_Procesos, "");
            }
            else
            {
                //Mensaje de error cjuando el valor es incorrecto
                errorProvider1.SetError(Num_Procesos, "Ingrese un número entre 1 y 10");
                //Se desactiva el boton Ingresar
                btonIngresarProcesos.Enabled = false;
            }
        }

        //METODO DEL BOTON PARA ABRIR EL FORMULARIO DE LA GRAFICA
        private void btonIngresarProcesos_Click(object sender, EventArgs e)
        {
            int[] datos = new int[numero];
            abrirFormulario();
        }
        Ventana_Datos datos1;
        
        //METODO QUE DA LA POSICION DEL FORMULARIO DONDE ESTA LA GRAFICA
        //Y ABRE EL FORMULARIO
        private void abrirFormulario()
        {
            //se crea un objeto del formulario donde esta la grafica
            //para darle sus atributos desde el formulario inicial
            datos1 = new Ventana_Datos(this);
            //ubicacion del formulario
            datos1.Location = new System.Drawing.Point(351, 0);
            //se muestra el formulario
            datos1.ShowDialog();
        }
    }
}
