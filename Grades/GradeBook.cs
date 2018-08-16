using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    //Clase descrita llamada gradebook

    class GradeBook
    {

        /*public gradebook es un constructor dentro de la clase para poder crear objetos y trabajar con ellos
         mediante la palabra ctor es un code snippet en c# para crear el constructor, casi siempre tienen el mismo nombre de la clase como codigo limpio */



        public GradeBook()
        {
            //grades es la variable que me asigna un score dentro de la clase
            grades = new List<float>();


        }

        //En un metodo cuando vamos a devolver alguna instancia escribimos el metodo con la instancia que vamos a devolver 
      
            public GradeStatistics ComputeStatistcs()
        {
            return new GradeStatistics(); 
        }

        //AddGrade es una metodo de la clase GradeBook
        //Cuando no queremos devolver nada en el metodo escribimos la palabra void

        public void AddGrade(float grade)
        {
         
            grades.Add(grade);
        }


        //A la variable grades le asignamos el la variable y el tipo de variable pero en el constructor construimos la nueva variable con su tipo de variable

        List<float> grades;
    }
}
