using System;
using System.Diagnostics;

public class Commando
{
    private string name;
    public string codeName { get; set; }
    public string[] tools = { "Hammer", "chisel", "rope", "bag", "water bottle" };
    public string status = "standing";

    public Commando(string name, string codeName)
    {
        this.name = name;
        this.codeName = codeName;
    }

    public void Walk()
    {
        this.status = "walk";
        Console.WriteLine($"the commando {this.codeName} is {this.status}");
    }

    public void Hide()
    {
        this.status = "hide";
        Console.WriteLine($"the commando {this.codeName} is {this.status}");
    }

    public void Attack()
    {
        Console.WriteLine($"the commando {this.codeName} attack!");
    }

    public void SayName(string commanderRank)
    {
        switch (commanderRank)
        {
            case "GENERAL":
                Console.WriteLine($"the commando soldier's name is {this.name}");
                break;
            case "COLONEL":
                Console.WriteLine($"the commando soldier's code name is {this.codeName}");
                break;
            default:
                Console.WriteLine("this information is classified");
                break;
        }
    }
}