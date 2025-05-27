using System;

public class SeaCommando : Commando
{
    public SeaCommando(string name, string codeName) : base(name, codeName) { }

    public void Swimming()
    {
        this.status = " swimming";
        Console.WriteLine($"the commando is {this.status}");
    }
}