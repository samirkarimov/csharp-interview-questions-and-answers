using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWith97Questions
{
    static class ForJaggedArray
    {
        // normal array :

        public static int[] arr01 = new int[5] { 1, 2, 3, 4, 5 };

        // jagged array :

        public static int[][] arr02 = new int[3][] {

            new int[]{1,2,3,4,5},
            new int[]{6,7,8,9},
            new int[]{10,11,12,13}

        };

        // jagged array in bu cur yazilisi da var :

        public static int[][,] arr03 = new int[4][,]
        {
            new int[,] { {1,2,3 }, {4,5,6 } },
            new int[,] {{7,8,9},{10,11,12 } },
            new int[,]{{13,14,15}},
            new int[,]{{16,17,18,19,20} }
        };
        public static void CountOfJaggedArrays()
        {
            Console.WriteLine("Array i teskil eden array ler :");
            Console.WriteLine("arr02[0][1] : {0}",arr02[0][1]);
            Console.WriteLine("arr02[1][2] : {0}",arr02[1][2]);
            Console.WriteLine("arr02[2][3] : {0}",arr02[2][3]);
            Console.WriteLine("arr03[1][1, 2] : {0} ", arr03[1][1, 2]);
        }
    }
}
