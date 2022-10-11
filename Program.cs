using System;

namespace actividad1TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar una aplicación que solicite las calificaciones de alumnos de un curso,
            previamente se debe almacenar nombre del curso y turno. Al finalizar se debe informar la nota
            promedio y asociarlo al nombre del curso registrado. Se debe permitir que la cantidad de alumnos por curso sea variable.*/
            
            string nombreCurso = "";
            string turno = "";
            int calificaciones = 0;
            int contador = 0;
            int acumulador = 0;
            string valor = "";
            int cantidad;
            int promedio;

            Console.WriteLine("Ingrese el Nombre del Curso");
            nombreCurso = Console.ReadLine();

            Console.WriteLine("Ingrese el Turno");
            turno = Console.ReadLine();

            Console.WriteLine("Cantidad de Alumnos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (contador = 1; contador <= cantidad; contador++)
            {
                Console.WriteLine("Ingrese las notas de lxs Alumnxs");
                valor = Console.ReadLine();
                calificaciones = Convert.ToInt32(valor);
                acumulador = acumulador + calificaciones;
            }

            Console.Clear();

            promedio = acumulador / cantidad;

            Console.WriteLine("El curso {0} del {1} tiene un promedio de {2}", nombreCurso, turno, promedio);
        }
    }
}
