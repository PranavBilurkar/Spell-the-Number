using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk
{
   public static class NumberSpelling
    {
      
        public static string ToSpell(this long value)
        {
            
            #region Negative and zero rule
            if (value == 0) return "zero";

            if (value < 0)
            {
                return "negative value not allowed and should be whole number";
            } 
            #endregion

            //String Builder
            System.Text.StringBuilder builder = new StringBuilder();

            int unit = 0;

            if (value >= NumberSystem.Quadrillion)
            {
                unit = (int)(value / NumberSystem.Quadrillion);
                value -= unit * NumberSystem.Quadrillion;

                builder.AppendFormat("{0}{1} Quadrillion", builder.Length > 0 ? " " : string.Empty, ToSpell(unit));
            }

            if (value >= NumberSystem.Trillion)
            {
                unit = (int)(value / NumberSystem.Trillion);
                value -= unit * NumberSystem.Trillion;

                builder.AppendFormat("{0}{1} Trillion", builder.Length > 0 ? " " : string.Empty, ToSpell(unit));
            }

            if (value >= NumberSystem.Billion)
            {
                unit = (int)(value / NumberSystem.Billion);
                value -= unit * NumberSystem.Billion;

                builder.AppendFormat("{0}{1} Billion", builder.Length > 0 ? " " : string.Empty, ToSpell(unit));
            }

            if (value >= NumberSystem.Million)
            {
                unit = (int)(value / NumberSystem.Million);
                value -= unit * NumberSystem.Million;

                builder.AppendFormat("{0}{1} Million", builder.Length > 0 ? " " : string.Empty, ToSpell(unit));
            }

            if (value >= NumberSystem.Thousand)
            {
                unit = (int)(value / NumberSystem.Thousand);
                value -= unit * NumberSystem.Thousand;

                builder.AppendFormat("{0}{1} Thousand", builder.Length > 0 ? " " : string.Empty, ToSpell(unit));
            }

            if (value >= NumberSystem.Hundred)
            {
                unit = (int)(value / NumberSystem.Hundred);
                value -= unit * NumberSystem.Hundred;

                builder.AppendFormat("{0}{1} Hundred", builder.Length > 0 ? " " : string.Empty, ToSpell(unit));
            }

            if (value >= 90)
            {
                value -= 90;

                builder.AppendFormat("{0}ninety", builder.Length > 0 ? " " : string.Empty);
            }

            if (value >= 80)
            {
                value -= 80;

                builder.AppendFormat("{0}eighty", builder.Length > 0 ? " " : string.Empty);
            }

            if (value >= 70)
            {
                value -= 70;

                builder.AppendFormat("{0}seventy", builder.Length > 0 ? " " : string.Empty);
            }

            if (value >= 60)
            {
                value -= 60;

                builder.AppendFormat("{0}sixty", builder.Length > 0 ? " " : string.Empty);
            }

            if (value >= 50)
            {
                value -= 50;

                builder.AppendFormat("{0}fifty", builder.Length > 0 ? " " : string.Empty);
            }

            if (value >= 40)
            {
                value -= 40;

                builder.AppendFormat("{0}forty", builder.Length > 0 ? " " : string.Empty);
            }

            if (value >= 30)
            {
                value -= 30;

                builder.AppendFormat("{0}thirty", builder.Length > 0 ? " " : string.Empty);
            }

            if (value >= 20)
            {
                value -= 20;

                builder.AppendFormat("{0}twenty", builder.Length > 0 ? " " : string.Empty);
            }

            return builder.ToString();
        }
    }
}
