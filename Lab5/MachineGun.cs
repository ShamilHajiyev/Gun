using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class MachineGun
    {
        public ushort TotalBulletSize;
        public ushort MagazinSize;
        public ushort BulletLeft;
        public string Type;

        public MachineGun(ushort totalBullet, ushort magazinSize, string type)
        {
            TotalBulletSize = totalBullet;
            MagazinSize = magazinSize;
            Type = type;
            BulletLeft = MagazinSize;
        }

        public string GetInfo()
        {
            return $"Type: {Type}\nTotal bullet size: {TotalBulletSize}\nMagazin size: {MagazinSize}\nBullet left: {BulletLeft}";
        }

        public void Reload()
        {
            int reloaded = MagazinSize - BulletLeft;
            BulletLeft = MagazinSize;
            TotalBulletSize -= (ushort)reloaded;
            Console.WriteLine(BulletLeft);
        }

        public void TripleShoot()
        {
            BulletLeft -= 3;
            TotalBulletSize -= 3;
            Console.WriteLine(BulletLeft);
        }

        public void SingleShoot()
        {
            BulletLeft--;
            TotalBulletSize--;
            Console.WriteLine(BulletLeft);
        }
    }
}
