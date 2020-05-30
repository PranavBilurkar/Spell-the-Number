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
            long inputNumber;
            Console.Write("Enter number to convert in word: ");
            inputNumber = Convert.ToInt32(Console.ReadLine());
            string outputWord = NumberSpelling.ToSpell(inputNumber);
            Console.WriteLine(outputWord);
            Console.ReadLine();
        }
    }
}
