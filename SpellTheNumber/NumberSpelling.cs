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

                if ((number / NumberSystem.Quadrillion) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Quadrillion) + " quadrillion ");
                    number %= NumberSystem.Quadrillion;
                }

                if ((number / NumberSystem.Trillion) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Trillion) + " trillion ");
                    number %= NumberSystem.Trillion;
                }

                if ((number / NumberSystem.Billion) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Billion) + " billion ");
                    number %= NumberSystem.Billion;
                }

                if ((number / NumberSystem.Million) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Million) + " million ");
                    number %= NumberSystem.Million;
                }

                if ((number / NumberSystem.Thousand) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Thousand) + " thousand ");
                    number %= NumberSystem.Thousand;
                }

                if ((number / NumberSystem.Hundred) > 0)
                {
                    spellBuilder.Append(ToSpell(number / NumberSystem.Hundred) + " hundred ");
                    number %= NumberSystem.Hundred;
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
