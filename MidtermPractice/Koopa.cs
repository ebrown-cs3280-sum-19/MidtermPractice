using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice
{
    class Koopa : Enemy
    {
        public override void Move(string direction)
        {
            Console.WriteLine($"Koopa moved {direction}");
        }

        public override void OnCollision()
        {
            Console.WriteLine($"Koopa was collided with");
        }
    }
}
