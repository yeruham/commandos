using System.Collections.Generic;

public abstract class CommandFactoryBase
{
    protected List<Commando> commandoFighters  = new List<Commando>();

    public abstract Commando CreatCommando(string name, string codeName);

    public abstract void AddCommando(Commando commando);

    public abstract List<Commando> getCommandoFighters();
}