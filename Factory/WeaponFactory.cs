using System.Collections.Generic;

public class WeaponFactory
{
    public List<Weapon> weapons = new List<Weapon>();

    public Weapon CreatWeapon(string name, string manufacturer, int numBalls)
    {
        Weapon newWeapon = new Weapon(name, manufacturer, numBalls);
        return newWeapon;
    }

    public void AddWeapon(Weapon weapon)
    {
        weapons.Add(weapon);
    }

    public List<Weapon> getWeaponss()
    {
        return weapons;
    }

}