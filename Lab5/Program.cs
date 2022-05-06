using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineGun m16 = new MachineGun(200, 30, "M16");
            while (true)
            {
                Console.WriteLine("Select action\n1 - Triple Shoot\n2 - Single Shoot\n3 - Reload Shoot\n4 - Information\n");
                byte selection = Convert.ToByte(Console.ReadLine());
                switch (selection)
                {
                    case (byte)Actions.Shoot:
                        m16.TripleShoot();
                        break;
                    case (byte)Actions.SingleShoot:
                        m16.SingleShoot();
                        break;
                    case (byte)Actions.Reload:
                        m16.Reload();
                        break;
                    case (byte)Actions.Info:
                        Console.WriteLine(m16.GetInfo());
                        break;
                    default:
                        Console.WriteLine("Please select a valid action");
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
