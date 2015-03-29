using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.PeopleModels
{
    abstract class Entity
    {
        public Stats EntityStats { get; set; }

        public Entity(int h,int m, int dr,int inv)
        {
            this.EntityStats = new Stats(h, h, dr,inv);
        }

        public void ChangeHealth(int n)
        {
           this.EntityStats = new Stats(this.EntityStats.Health + n, this.EntityStats.Mana,
                this.EntityStats.Initiative, this.EntityStats.DeffenceRating);
        }

        public void ChangeMana(int n)
        {
            this.EntityStats.ChangeMana(n);
        }
    }
}
