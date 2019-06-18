using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice
{
    public class Luigi : Player
    {
        public override void Jump()
        {
            Console.WriteLine($"Luigi jumped");
        }

        public override void Move(string direction)
        {
            Console.WriteLine($"Luigi moved {direction}");
        }
    }
}
