using System;

namespace actividad2TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un sistema para realizar una encuesta para determinar estudiantes de colegios
            públicos y privados. Al finalizar el sistema debe determinar cantidad total de alumnos
            encuestados, cantidad y porcentaje para asistentes a colegios privados y públicos.*/
            
            int publico = 0, privado = 0;
            int cantidadAlumnos = 0;
            string colegio = "P";
            float porcentajePublico = 0f;
            float porcentajePrivado = 0f;

            Console.WriteLine("Encuesta para Alumnxs de Colegios Públicos y Privados");

            while (colegio == "P" || colegio == "p")
            {
                Console.WriteLine("Ingrese 'P' si asiste a un colegio Público e Ingrese 'p' si asiste a un colegio privado, Ingrese 'x' salir.");
                colegio = Console.ReadLine();
                Console.Clear();

                if (colegio == "P")
                {
                    cantidadAlumnos = cantidadAlumnos + 1;
                    publico = publico + 1;
                }

                if (colegio == "p")
                {
                    cantidadAlumnos = cantidadAlumnos + 1;
                    privado = privado + 1;
                }

                if (colegio == "X" || colegio == "x")
                {
                    Console.WriteLine("Saliendo del sistema ....");
                    Console.ReadKey();
                    colegio = "salir";
                }

                else if (colegio == "salir")
                {
                    Console.WriteLine("Debe ingresar una opcion validad: 'P', 'p', 'X'");
                    Console.WriteLine("Ingrese 'P' para alumno publico; ingrese 'p' para privado, 'X' salir");
                    colegio = Console.ReadLine();
                }
            }

            Console.Clear();

            porcentajePrivado = (privado * 100) / cantidadAlumnos;
            porcentajePublico = (publico * 100) / cantidadAlumnos;

            Console.WriteLine("Encuesta para Alumnxs de Colegios Públicos y Privados");

            Console.WriteLine("Cantidad de Alumnos: {0}", cantidadAlumnos);
            
            Console.WriteLine("Cantidad de Privados: {0}", privado);
            
            Console.WriteLine("Cantidad de Publicos: {0}", publico);
            
            Console.WriteLine("Porcentaje de Publicos: % {0}", porcentajePublico);
            
            Console.WriteLine("Porcentaje de Privados: % {0}", porcentajePrivado);
        }
    }
}
