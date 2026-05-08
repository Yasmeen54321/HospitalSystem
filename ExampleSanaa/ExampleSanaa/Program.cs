using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSanaa
{
    class Program
    {
        public static object MessageBox { get; private set; }

        static void Main(string[] args)
        {
            double x, y;
            x = 6;
            y = --x;
            MessageBox.show("y=y.ToString()");
        }
   
}
