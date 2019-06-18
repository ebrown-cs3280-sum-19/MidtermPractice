using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice
{
    class Goomba : Enemy
    {
        public override void Move(string direction)
        {
            Console.WriteLine($"Goomba moved {direction}");
        }

        public override void OnCollision()
        {
            Console.WriteLine($"Goomba was collided with");
        }
    }
}
