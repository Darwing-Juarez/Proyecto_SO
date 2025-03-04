using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SO
{
    internal class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread] /// subproceso unico, evita problemas de concurrencia
        static void Main()
        {
            Application.EnableVisualStyles(); //para poder ver los formulario
            Application.SetCompatibleTextRenderingDefault(false); //para que sea compatible con varios equipos

            Ventana_inicio inicio = new Ventana_inicio();
            inicio.Location = new System.Drawing.Point(0, 0); //Posicion de el formulario Inicial
            Application.Run(new Ventana_inicio()); // Inicio del programa

        }
    }
}
