using GameConcept.ActionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.Interfaces
{
    interface IWeapon
    {
        int DmgValue { get; set; }
        int AccuracyRating { get; set; }

        //GameAction AddAction();
    }
}
