using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class MachineGun
    {
        string _type;
        ushort _totalBullets;
        ushort _magazine;
        ushort _bulletLeft;

        public string Type
        {
            get
            {
                return _type;
            }
            private set
            {
                if (!(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)))
                {
                    _type = value;
                }
            }
        }

        public ushort TotalBullets
        {
            get
            {
                return _totalBullets;
            }
            private set
            {
                _totalBullets = value;
            }
        }

        public ushort Magazine
        {
            get
            {
                return _magazine;
            }
            private set
            {
                if (value > 0)
                {
                    _magazine = value;
                }
            }
        }

        public ushort BulletLeft
        {
            get
            {
                return _bulletLeft;
            }
            private set
            {
                _bulletLeft = value;
            }
        }

        public MachineGun(ushort totalBullet, ushort magazinSize, string type)
        {
            if (totalBullet != 0)
            {
                Type = type;
                TotalBullets = totalBullet;
                Magazine = magazinSize;
                BulletLeft = Magazine;
            }
        }

        public void Shoot(ushort bullet)
        {
            if (BulletLeft >= bullet)
            {
                if (TotalBullets >= bullet)
                {
                    TotalBullets -= bullet;
                }
                BulletLeft -= bullet;
                Console.WriteLine(BulletLeft + "/" + Magazine);
            }
            else if (BulletLeft < bullet)
            {
                if (TotalBullets >= BulletLeft)
                {
                    TotalBullets -= BulletLeft;
                }
                BulletLeft = 0;
                Console.WriteLine(BulletLeft + "/" + Magazine);
            }
            else
            {
                Console.WriteLine("No bullet left in the magazine!");
            }
        }
       
        public void Reload()
        {
            int reloaded = Magazine - BulletLeft;
            if (TotalBullets < reloaded)
            {
                reloaded = TotalBullets - BulletLeft;
            }
            else if (TotalBullets == 0)
            {
                Console.WriteLine("No bullet left!");
            }
            else if (BulletLeft == Magazine)
            {
                Console.WriteLine("Magazine is full");
            }
            BulletLeft += (ushort)reloaded;
            Console.WriteLine(BulletLeft + "/" + Magazine);
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nType: {Type}\nTotal bullets: {TotalBullets}\nMagazine size: {Magazine}\nBullet left: {BulletLeft}");
        }
    }
}
