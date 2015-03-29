using GameConcept.ActionModels;
using GameConcept.PeopleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.AbilityModels
{
    class AttackAbility:Ability
    {
        public int DmgHealth { get; set; }
        public int HitModf { get; set; }
        public string Type { get; set; }
        public override string AbilityType
        {
            get
            {
                return "Attack";
            }
        }

        public AttackAbility()
        {
                
        }
        public AttackAbility(int d,int h,string s,string t)
        {
            this.Name = s;
            this.DmgHealth = d;
            this.HitModf = h;
            this.Type = t;

        }

        public GameAction CreateAction(Player p1,Player p2)
        {
            return new WeaponAttack(p1,p2,this);
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}%  {3}", this.Name, this.DmgHealth, this.HitModf,this.Type);
        }
       
    }
}
