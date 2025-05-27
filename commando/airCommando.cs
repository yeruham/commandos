using System;

public class AirCommando : Commando
{
    public AirCommando(string name, string codeName) : base(name, codeName) { }

    public void Parachuting()
    {
        this.status = "Parachuting";
        Console.WriteLine($"the commando is {this.status}");
    }
}