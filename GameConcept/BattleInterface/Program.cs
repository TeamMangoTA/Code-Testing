using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using GameConcept;
using GameConcept.AbilityModels;
using GameConcept.ActionModels;
using GameConcept.BattleModels;
using GameConcept.Interfaces;
using GameConcept.PeopleModels;
using GameConcept.WeaponModels;


namespace BattleInterface
{
  
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///   
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [STAThread]


        static void Main()
        {
            AllocConsole();

            Player me = new Player(100, 100, 10, 5, 11);
            Player you = new Player(100, 100, 10, 5, 12);

            Saber sword1 = new Saber(15, "LightBringer");
            Saber sword2 = new Saber(12, "LightBringer1");

            me.AddEquipment(sword1);
            me.AddEquipment(sword2);

            Console.WriteLine(you.EntityStats);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            while (true)
            {


                var skilltext = me.GetAttacks().Select(o => o.ToString()).ToArray();

                var from = new Form1(you.EntityStats.ToString(), skilltext, "pic.jpg");

                Application.Run(from);

                var r = from.Result;

                me.ChooseAttack(you, r);

                Console.WriteLine(you.EntityStats);
            }


            Console.WriteLine();
        }
    }
}
