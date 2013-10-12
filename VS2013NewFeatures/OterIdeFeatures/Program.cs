using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OterIdeFeatures
{
    class Program
    {
        public static int Row { get; set; }

        static void Main(string[] args)
        {
        }

        private static void Move()
        {
            ++Row;
        }

        private static int GetRow()
        {
            return Row;
        }
    }
}
