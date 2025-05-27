using System.Collections.Generic;

public class SeaCommandoFactory : CommandoFactoryBase
{
    public override Commando CreatCommando(string name, string codeName)
    {
        SeaCommando seaComando = new SeaCommando(name, codeName);
        return seaComando;
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