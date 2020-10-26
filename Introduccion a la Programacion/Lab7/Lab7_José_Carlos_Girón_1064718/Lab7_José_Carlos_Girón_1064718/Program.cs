using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_José_Carlos_Girón_1064718
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //NO TOCAR
            Application.EnableVisualStyles(); //Inicializando gráficas
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //Corriendo formulario 1
            //


        }
    }
}
