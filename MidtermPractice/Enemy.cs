using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice
{
    public abstract class Enemy
    {
        public abstract void Move(string direction);
        public abstract void OnCollision();
    }
}
