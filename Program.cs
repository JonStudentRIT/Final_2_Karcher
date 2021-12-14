using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //        [destination]
            //[Origin]   Weight
            // -1 is not a moveable path
            int[,] AdjacencyMatrix =
            {
               //          A   B   C   D   E   F   G   H
               /* 0 A*/ { -1,  1,  5, -1, -1, -1, -1, -1 },
               /* 1 B*/ { -1, -1, -1,  1, -1,  7, -1, -1 },
               /* 2 C*/ { -1, -1, -1,  0,  2, -1, -1, -1 },
               /* 3 D*/ { -1,  1,  0, -1, -1, -1, -1, -1 },
               /* 4 E*/ { -1, -1,  2, -1, -1, -1,  2, -1 },
               /* 5 F*/ { -1, -1, -1, -1, -1, -1, -1,  4 },
               /* 6 G*/ { -1, -1, -1, -1,  2,  1, -1, -1 },
               /* 7 H*/ { -1, -1, -1, -1, -1, -1, -1, -1 }
            };
            (int, int)[][] AdjacencyList = new (int, int)[8][];
            /* 0 A*/ AdjacencyList[0] = new (int, int)[] { (1, 1), (2, 5) };
            /* 1 B*/ AdjacencyList[1] = new (int, int)[] { (3, 1), (5, 7) };
            /* 2 C*/ AdjacencyList[2] = new (int, int)[] { (3, 0), (4, 2) };
            /* 3 D*/ AdjacencyList[3] = new (int, int)[] { (1, 1), (2, 0) };
            /* 4 E*/ AdjacencyList[4] = new (int, int)[] { (2, 2), (6, 2) };
            /* 5 F*/ AdjacencyList[5] = new (int, int)[] { (7, 4) };
            /* 6 G*/ AdjacencyList[6] = new (int, int)[] { (4, 2) };
            /* 7 H*/ AdjacencyList[7] = new (int, int)[] {  };
        }
    }
}
