using System.Collections.Generic;

public class AirCommandoFactory : CommandoFactoryBase
{
    public  Commando CreatCommando(string name, string codeName)
    {
        AirCommando airCommando = new AirCommando(name, codeName);
        return airCommando;
    }

}
