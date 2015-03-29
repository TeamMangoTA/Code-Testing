using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.PeopleModels
{
    abstract class BadGuy:Entity
    {
        public bool IsGood { get; private set; }

        public BadGuy(int h,int m, int dr,int inv)
            :base(h,m,dr,inv)
        {
            this.IsGood = false;
        }
    }
}
