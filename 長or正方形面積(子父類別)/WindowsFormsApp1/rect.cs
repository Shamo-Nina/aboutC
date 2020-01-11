using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class rect : square
    {
        private int b;
        public int bb
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    b = 7;
                }
                else
                {
                    b = value;
                }
            }
        }
        public override int run()
        {
            ans = a * b;
            return ans;
        }

    }
}
