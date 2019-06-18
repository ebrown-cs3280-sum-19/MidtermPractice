using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice
{
    class Mario : Player
    {
        public override void Jump()
        {
            Console.WriteLine($"Mario jumped");
        }

        public override void Move(string direction)
        {
            Console.WriteLine($"Mario moved {direction}");
        }
    }
}
