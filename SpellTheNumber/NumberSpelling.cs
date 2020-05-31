using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellTheNumber
{
   public static class NumberSpelling
    {

       public static string ToSpell(this long number)
        {
            System.Text.StringBuilder spellBuilder = new StringBuilder();

            try
            {
                
                #region Negative and zero rule
                if (number == 0) return "Zero";

                if (number < 0)
                {
                    return "Negative value not allowed and should be a whole number";
                }
                #endregion

                //String Builder

                if ((number / NumberSystem.Million) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Million) + " million ");
                    number %= 1000000;
                }

                if ((number / NumberSystem.Thousand) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Thousand) + " thousand ");
                    number %= 1000;
                }

                if ((number / NumberSystem.Hundred) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Hundred) + " hundred ");
                    number %= 100;
                }

                if (number > 0)
                {
                    if (spellBuilder.Length != 0)
                        spellBuilder.Append("and ");

                    var units = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                    var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                    if (number < 20)
                        spellBuilder.Append(units[number]);
                    else
                    {
                        spellBuilder.Append(tens[number / 10]);
                        if ((number % 10) > 0)
                            spellBuilder.Append(" " + units[number % 10]);
                    }
                }


                return spellBuilder.ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
