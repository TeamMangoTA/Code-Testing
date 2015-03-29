using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.ActionModels
{
    class WeaponBlock:DeffensiveA
    {
        public int BlockValue { get; set; }

        public virtual string ID { get; set; }

        public WeaponBlock()
        {
            this.ID = "Action";
        }
    }
}
