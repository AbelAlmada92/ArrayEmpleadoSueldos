using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SueldoDeEmpleados
{
    class Empleados
    {
        private string[] empleado;
        private int[,] sueldos;
        private int[] total;

        public void Cargar()
        {
            empleado = new string[4];
            sueldos = new int[4,3];
            for(int i=0; i<empleado.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                empleado[i] = Console.ReadLine();

                for(int j =0; j<sueldos.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese su sueldo: ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[i,j]=int.Parse(linea);
                }
            }
        }
        public void CalcularSueldos()
        {
            total = new int[4];
            for(int i=0; i < sueldos.GetLength(0); i++)
            {
                int suma =0;
                for(int j=0; j < sueldos.GetLength(1); j++)
                {
                    suma = suma + sueldos[i, j];                   
                }
                total[i] = suma;
            }         
        }
        public void TotalPagado()
        {
            Console.WriteLine("Total de sueldos pagados al empleados: ");
            for(int i = 0; i < total.Length; i++)
            {
                Console.WriteLine(empleado[i] + " - "  + total[i]);
            }
        }
        public void EmpleadoMayorSueldo()
        {
            int may = total[0];
            string nom = empleado[0];

            for(int i=0; i < total.Length; i++)
            {
                if(total[i] > may)
                {
                    may = total[i];
                    nom = empleado[i];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es " +nom+ " Tiene un sueldo de: " +may);
        }
        static void Main(string[] args)
        {
            Empleados em = new Empleados ();
            em.Cargar();
            em.CalcularSueldos();
            em.TotalPagado();
            em.EmpleadoMayorSueldo();
            Console.ReadKey();
        }
    }
}