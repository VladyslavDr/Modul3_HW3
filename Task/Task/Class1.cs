using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Class1
    {
        public Action<bool> Action => Program.Show;
        public int Pow(int x, int y) => x * y;
    }
}
