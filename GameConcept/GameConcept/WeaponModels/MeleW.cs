using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConcept.Interfaces;
using GameConcept.ActionModels;

namespace GameConcept.WeaponModels
{
    abstract class MeleW:Weapon
    {
       public virtual string GetType()
       {
           return "Mele";
       }
    }
}
