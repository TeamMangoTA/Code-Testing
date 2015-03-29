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
    class Musket:RangeW,IWeapon 
    {
        public int DmgValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int AccuracyRating
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override Ability AddAbility()
        {
            throw new NotImplementedException();
        }
    }
}
