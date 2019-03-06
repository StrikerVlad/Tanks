using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanks;

namespace TankFights
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tank> t34 = new List<Tank>();
            List<Tank> panteras = new List<Tank>();
            Tank winner = new Tank("");
            int j = 1;

            for (int i = 0; i < 5; i++)
            {
                t34.Add(new Tank("T-34"));
                panteras.Add(new Tank("Pantera"));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Бой {0}", j++);
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    if (t34[i] != null || panteras[i] != null)
                    {
                        Console.WriteLine(t34[i].getProperties());
                        Console.WriteLine(panteras[i].getProperties());
                        try
                        {
                            winner = t34[i] * panteras[i];
                            if (winner != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Победил");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(winner.getProperties());
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ничья");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Танк не существует!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
