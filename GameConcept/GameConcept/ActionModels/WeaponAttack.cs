using GameConcept.AbilityModels;
using GameConcept.Interfaces;
using GameConcept.PeopleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.ActionModels
{
    class WeaponAttack:OffensiveA,IOffensive
    {
        public int DmgValue { get; set; }
        //public string ID { get; set; }

        public bool Defend
        {
            get;
            set;
        }
        
        
        
        public WeaponAttack(Player p1,Player p2, Ability a1)
            :base(p1,p2,a1)
        {

            var temp=(AttackAbility)a1;
            this.DmgValue = temp.DmgHealth;
            if(p2.EntityStats.DeffenceRating>temp.HitModf)
            {
                this.Defend = true;
            }
            else
            {
                this.Defend = false;
            }
            
        }


        public void Resolve()
        {
            if(this.Defend==false)
            {
                this.Target.ChangeHealth(-this.DmgValue);
            }
            else
            {
                Console.WriteLine("Blocked");
            }
        }
    }
}
