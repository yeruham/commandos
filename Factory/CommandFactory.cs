using System.Collections.Generic;

public class CommandoFactory
{
    private List<Commando> commandoFighters = new List<Commando>();

    public Commando CreatEnemy(string name, string codeName)
    {
        Commando newCommando = new Commando(name, codeName);
        return newCommando;
    }

    public void AddEnemy(Commando commando)
    {
        commandoFighters.Add(commando);
    }

    public List<Commando> getEnemies()
    {
        return commandoFighters;
    }

}