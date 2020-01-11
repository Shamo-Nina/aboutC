using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class square
    {
        public int a;
        public int ans;        
        public int aa
        {
            get { return a; }
            set
            {
                if(value<=0)
                {
                    a = 4;
                }
                else
                {
                    a = value;
                }
            }
        }

        virtual public int run()
        {
            ans = a * a;
            return ans;
        }


    }
}
