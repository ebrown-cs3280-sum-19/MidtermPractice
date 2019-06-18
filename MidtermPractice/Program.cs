using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = { new Mario(), new Luigi() };

            Console.Write("Pick Character 1-Mario 2-Luigi: ");
            string selection = Console.ReadLine();
            Player player1 = players[int.Parse(selection)-1];
            
            while (true)
            {
                Console.WriteLine("1 to jump, 2 to move, 3 change character");
                int number = int.Parse(Console.ReadLine());
                if (number == 1)
                {
                    player1.Jump();
                }
                else if (number == 2)
                {
                    Console.WriteLine("what direction?: ");
                    player1.Move(Console.ReadLine());
                }
                else if (number == 3)
                {
                    Console.Write("Pick Character 1-Mario 2-Luigi: ");
                    selection = Console.ReadLine();
                    player1 = players[int.Parse(selection) - 1];
                }
                else
                {
                    break;
                }

            }
        }
    }
}
