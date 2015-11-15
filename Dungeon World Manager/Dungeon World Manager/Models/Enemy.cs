using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Models
{
    public class Enemy : INotifyPropertyChanged
    {
        private int hp;
        public string Name { get; set; }
        public string Description { get; set; }
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(HP)));
            }
        }
        public int Armor { get; set; }
        public List<Die> AttackDice { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Move> SpecialMoves { get; set; }
        public Guid ID { get; set; }

        public Enemy()
        {
            Name = "";
            Description = "";
            HP = 0;
            Armor = 0;
            AttackDice = new List<Die>();
            Tags = new List<Tag>();
            SpecialMoves = new List<Move>();
        }

        public Enemy(Enemy other)
        {
            Name = other.Name;
            Description = other.Description;
            HP = other.HP;
            Armor = other.Armor;
            AttackDice = new List<Die>(other.AttackDice);
            Tags = new List<Tag>(other.Tags);
            SpecialMoves = new List<Move>(other.SpecialMoves);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return Name + ", HP: " + HP + ", Armor: " + Armor;
        }

        public override bool Equals(object obj)
        {
            if (obj == this) return true;
            if (obj == null) return false;
            if (!(obj is Enemy)) return false;
            var other = obj as Enemy;
            return this.ID.Equals(other.ID);
        }

        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }
    }
}
