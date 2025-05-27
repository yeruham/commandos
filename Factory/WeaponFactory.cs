using System.Collections.Generic;

public class WeaponFactory
{
    private List<Weapon> weapons = new List<Weapon>();

    public Weapon CreatEnemy(string name, string manufacturer, int numBalls)
    {
        Weapon newWeapon = new Weapon(name, manufacturer, numBalls);
        return newWeapon;
    }

    public void AddEnemy(Weapon weapon)
    {
        weapons.Add(weapon);
    }

    public List<Weapon> getEnemies()
    {
        return weapons;
    }

}