using ProjectCS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCS.Entities
{
    public class Weapon
    {
        private static int _count;
        private int _id;
        public Weapon(string name,int bulletCapacity,int bulletCount,FireMode fireMode)
        {
            _count++;
            _id = _count;
            Name = name;
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            FireMode = fireMode;
        }
        public int Id { get => _id; }
        public string Name { get; set; }
        public int BulletCapacity { get; set; }
        public int BulletCount { get; set; }
        public FireMode FireMode { get; set; }
        public void Shoot()
        {
            if(this.FireMode == FireMode.Single)
            {
                if (this.BulletCount > 0)
                {
                    this.BulletCount--;
                    Console.WriteLine("Single shot.");
                }
                else
                    Console.WriteLine("Magazine's empty.");
            }
            else
            {
                Fire();
            }
        }

        public void Fire()
        {
            int counter = 0;
            while (this.BulletCount > 0) 
            {
                counter++;           
            }
            if (counter == 0)
                Console.WriteLine("Magazine's empty.");
            else
                Console.WriteLine($"{counter} shot.");
        }
        public int GetRemainBulletCount()
        {
            return this.BulletCount;
        }
        public void Reload()
        {
            this.BulletCount = this.BulletCapacity;
            Console.WriteLine("Magazine's full.");
        }
        public void ChangeFireMode()
        {
            if (this.FireMode == FireMode.Single)
            {
                this.FireMode = FireMode.Automatic;
                Console.WriteLine("Fire mode changed to automatic.");
            }
            else
            {
                this.FireMode = FireMode.Single;
                Console.WriteLine("Fire mode changed to single shot.");
            }
        }
    }
}
