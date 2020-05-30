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

            return builder.ToString();
        }
    }
}
