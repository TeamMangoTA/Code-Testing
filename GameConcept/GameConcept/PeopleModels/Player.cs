using GameConcept.AbilityModels;
using GameConcept.ActionModels;
using GameConcept.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConcept.PeopleModels
{
    class Player:GoodGuy
    {
        List<Ability> Skills = new List<Ability>();
        
        List<Weapon> Equipment = new List<Weapon>();

        public int ID { get; set; }

        public Player(int h, int m, int dr, int inv,int id)
            :base(h,m,dr,inv)
        {
            this.ID = id;
        }

        public void AddEquipment(Weapon s)
        {
            this.Equipment.Add(s);
            this.AddAbility();
        }

        public void AddAbility()
        {
            Skills.Clear();
            foreach (var item in Equipment)
            {
                Ability temp = item.AddAbility();
                Skills.Add(temp);
            }
        }

        public void GetAbilities()
        {
            foreach (var item in Skills)
            {
                Console.WriteLine(item);
            }
        }

        public List<AttackAbility> GetAttacks()
        {
            var r = Skills.Where(o => o.AbilityType == "Attack").Select(o => (AttackAbility)o).ToList();
            return r;
        }

        public void DoAttack(Player target,Ability a)
        {
            var skill = (AttackAbility)a;

            var action = skill.CreateAction(this,target);

            var resolution = (WeaponAttack)action;
            resolution.Resolve();
        }

        public void ChooseAttack(Player target)
        {

            var temp = new AttackAbility();
            int ch = -1;
            List<int> select = new List<int>();
            for (int i = 0; i < Skills.Count; i++)
            {
                if (Skills[i].GetType()==temp.GetType())
                {
                    Console.WriteLine(Skills[i]+"Seleclt: {0}",i);
                    select.Add(i);
                }


            }
            do
            {
                Console.WriteLine("Choose Attack");
                ch = int.Parse(Console.ReadLine());
            } while (!select.Exists(o => o == ch));


            var tempattack = Skills[ch];

            this.DoAttack(target, tempattack);

        }





    }
}
