using System;

public class Commando
{
    public string name;
    public string codeName;
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
        Console.WriteLine($"the commando {this.name} is {this.status}");
    }

    public void Hide()
    {
        this.status = "hide";
        Console.WriteLine($"the commando {this.name} is {this.status}");
    }

    public void Attack()
    {
        Console.WriteLine($"the commando {this.name} attack!");
    }
}