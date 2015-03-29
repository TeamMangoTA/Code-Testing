using GameConcept.AbilityModels;
using GameConcept.ActionModels;
using GameConcept.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.WeaponModels
{
    class Saber:MeleW,IWeapon
    {
        public int DmgValue { get; set; }

        public int AccuracyRating { get; set; }

        public Saber(int dmg,string name)
        {
            this.DmgValue = dmg;
            this.Name = name;
            this.AccuracyRating = 95;
        }

        public override Ability AddAbility()
        {
            var temp = new AttackAbility(this.DmgValue, this.AccuracyRating, this.Name,this.GetType());

            return (Ability)temp;
        }


    }
}
