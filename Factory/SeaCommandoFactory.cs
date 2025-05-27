using System.Collections.Generic;

public class SeaCommandoFactory : CommandoFactoryBase
{
    public  Commando CreatCommando(string name, string codeName)
    {
        SeaCommando seaComando = new SeaCommando(name, codeName);
        return seaComando;
    }

}