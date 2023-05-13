using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz_28
{
    class Counter
    {
        public event Action<int> Counted;
        public void Count()
        {
            for (int i = 1; i <= 1000; i++)
            {
                Counted?.Invoke(i);
            }
        }
    }

}
