using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_de_julio_del_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=0;
            string cadena1;


            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Introduce una cadena de texto");
                cadena1 = Console.ReadLine();
                if (string.IsNullOrEmpty(cadena1))
                {
                    Console.WriteLine("la cedena esta vacia");
                    i--;
                }
            }
            
            Console.WriteLine("Intorduce numero");

            for (int i = 0;i < 1;i++) { 

            try
            {
                num1 = int.Parse(Console.ReadLine());
                
            }
            catch  (Exception e)
            {
                Console.WriteLine(e.Message);
                i--;
            }
            }
           
            if (num1 > 5)
            {
                Console.WriteLine("El numero es mayor que 5");
            }
            
            Console.ReadKey();         
        }
    }
}
