using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.PeopleModels
{
    struct Stats
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Initiative { get; set; }
        public int DeffenceRating { get; private set; }

        public Stats(int h, int m, int dr, int inv):this()
        {
            this.Health = h;
            this.Mana = m;
            this.DeffenceRating = dr;
            this.Initiative = inv;
        }

        public void ChangeHealth(int n)
        {
            this.Health += n;
        }

        public void ChangeMana(int n)
        {
            this.Mana += n;
        }

        public void ChangeInitiative(int n)
        {
            this.Initiative += n;
        }
    }
}
