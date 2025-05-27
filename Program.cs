using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando avi = new Commando("avi", "x");
            Weapon gun = new Weapon("gun", "refal", 20);
            //Console.WriteLine(avi.codeName);
            avi.codeName = "@";
            //avi.Attack();
            //gun.Shoot();
            AirCommando yeruham = new AirCommando("yeruham", "w");
            //yeruham.Parachuting();
            //yeruham.Walk();
            yeruham.Attack();
            SeaCommando aviv = new SeaCommando("aviv", "a");
            Commando[] commandos = {avi, yeruham, aviv};
            foreach (Commando c in commandos)
            {
                c.Attack();
            }


        }
    }
}
