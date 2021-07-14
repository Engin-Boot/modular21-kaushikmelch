using System;

namespace TelCo.ColorCoder
{
    class ColorManual
    {
        public static void printManual()
        {
            int pairnumber = 1;
            for (int i = 0; i < ColorArrays.colorMapMajor.Length; i++)
            {
                for (int j = 0; j < ColorArrays.colorMapMinor.Length; j++)
                {
                    Console.WriteLine("Pair Number: {0}  Major{1}  Minor{2}\n", pairnumber, ColorArrays.colorMapMajor[i], ColorArrays.colorMapMinor[j]);
                    pairnumber++;
                }
            }
        }
    }
}
