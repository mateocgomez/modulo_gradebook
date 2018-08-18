using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        //Metodo principal, el cual es el punto de entrada a la aplicación

        static void Main(string[] args)
        {
            //Definimos variables de la clase GradeBook el cual se llamara book 
            //Las clases son el todo para construir moldes como variables que van a ser usadas en el desarrollo del programa

            GradeBook book = new GradeBook();

            /* -A traves de esta variable podemos invocar metodos 
               -Mediante este metodo podemos pasar parametros o argumentos anteriormente definidos en el metodo como un numero flotante 
               -Mediante la f podemos pasar variables de doble precision y convertilos a flotantes*/

            book.AddGrade(91);
            book.AddGrade(85.9f);
            book.AddGrade(32.4f);


            /*Creamos una nueva clase la cual se va a llamar GradeStatistics y contendra el metodo computestatistics el cual va a procesar la informacion 
               de las notas y nos va a dar el resultado */

            GradeStatistics stats = book.ComputeStatistcs();
            Console.WriteLine("La nota mas alta es: " + "" +  stats.AverageGrade);
            Console.WriteLine("La nota mas baja es: " + "" + stats.LowestGrade);
            Console.WriteLine("Las notas promedio son: " + "" + stats.AverageGrade);

            //www.github.com/mateocgomez
            //mateocgomez.github.io

        }
    }
}
