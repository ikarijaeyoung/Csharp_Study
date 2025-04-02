using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0401_LevelTeset02
{
    public static class Util
    {
        public static void Swap<T>(ref T iLeft, ref T iRight) // 어떠한 자료형이든 대응 가능??
        {
            T temp = iLeft;
            iLeft = iRight;
            iRight = temp;
        }
    }
}
