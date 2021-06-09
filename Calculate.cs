using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance_WPF
{
    public class Calculate : Shape,Cost
    {
        public Calculate(int a, int b):base(a,b)
        {

        }

        public int getArea()
        {
            return height * width;
        }

        public int getCost(int a)
        {
            return a * 30;
        }

    }
}
