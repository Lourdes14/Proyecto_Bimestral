using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BimestralLS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mat = new string[5, 2];
            char OP = 's';
            int op;
            double peso;
            double estatura;
            double IMC;



            while (OP == 's')
            {
                mat[0, 0] = "Nombre";
                mat[1, 0] = "Apellido";
                mat[2, 0] = "Peso en Kg";
                mat[3, 0] = "Estatura";
                mat[4, 0] = "Masa Corporal";

                Console.Clear();
                Console.WriteLine("Qué Desea Hacer:\n 1.Ingresar datos \n 2.Resultado de la persona");
                op = int.Parse(Console.ReadLine());



                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese los siguientes datos: Nombre, Apellido, Peso en Kg, Estatura\n");
                    for (int f = 1; f < 2; f++)
                    {
                        for (int c = 0; c < 4; c++)
                        {
                            Console.Write("Ingrese sus datos [Valor:" + (f) + ", Dato:" + (c + 1) + "]: ");
                            Console.WriteLine();
                            mat[c, f] = Console.ReadLine();
                        }
                    }
                }
                if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nResultado de la persona: ");
                    Console.WriteLine(mat[2, 1] + " ___ " + mat[3, 1]);
                    for (int f = 1; f < 2; f++)
                    {

                        peso = double.Parse(mat[2, f]);
                        estatura = double.Parse(mat[3, f]);
                        double alt = 0;
                        alt = Math.Pow(1.75, 2);
                        Console.WriteLine(" altura " + estatura);
                        IMC = peso / alt;
                        Console.WriteLine(IMC);
                        Console.WriteLine(mat[0, f] + " " + mat[1, f] + " " + mat[2, f] + " " + mat[3, f] + " " + Math.Round(IMC, 2));


                    }
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Desea Regresar al Menú Principal [s/n]");
                OP = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
