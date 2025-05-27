using System;

public class Weapon
{
    string name;
    string manufacturer;
    int numBalls;

    public Weapon(string name, string manufacturer, int numBalls)
    {
        this.name = name;
        this.manufacturer = manufacturer;
        this.numBalls = numBalls;
    }

    public void Shoot()
    {
        this.numBalls--;
        Console.WriteLine($"a shot from {this.name} was fired.");
    }


}