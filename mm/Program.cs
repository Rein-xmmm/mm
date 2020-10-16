using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("Введите число ->");
                int chislo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ваше число-{chislo}");
            }
           
            
            catch (Exception)
            { 
                Console.WriteLine("Эмм -,-) у вас с математикой проблемы? ");
            }

             Console.ReadLine();
        
        }
    }
}
