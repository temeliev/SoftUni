using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, 75, 50, team, 6)
        {
            this.HealingPoints = 60;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(x => x.Team == this.Team && x != this && x.IsAlive).OrderBy(x => x.HealthPoints).FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public int HealingPoints { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Healing: {0}", this.HealingPoints);
        }
    }
}
