using System;

namespace TelCo.ColorCoder
{
    public static class ColorManual
    {
        public static void PrintRefManual(IWrite writer)
        {
            int pairnumber = 1;
            for (int i = 0; i < ColorArrays.colorMapMajor.Length; i++)
            {
                for (int j = 0; j < ColorArrays.colorMapMinor.Length; j++)
                {
                    writer.WriteLine("Pair Number:"+pairnumber+" Major"+ColorArrays.colorMapMajor[i]+" Minor"+ColorArrays.colorMapMinor[j]);
                    pairnumber++;
                }
            }
        }
    }

}
