using GameConcept.AbilityModels;
using GameConcept.PeopleModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.ActionModels
{
    abstract class OffensiveA:GameAction
    {
        public bool IsValid { get; set; }

        public OffensiveA(Player p1,Player p2,Ability a1)
            :base(p1,p2,a1)
        {
            if(p1.IsGood!=p2.IsGood)
            {
                this.IsValid = true;
            }

            else { this.IsValid = false; }
        }
    }
}
