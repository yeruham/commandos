using System.Collections.Generic;

public class EnemyFactory
{
    private List<Enemy> enemies = new List<Enemy>();

    public Enemy CreatEnemy(string name)
    {
        Enemy newEnemy = new Enemy(name);
        return newEnemy;
    }

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }

    public List<Enemy> getEnemies()
    {
        return enemies;
    }

}