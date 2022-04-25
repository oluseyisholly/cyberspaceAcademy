using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opperator.OverLoading
{
    public class Figure
    {
        public int X { get; set; }

        public static Figure operator +(Figure left, Figure right)
        {
            var f = new Figure()
            {
                X = left.X + right.X,
            };
            return f;
        }

    }
}
