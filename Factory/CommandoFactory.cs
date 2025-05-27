using System.Collections.Generic;

public class CommandoFactory : CommandoFactoryBase
{

    public override Commando CreatCommando(string name, string codeName)
    {
        Commando newCommando = new Commando(name, codeName);
        return newCommando;
    }

    public override void AddCommando(Commando commando)
    {
        commandoFighters.Add(commando);

    }

    public override List<Commando> getCommandoFighters()
    {
        return commandoFighters;
    }

}


