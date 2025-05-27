using System.Collections.Generic;

public class ListCommando
{
    protected List<Commando> commandoFighters = new List<Commando>();

    public virtual void AddCommando(Commando commando) 
    {
        this.commandoFighters.Add(commando);
    }

    public virtual List<Commando> getCommandoFighters()
    {
        return commandoFighters;
    }
}