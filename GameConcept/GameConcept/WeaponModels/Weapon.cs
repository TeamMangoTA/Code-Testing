using GameConcept.AbilityModels;
using GameConcept.ActionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.WeaponModels
{
    abstract class Weapon
    {
        public abstract Ability AddAbility();
        public string Name { get; set; }
    }
}
