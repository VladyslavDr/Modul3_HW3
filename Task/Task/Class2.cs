using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Class2
    {
        private int _res;
        public Predicate<int> Calc(Func<int, int, int> func, int x, int y)
        {
            Predicate<int> predicate = Result;
            _res = func.Invoke(x, y);

            return predicate;
        }

        public bool Result(int item)
        {
            if (_res % item == 0)
            {
                return true;
            }

            return false;
        }
    }
}
