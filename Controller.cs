using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaDeArmas.NewFolder1;

namespace TiendaDeArmas
{
    internal class Controller
    {
        public void Execute()
        {
            //stock
            Armas[] ArmasArray = new Armas[2];
            ArmasArray[0] = new ArmasInfo("Pistola", 100, 10, 1, 10, "Balas");
            ArmasArray[1] = new ArmasInfo("Arco", 40, 5, 5, 1, "Flecas");
            Armas[] ArmasMeleeArray = new Armas[1];
            ArmasMeleeArray[0] = new ArmasInfo("Espada", 150, 25, 5, 0, "");

            //inventario
            List<Armas> inventario = new List<Armas>();

            //Interfas
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Escoge una opción");
                Console.WriteLine("1. Distancia");
                Console.WriteLine("2. Melee");
                Console.WriteLine("3. Ver inventario");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Que arma a distancia va comprar: ");
                        for (int i = 0; i < ArmasArray.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ArmasArray[i].Name} tiene un valor de {ArmasArray[i].PrecioArma()}, " +
                                $"ocasiona {ArmasArray[i].DañoArma()} cada {ArmasArray[i].VelocidadAtaque()} " +
                                $"segundos y el costo de las {ArmasArray[i].NameArmo} es {ArmasArray[i].Munición()}");
                        }
                        int election = int.Parse(Console.ReadLine());
                        switch (election)
                        {
                            case 1:
                                inventario.Add(ArmasArray[0]);
                                break;
                            case 2:
                                inventario.Add(ArmasArray[1]);
                                break;
                            default:
                                Console.WriteLine("Opción invalida");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Que arma melee comprará??");
                        for (int i = 0; i < ArmasMeleeArray.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {ArmasMeleeArray[i].Name} tiene un valor de {ArmasMeleeArray[i].PrecioArma()}, " +
                                $"ocasiona {ArmasMeleeArray[i].DañoArma()} cada {ArmasMeleeArray[i].VelocidadAtaque()} segundos");
                        }
                        int election2 = int.Parse(Console.ReadLine());
                        switch (election2)
                        {
                            case 1:
                                inventario.Add(ArmasMeleeArray[0]);
                                break;
                            default:
                                Console.WriteLine("Opción invalida");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Las armas en tu inventario son: ");
                        foreach(var Armas in inventario)
                        {
                            Console.WriteLine(Armas.Name);
                        }
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                Console.ReadLine();
                bool validOption = false;
                while (!validOption)
                {
                    Console.WriteLine("Elige una opción");
                    Console.WriteLine("1. Volver a comprar");
                    Console.WriteLine("2. Salir");
                    string optionExit = Console.ReadLine();
                    switch (optionExit)
                    {
                        case "1":
                            validOption = true;
                            break;
                        case "2":
                            continueFlag = false;
                            validOption = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }
                }

            }

        }
    }
}
