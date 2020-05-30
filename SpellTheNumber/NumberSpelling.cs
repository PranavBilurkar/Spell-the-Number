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

            return builder.ToString();
        }
    }
}
