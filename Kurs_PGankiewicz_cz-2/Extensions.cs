using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_PGankiewicz_cz_2
{
    public static class Extensions
    {
        public static bool Empty(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool NotEmpty(this string value)
        {
            // 1. return !Empty(value);
            //2.
            return !value.Empty();
        }
    }
}
