using System;

namespace L15_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion = 0;
            Console.WriteLine("Bienvenido!!!");
            Console.WriteLine("Ingrese el número de la opción que desea realizar: ");
            Console.WriteLine("");
            Console.WriteLine("1. Determinar si la persona es mayor de edad y dar un promedio de las edades");
            Console.WriteLine("2. Determinar si el estudiante aprobo Introducciñon a la programación y un promedio de las notas");
            Console.WriteLine("3. Salir del programa");
            Console.WriteLine("");
            eleccion = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (eleccion)
            {

                case 1:
                    string[] n = new string[5];
                    int[] e = new int[5];
                    int[] prom = new int[5];
                    double p = 0;
                    string m;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el nombre de la persona");
                        Console.WriteLine("");
                        n[i] = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad que tiene la persona");
                        Console.WriteLine("");
                        e[i] = int.Parse(Console.ReadLine());
                        p += e[i];
                    }
                    p = p / 5;

                    if (e[0] > e[1] && e[0] > e[2] && e[3] > e[3] && e[0] > e[4])
                    {
                        m = n[0];
                    }
                    else if (e[1] > e[0] && e[1] > e[2] && e[1] > e[3] && e[1] > e[4])
                    {
                        m = n[1];
                    }
                    else if (e[2] > e[0] && e[2] > e[1] && e[2] > e[3] && e[2] > e[4])
                    {
                        m = n[2];
                    }
                    else if (e[3] > e[0] && e[3] > e[1] && e[3] > e[2] && e[3] > e[4])
                    {
                        m = n[3];
                    }
                    else
                    {
                        m = n[4];
                    }

                    Console.WriteLine("");
                    Console.WriteLine("La persona más grande de edad es: " + m);
                    Console.WriteLine("");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(n[i] + " tiene: " + e[i] + " años");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("El promedio de todas las edades es: " + p);
                    Console.WriteLine("");
                    break;

                case 2:
                    string[] n2 = new string[5];
                    string[] a = new string[5];
                    double[] ns = new double[5];
                    double pm = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Ingrese el nombre de la persona, por favor");
                        n2[i] = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el apellido de la persona, por favor");
                        Console.WriteLine("");
                        a[i] = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese la nota que obtuvo " + n2[i] + " " + a[i] + " en el curso de Introducción a la Proramación sobre 100");
                        Console.WriteLine("");
                        ns[i] = double.Parse(Console.ReadLine());
                        pm += ns[i];
                    }

                    string m2;

                    if (ns[0] > ns[1] && ns[0] > ns[2] && ns[0] > ns[3] && ns[0] > ns[4])
                    {
                        m2 = n2[0];
                    }
                    else if (ns[1] > ns[0] && ns[1] > ns[2] && ns[1] > ns[3] && ns[1] > ns[4])
                    {
                        m2 = n2[1];
                    }
                    else if (ns[2] > ns[1] && ns[2] > ns[0] && ns[2] > ns[3] && ns[2] > ns[4])
                    {
                        m2 = n2[2];
                    }
                    else if (ns[3] > ns[1] && ns[3] > ns[0] && ns[3] > ns[2] && ns[3] > ns[4])
                    {
                        m2 = n2[3];
                    }
                    else
                    {
                        m2 = n2[4];
                    }

                    string m3;
                    if (ns[0] < ns[1] && ns[0] < ns[2] && ns[0] < ns[3] && ns[0] < ns[4])
                    {
                        m3 = n2[0];
                    }
                    else if (ns[1] < ns[0] && ns[1] < ns[2] && ns[1] < ns[3] && ns[1] < ns[4])
                    {
                        m3 = n2[1];
                    }
                    else if (ns[2] < ns[1] && ns[2] < ns[0] && ns[2] < ns[3] && ns[2] < ns[4])
                    {
                        m3 = n2[2];
                    }
                    else if (ns[3] < ns[1] && ns[3] < ns[0] && ns[3] < ns[2] && ns[3] < ns[4])
                    {
                        m3 = n2[3];
                    }
                    else
                    {
                        m3 = n2[4];
                    }

                    string[] aprovado = new string[5];
                    for (int i = 0; i < 5; i++)
                    {
                        if (ns[i] >= 71)
                        {
                            aprovado[i] = "La persona aprovó";
                        }
                        else
                        {
                            aprovado[i] = "La persona reprobó";
                        }
                    }

                    Console.WriteLine("");
                    Console.WriteLine("La persona que obtuvo mayor nota en el curso es: " + m2);
                    Console.WriteLine("");
                    Console.WriteLine("La persona que obtuvo menor nota en el curso es: " + m3);
                    Console.WriteLine("");
                    pm = pm / 5;
                    Console.WriteLine("");
                    Console.WriteLine("El promedio de las notas ingresadas es de: " + pm);
                    Console.WriteLine("");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(n2[i] + ": " + aprovado[i]);
                    }

                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Debe ingresar una opción entre el número 1 y 3, intente de nyevo por favor");
                    Console.WriteLine("");
                    break;
            }

            Console.ReadKey();
        }
    }
}
