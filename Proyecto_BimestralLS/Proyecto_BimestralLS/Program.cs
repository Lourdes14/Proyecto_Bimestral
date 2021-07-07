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
            double IMC;
            double x = 1;


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
                    Console.WriteLine("Ingrese los siguientes datos: Nombre, Apellido, Peso en Lbs, Estatura\n");
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
                    for (int f = 1; f < 2; f++)
                    {

                        double altura = double.Parse(mat[3, f]), pes = double.Parse(mat[2, f]);
                        pes = pes / 2.2;
                        IMC = pes / (altura * altura);
                        Console.WriteLine(mat[0, f] + " " + mat[1, f] + " " + mat[2, f] + " " + mat[3, f] + " " + Math.Round(IMC, 2));
                        Console.WriteLine("Usted es: \n 1.Adulto \n 2.niño, niña o adolescente ");
                        op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            x = IMC + 0;
                            Console.Clear();
                            if (x < 18.5)
                            {
                                Console.WriteLine("categoría: bajo de peso ");
                            }
                            if (x > 18.5)
                            {
                                if (x < 24.9)
                                {
                                    Console.WriteLine("categoría: Normal ");
                                }
                            }
                            if (x > 25)
                            {
                                if (x < 29.9)
                                {
                                    Console.WriteLine("categoría: Sobrepeso ");
                                }
                            }
                            if (x > 30)
                            {
                                Console.WriteLine("categoría: Obeso ");
                            }
                        }
                        if (op == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("No es posible categorizar su IMC porque los rangos saludables cambian cada mes para cada sexo y estatura. ");
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
}
