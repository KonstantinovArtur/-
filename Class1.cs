using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
        internal class SR_menu
        {
            public int maxstrel;
            public int minstrel;


        public int sr()
        {
            ConsoleKeyInfo key;
            key = Console.ReadKey();
            int pos = 1;

            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow && pos != 0)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1;
                }

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }
            return pos;
        }
    }
    
}

