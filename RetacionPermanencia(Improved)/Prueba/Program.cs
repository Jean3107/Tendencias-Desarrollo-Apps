﻿using System;
using System.IO;
// Funciona la primera opcion
namespace RetacionPermanencia_Improved_
{
    class Program
    {
        static void Main(string[] args)
        {
            string found = "", option2="";
            int option=0, j, count = 0, count2 = 0, year = 0;
            DateTime currentDate = DateTime.Now;
            string[] eventDate = new string[3];
            string[] fileSplit = new string[10];
            string[] file = File.ReadAllLines($"C:\\JeanAM\\Archivos\\INTEC\\Trim Nom - Ener 2019\\Tendencias\\RetacionPermanencia(Improved)\\Eventos1.txt");

            for (int i = 0; i < file.Length; i++)
            {
                fileSplit = file[i].Split(',');
                for (j = 1; j < fileSplit.Length; j++)
                {
                    found = fileSplit[j - 1];
                    eventDate = fileSplit[3].Split('-');
                    if (found == "Renuncia" || found == "Despido")
                    {
                        year = Convert.ToInt32(eventDate[0]);
                        if (year == currentDate.Year)
                        {
                            count2++;
                        }
                        count++;
                    }
                }
            }
            Console.WriteLine("Departamento gestion del talento humano");
            Console.WriteLine();
            Console.WriteLine("***** Menu *****");
            Console.WriteLine("1.Rotación");
            Console.WriteLine("2.Permanencia");
            Console.WriteLine();
            Console.Write("Eliga el cálculo que desea realizar: ");
            int.TryParse(Console.ReadLine(), out option);
            switch (option)
            {
                case 1:
                    do
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("***** Calcular rotación *****");
                        Console.WriteLine();
                        Console.WriteLine("a: Ultimo año");
                        Console.WriteLine("b: Promedio histórico");
                        Console.WriteLine();
                        Console.Write("Elija una opcion: ");
                        option2 = Console.ReadLine();
                        if (option2 == "a")
                        {
                            Console.WriteLine($"La cantidad de trabajadores que fueron despedidos o renunciaron en el ultimo año fue de: {count2}");
                        }
                        else if (option2 == "b")
                        {
                            //Falta dividir entre en numero total de años de la empresa
                            Console.WriteLine($"La cantidad de trabajadores que fueron despedidos o renunciaron fue de: {count}");
                        }
                    } while (option2 != "a" && option2!="b");
                    
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("***** Calcular permanencia *****");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
/*
string[] newFile = new string[50];
string ID = "", nombre, empleado;
string[] file = File.ReadAllLines($"C:\\JeanAM\\Archivos\\INTEC\\Trim Nom - Ener 2019\\Tendencias\\Kata_1-RotacionPermanencia\\Eventos1.txt");
            for (int i = 0; i<file.Length; i++)
            {
                Console.WriteLine(file[i]);
                newFile = file[i].Split(',');
ID = newFile[0];
                nombre = newFile[1];
                empleado = newFile[2];
                for (int k = 0; k < file.Length; k++)
                {
                    Console.WriteLine("Terminacion" + Environment.NewLine);
                }
            }
            Console.WriteLine();
            Console.WriteLine("El ID del primer empleado es:" + ID);
            //string[] fSplit = file.Split(' ');
            Console.ReadLine();
*/