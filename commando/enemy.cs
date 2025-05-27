using System;

public class Enemy
{
    string name;
    int LifeSum = 100;
    bool isAlive = true;

    public Enemy(string name)
    {
        this.name = name;
    }

    public void Scream()
    {
        Console.WriteLine("i am enemy!!!");
    }
}