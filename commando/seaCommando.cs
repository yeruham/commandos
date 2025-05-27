using System;

public class SeaCommando : Commando
{
    public SeaCommando(string name, string codeName) : base(name, codeName) { }

    public void Swimming()
    {
        this.status = " swimming";
        Console.WriteLine($"the commando {this.codeName} is {this.status}");
    }

    public override void Attack()
    {
        Console.WriteLine($"the sea commando {this.codeName} attack!");
    }
}