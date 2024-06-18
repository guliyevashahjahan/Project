using ProjectCS.Entities;
using ProjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusiness
{
    public class WeaponService
    {
        void Add(Weapon weapon)
        {
            WeaponDb.Weapons.Add(weapon);
        }
        Weapon GetById(int id)
        {
            return WeaponDb.Weapons.FirstOrDefault(m => m.Id == id);
        }
        List<Weapon> GetAll()
        {
            return WeaponDb.Weapons;
        }
        void EditCapacity(Weapon weapon)
        {
            Weapon wep = this.GetById(weapon.Id);
            wep.BulletCapacity = weapon.BulletCapacity;
        }
        void EditCount(Weapon weapon)
        {
            Weapon wep = this.GetById(weapon.Id);
            wep.BulletCount = weapon.BulletCount;
        }
        void Delete(Weapon weapon)
        {
            WeaponDb.Weapons.Remove(weapon);
        }

    }
}
