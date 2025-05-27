using System.Collections.Generic;

public class CommandoFactory
{
    private List<Commando> commandoFighters = new List<Commando>();

    public Commando CreatCommando(string name, string codeName, string type = "commando")
    {
        Commando newCommando;
        switch (type)
        {
            case "AirCommando":
                newCommando = new AirCommando(name, codeName);
                break;
            case "SeaCommando":
                newCommando = new SeaCommando(name, codeName);
                break;
            default:
                newCommando = new Commando(name, codeName);
                break;
        }
        return newCommando;
    }

    public void AddCommando(Commando commando)
    {
        commandoFighters.Add(commando);
    }

    public List<Commando> getCommandoFighters()
    {
        return commandoFighters;
    }

}