using GameConcept.ActionModels;
using GameConcept.PeopleModels;
using GameConcept.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept
{
    class GameTest
    {
        static void Main()
        {
            Player me = new Player(100, 100, 10,5,11);
            Player you = new Player(100, 100, 10, 5, 12);

            Saber sword1 = new Saber(15, "LightBringer");
            Saber sword2 = new Saber(12, "LightBringer1");

            me.AddEquipment(sword1);
            me.AddEquipment(sword2);

            me.ChooseAttack(you);

            Console.WriteLine("Ending");
            Console.WriteLine(you.EntityStats.Health);

        }
    }
}
