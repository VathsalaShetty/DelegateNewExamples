using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNewExamples
{
    class Program
    {
        public delegate int DelegateAddMul(int x, int y);

        public int AddMe(int x1 ,int y1)
        {
            return x1 + y1;
        }

        public int MulMe(int x2, int y2)
        {
            return x2 * y2;
        }

        static void Main(string[] args)
        {
            Program prg = new Program();

        }
    }
}
