using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long inputNumber;
                Console.Write("Enter number to convert in word: ");
                inputNumber = long.Parse(Console.ReadLine());
                string outputWord = NumberSpelling.ToSpell(inputNumber);                
                Console.WriteLine(outputWord);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
