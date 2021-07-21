using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelCo.ColorCoder
{
    class PrintManual : IWrite
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }
    }

    class PrintManualTest : IWrite
    {
        public int WriteConsoleCall = 0;
        public void WriteLine(string content)
        {
            WriteConsoleCall += 1;
        }
    }
}
