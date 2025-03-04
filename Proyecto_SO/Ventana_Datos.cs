using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Proyecto_SO
{

    public partial class Ventana_Datos : Form
    {
        //METODO DE OBJETO, PARA PODER SER LLAMADO DESDE OTROS FORMULARIO(CLASES)
        private Ventana_inicio formulario1;
        //INICIA LA EJECUCION DEL FORMULARIO DONDE ESTA LA GRAFICA
        public Ventana_Datos(Ventana_inicio form1)
        {
            InitializeComponent();
            formulario1 = form1;
        }

        //METODO PARA DESACTIVAR LOS BOTONES HASTA QUE SE CUMPLA CIERTA CONDICION
        private void Ventana_Datos_Load(object sender, EventArgs e)
        {
            btonIngresarDatos.Enabled = false;
            btonGrafica.Enabled = false;
        }

        //VARIBALES PARA PODER USARSE EN TODA LA CLASE
        private int Rcpu; //almacena la rafaga del cpu temporal
        private int tiempoLlegada;
        private bool nombreProceso = false;
        private bool datoRcpu = false;
        private bool datoTll = false;
        private string nProcesos;
        
        //METODO QUE COMPRUEBA QUE EN LA PRIMER TEXBOX SE INGRESEN UNICAMENTE LETRAS
        private void boxNombreProceso_TextChanged(object sender, EventArgs e)
        {
            nProcesos = "";
            // Condición para comprobar que solo se ingresen letras
            if (!string.IsNullOrWhiteSpace(boxNombreProceso.Text) && !boxNombreProceso.Text.All(Char.IsLetter) && boxNombreProceso.Text != "")
            {
                //mensaje de error si se ingresa alugn numero
                errorProvider1.SetError(boxNombreProceso, "Solo debe contener letras");
                //varibale para desactivar el bonton ingresar si los datos son incorrectos
                nombreProceso = false;
            }
            else
            {
                nProcesos = boxNombreProceso.Text;
                errorProvider1.SetError(boxNombreProceso, ""); // Eliminar el mensaje de error
                nombreProceso = true; //se activa el bonton
            }
            comprobacionTextBox();
        }
        
        //METODO QUE COMPRUEBA QUE EN LA SEGUNDA TEXBOX SE INGRESEN UNICAMENTE NUMEROS
        private void boxIngreseRcpu_TextChanged(object sender, EventArgs e)
        {
            // Condición para comprobar que solo se ingresen números en Rcpu
            if (!int.TryParse(boxIngreseRcpu.Text, out Rcpu))
            {
                //mensaje de error si los datos son errones
                errorProvider2.SetError(boxIngreseRcpu, "Solo debe contener números");
                datoRcpu = false; //desactiva el boton
            }
            else
            {
                errorProvider2.SetError(boxIngreseRcpu, ""); // Eliminar el mensaje de error
                datoRcpu = true;//activa el boton
            }
            comprobacionTextBox();
        }
        
        //METODO QUE COMPRUEBA QUE EN LA TERCER TEXBOX SE INGRESEN UNICAMENTE NUMEROS
        private void boxIngresarTLl_TextChanged(object sender, EventArgs e)
        {

            // Condición para comprobar que solo se ingresen números en tiempoLlegada
            if (!int.TryParse(boxIngresarTLl.Text, out tiempoLlegada))
            {
                //mensaje de error si los datos son incorrectos
                errorProvider3.SetError(boxIngresarTLl, "Solo debe contener números");
                datoTll = false; //desactiva el boton
            }
            else
            {
                errorProvider3.SetError(boxIngresarTLl, ""); // Eliminar el mensaje de error
                datoTll = true;//activa el boton
            }
            comprobacionTextBox();
        }
        
        //METODO QUE ACTIVA O DESACTIVA EL BOTON INGRESAR, DEPENDIENDO DEL VALOR DE LAS VARIBALES
        //DE LOS METODOS ANTERIORES
        private void comprobacionTextBox()
        {
            if (nombreProceso == true && datoTll == true && datoRcpu == true)
            {
                btonIngresarDatos.Enabled = true; //activa el boton solo si todas las variables son "TRUE"
            }
            else
            {
                btonIngresarDatos.Enabled = false; //desactiva el boton
            }
        }
        
        //Variables publicas para poderse usar en todo el programa
        public int contador = 0;
        //Diccionario para almacenar los datos que se ingresan en la tabla
        public Dictionary<string, (int, int)> datosProceso = new Dictionary<string, (int, int)>();
        public int cantidadProceso = 1;

        //METODO PARA INGRESAR LOS DATOS A LA TABAL DEL FORMULARIO 2(DONDE ESTA LA GRAFICA)
        private void btonIngresarDatos_Click(object sender, EventArgs e)
        {
            //Comprueba que la cantidad de datos que se van a ingresar, no sea mayor al numero que se ingreso en el primer formulario
            if (cantidadProceso <= formulario1.numero)
            {
                //Almacenan los datos de cada texBox
                string nombreProceso = boxNombreProceso.Text;
                int Datorcpu = int.Parse(boxIngreseRcpu.Text); //Convierten los valores string a int
                int Datotll = int.Parse(boxIngresarTLl.Text);
                
                TablaDeDatos.Rows.Add(nProcesos, Rcpu, tiempoLlegada);//Agrega los datos de cada texBox a la Tabla
                // Agrega los datos al diccionario
                datosProceso[nombreProceso] = (Datorcpu, Datotll);

                // Limpia los TextBox 
                boxNombreProceso.Clear();
                boxIngreseRcpu.Clear();
                boxIngresarTLl.Clear();
                
                //Cuando ya se han ingresado la cantidad de valores correctos activa el boton VISUALIZAR
                if (cantidadProceso == formulario1.numero)
                {
                    btonGrafica.Enabled = true;
                }
                cantidadProceso++;
                contador++;
            }
            else
            {
                //Mensajes de error cuando se quiere ingresar mas datos, cuando ya llego a el numero
                boxNombreProceso.Text = "YA SE INGRESARON TODOS LOS DATOS";
                boxIngreseRcpu.Text = "CLICK EN VISUALIZAR PARA CONTINUAR";
                boxIngresarTLl.Clear();
                btonIngresarDatos.Enabled = false; //se desactiva el boton
            }
        }
        private Calculos calculo; //OBJETO DEL TERCER FORMULARIO

        //METOD PARA LE BOTON REGRESAR
        public void btonRegresar_Click(object sender, EventArgs e)
        {
            //Cierra el formulario actual
            this.Close();
            cantidadProceso = 1; //Reinicia el valor de la variable
            TablaDeDatos.Rows.Clear(); //Lmpia la tabla
            if (Application.OpenForms["Calculos"] != null) //Comprueba si el el formulario3 esta abierto
            {
                Application.OpenForms["Calculos"].Close(); //si esta abierto cierra el formulario tres
            }
            if (Application.OpenForms["Ventana_Grafica"] != null)
            {
                Application.OpenForms["Ventana_Grafica"].Close();
            }
        }
       
        
        public Dictionary<string, (int, int)> datosProcesoOrdenados = new Dictionary<string, (int, int)>();
       
        //METODO PARA ORDENAR DE FORMA CORRECTA LOS DATOS
        private void ordenarDatos()
        {
            //ORDENA LOS DATOS
            var datosProcesoOrden = datosProceso
                .OrderBy(item => item.Value.Item2 != 0 ? 1 : 0)
                .ThenBy(item => item.Value.Item1)
                .ThenBy(item => item.Value.Item2)
                .ToDictionary(x => x.Key, x => x.Value);

            // Modifica el resultado para considerar RCPU en caso de empate en TLL
            

            //PARA COMPROBAR SI ORDENA CORRECTAMENTE LOS ELEMENTOS
            foreach (var elemento in datosProcesoOrden)
            {
                Console.WriteLine($"{elemento.Key}: ({elemento.Value.Item1}, {elemento.Value.Item2})");
            }

            datosProcesoOrdenados = datosProcesoOrden;
        }

        //ARRAYS PARA DATOS DE LA GRAFICA
        private string[] datoGraficar;
        private int[] tiempoLLegada;
        private int[] tiempoSalida;
        private int[] tiempoLLegadaInicial;
        private void graficar()
        {
            //TAMAÑO DE ARRAYS
            datoGraficar = new string[formulario1.numero];
            tiempoLLegada = new int[formulario1.numero];
            tiempoSalida = new int[formulario1.numero];
            int prueba = 0;
            //DAMOS LOS VALORES A LOS ARRAYS, SIN MODIFICAR
            foreach (var proceso in datosProcesoOrdenados)
            {
                if (prueba >= formulario1.numero)
                {
                    break; // para salir del foreach
                }
                datoGraficar[prueba] = proceso.Key;
                tiempoLLegada[prueba] = proceso.Value.Item1;
                tiempoSalida[prueba] = proceso.Value.Item2;
                prueba++;
            }
            //ALMACENO LOS VALORES DE LLEGADA INICIALES
            tiempoLLegadaInicial = new int[tiempoLLegada.Length];
            for (int i = 0; i < prueba; i++)
            {
                tiempoLLegadaInicial[i] = tiempoSalida[i];
            }
            //ASIGNAMOS LOS VALORES MODIFICADOS
            for (int i = 0; i < prueba; i++)
            {
                if (i == 0)
                {
                    int temp = 0;
                    temp = tiempoLLegada[i];
                    tiempoLLegada[i] = tiempoSalida[i];
                    tiempoSalida[i] = temp;
                }
                if (i > 0)
                {
                    int temporal = 0;
                    temporal = tiempoLLegada[i];
                    tiempoLLegada[i] = tiempoSalida[i - 1];
                    tiempoSalida[i] = tiempoLLegada[i] + temporal;
                }

            }
            //FOR PARA GRAFICAR LOS VALORES
            for (int i = 0; i < prueba; i++)
            {
                Series nuevaSerie = new Series();
                nuevaSerie.ChartType = SeriesChartType.RangeBar;
                nuevaSerie.Name = datoGraficar[i];
                nuevaSerie.YValuesPerPoint = 2;
                Grafi.Series.Add(nuevaSerie);
                nuevaSerie.Points.AddXY(tiempoLLegadaInicial[i], tiempoLLegada[i], tiempoSalida[i]);
            }
        }
       
        //METODO DEL FUNCIONAMIENTO DEL BOTON "VISUALIZAR"
        private void btonGrafica_Click(object sender, EventArgs e)
        {
            ordenarDatos();
            graficar();
            datosTablaForm3();
        }
        
        
        Calculos Calculo;
        
        //METODO QUE REALIZA EL FUNCIONAMIENTO DEL FORMULARIO 3, DONDE APARECEN UNICAMENTE TABLAS
        //SE HACE EL FUNCIONANMIENTE EN EL FORMULARIO DE LA GRAFICA, Y SOLO SE MANDA A LLAMR EL METODO
        //PARA LLEVAR LOS DATOS DE UN FORMULARIO A OTRO CREE EL OBJETO "objeC"
        private void datosTablaForm3()
        {
            int[] final = new int[formulario1.numero];
            Calculos objeC = new Calculos();
            
            //For para los calculos de la tabla 1 y 2
            for (int i = 0; i < formulario1.numero; i++)
            {
                objeC.Tabla1Control.Rows.Add(datoGraficar[i]);
                objeC.Tabla1Control.Rows.Add(($"{tiempoSalida[i]} - {tiempoLLegadaInicial[i]} = " + (tiempoSalida[i] - tiempoLLegadaInicial[i])));
                objeC.Tabla2Control.Rows.Add(datoGraficar[i]);
                objeC.Tabla2Control.Rows.Add(($"{tiempoLLegada[i]} - {tiempoLLegadaInicial[i]} = " + (tiempoLLegada[i] - tiempoLLegadaInicial[i])));
                final[i] = (tiempoLLegada[i] - tiempoLLegadaInicial[i]);
            }

            //Calculos para la tabla 3
            int suma = final.Sum();
            int contador = final.Length;
            double resultado = (double)suma/contador;
            string tabla = "(" + string.Join(" + ", final) + ") / " + contador + " = " + resultado;
            objeC.Tabla3Control.Rows.Add(tabla);

            objeC.Location = new System.Drawing.Point(0, 278);
            objeC.ShowDialog();

        }

        
    }
}
