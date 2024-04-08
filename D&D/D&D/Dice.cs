using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_D
{
    internal class Dice
    {
        static public int D100()
        {
            Random random = new Random();
            int dice = random.Next(100);
            return dice;
        }
        static public int D20()
        {
            Random random = new Random();
            return random.Next(20); ;
        }
        static public int D12()
        {
            Random random = new Random();
            return random.Next(12); ;
        }
        static public int D10()
        {
            Random random = new Random();
            return random.Next(10); ;
        }
        static public int D8()
        {
            Random random = new Random();
            return random.Next(8); ;
        }
        static public int D6()
        {
            Random random = new Random();
            return random.Next(6); ;
        }
        static public int D4()
        {
            Random random = new Random();
            return random.Next(4); ;
        }
    }
}
