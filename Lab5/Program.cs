using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineGun gun = new MachineGun(200, 30, "M16");
            if (gun.Type != null && gun.TotalBullets != 0 && gun.Magazine != 0)
            {
                Console.WriteLine("Select action:\n\n1 - Shoot\n2 - Burst Shot\n3 - Reload\n4 - Gun Info\n0 - Exit\n");
            }
            else
            {
                Console.WriteLine("The weapon did not created");
            }

            bool exit = false;
            while (gun.Type != null && gun.Magazine != 0 && !exit)
            {
                byte selection = Convert.ToByte(Console.ReadLine());
                switch (selection)
                {
                    case (byte)Actions.Shoot:
                        gun.Shoot(1);
                        break;
                    case (byte)Actions.BurstShot:
                        gun.Shoot(3);
                        break;
                    case (byte)Actions.Reload:
                        gun.Reload();
                        break;
                    case (byte)Actions.Info:
                        gun.GetInfo();
                        break;
                    case (byte)Actions.Exit:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nSelect one\n\n1 - Shoot\n2 - Burst Shot\n3 - Reload\n4 - Gun Info\n0 - Exit\n");
                        break;
                }
            }
        }
    }
}
