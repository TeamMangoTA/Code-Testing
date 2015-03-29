using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.PeopleModels
{
    abstract class GoodGuy:Entity
    {
        public bool IsGood { get; private set; }

        public GoodGuy(int h,int m, int dr,int inv):
            base(h,m,dr,inv)
        {
            this.IsGood = true;
        }
    }
}
