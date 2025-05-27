using System.Collections.Generic;
using System.Xml.Linq;

public class Game
{
    private WeaponFactory wepones = new WeaponFactory();
    private CommandoFactory commandoFighters = new CommandoFactory();
    private EnemyFactory enemies = new EnemyFactory();

    public void CreatAndAddEnemy(string name)
    {
        Enemy enemy = enemies.CreatEnemy(name);
        enemies.AddEnemy(enemy);
    }

    public void CreatAndAddCommand(string name, string codeName, string type)
    {
        Commando commando = commandoFighters.CreatCommando(name, codeName);
        commandoFighters.AddCommando(commando);
    }

    public void CreatAndAddWeapon(string name, string manufacturer, int numBalls)
    {
        Weapon weapon = wepones.CreatWeapon(name, manufacturer, numBalls);
        wepones.AddWeapon(weapon);
    }

    public List<Commando> getcommandoFighters()
    {
        return commandoFighters.getCommandoFighters();
    }

    public List<Enemy> getEnemies()
    {
        return enemies.getEnemies();
    }

    public List<Weapon> getWeapons()
    {
        return wepones.getWeaponss();
    }
}