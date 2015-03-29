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
            Saber sword2 = new Saber(12, "SwordShatterer");
            Saber sword3 = new Saber(5, "Basic Attack");

            me.AddEquipment(sword1);
            me.AddEquipment(sword2);

            you.AddEquipment(sword3);

           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Battle.StartBattle(me, you);

            Battle.Combat();
        }
    }
}
