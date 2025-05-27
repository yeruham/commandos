using System.Collections.Generic;

public class CommandoFactory : ListCommando, CommandoFactoryBase
{

    public  Commando CreatCommando(string name, string codeName)
    {
        Commando newCommando = new Commando(name, codeName);
        return newCommando;
    }

    public override void AddCommando(Commando commando)
    {
        this.commandoFighters.Add(commando);

    }

    public override List<Commando> getCommandoFighters()
    {
        return this.commandoFighters;
    }

}


