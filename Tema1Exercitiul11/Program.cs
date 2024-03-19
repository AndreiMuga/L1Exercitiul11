using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex11
{
    public class Program
    /* Ex 11
Folosind instructiunea “switch”, scrieti un program care citind de la tastatura un
numar intreg va verifica urmatoarele
“unu” daca numarul citit este 1
“doi” daca numarul citit este 2
“trei” daca numarul citit este 3
“cinci” daca numarul citit este 5
“opt” daca numarul citit este 8
“neidentificat” pentru orice alt caz
     */
    {
        public static void Main(string[] args)
        {
            int numarulNostru;
            Console.WriteLine("Intruduceti un numar intreg din urmatorul sir 1, 2, 3, 5 sau 8: ");
            numarulNostru = int.Parse(Console.ReadLine());
            switch (numarulNostru) 
            {
                case 1:
                    Console.WriteLine("Unu");
                    break;
                case 2: 
                    Console.WriteLine("Doi");
                    break;
                case 3: 
                    Console.WriteLine("Trei");
                    break;
                case 5:
                    Console.WriteLine("Cinci");
                    break;
                case 8:
                    Console.WriteLine("Opt");
                    break;
                default:
                 Console.WriteLine("neidentificat");
                    break;
            }
            
        }
    }
}