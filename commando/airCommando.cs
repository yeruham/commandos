using System;

public class AirCommando : Commando
{
    public AirCommando(string name, string codeName) : base(name, codeName) { }

    public void Parachuting()
    {
        this.status = "parachuting";
        Console.WriteLine($"the commando {this.codeName} is {this.status}");
    }

    public override void  Attack()
    {
        Console.WriteLine($"the air command {this.codeName} attack!");
    }
}