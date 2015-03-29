using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.Interfaces
{
    public interface IOffensive
    {
        int DmgValue { get; set; }
        bool Defend { get; set; }

        void Resolve();
    }
}
