using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    abstract class Weapon
    {
        public abstract void SingleShoot();
        public abstract void Shoot();
        public abstract void Reload();
        public abstract void GetInfo();
    }
}
