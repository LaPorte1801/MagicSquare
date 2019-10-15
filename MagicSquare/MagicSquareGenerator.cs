using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MagicSquare
{
    static class MagicSquareGenerator
    {
        public static List<List<int>> Generate(int size)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < size; i++)
            {
                result.Add(new List<int>());
                for (int j = 0; j < size; j++)
                {
                    result[i].Add(0);
                }
            }

            return result;
        }
    }
}
