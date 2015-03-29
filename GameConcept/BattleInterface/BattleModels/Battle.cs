using BattleInterface;
using GameConcept.PeopleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameConcept.BattleModels
{
    static class Battle
    {
        public static Player Human;
        public static Player AI;

        public static void SetGoodGuy(Player a)
        {
            Human = a;
        }

        public static void SetBadGuy(Player b)
        {
            AI = b;
        }

        public static void StartBattle(Player a, Player b)
        {
           SetBadGuy(b);
           SetGoodGuy(a);
        }

        public static void Combat()
        {
            while (Human.EntityStats.Health>0 && AI.EntityStats.Health>0)
            {
                var skilltext = Human.GetAttacks().Select(o => o.ToString()).ToArray();
                var screen = new Form1(Human.EntityStats.ToString(),AI.EntityStats.ToString(), skilltext, "pic.jpg");

                Application.Run(screen);
                int attack = screen.Result;

                Human.DoAttack(AI, attack);
                Console.WriteLine("HumanAttack");
                AI.DoAttack(Human, 0);
                Console.WriteLine("AIAttack");
            }
        }


    }
}
