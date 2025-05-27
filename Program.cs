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
            Console.WriteLine(avi.codeName);
            avi.codeName = "yeruham";
            avi.Attack();
            gun.Shoot();
        }
    }
}
