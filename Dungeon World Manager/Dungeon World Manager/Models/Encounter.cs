using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Models
{
    public class Encounter : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private ObservableCollection<Enemy> enemies;
        private ObservableCollection<Item> items;
        private ObservableCollection<Note> notes;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                RaisePropertyChanged(nameof(Description));
            }
        }
        public ObservableCollection<Enemy> Enemies
        {
            get
            {
                return enemies;
            }
            set
            {
                enemies = value;
                RaisePropertyChanged(nameof(Enemies));
            }
        }
        public ObservableCollection<Item> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                RaisePropertyChanged(nameof(Items));
            }
        }
        public ObservableCollection<Note> Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
                RaisePropertyChanged(nameof(Notes));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Encounter()
        {
            Name = "";
            Description = "";
            Enemies = new ObservableCollection<Enemy>();
            Items = new ObservableCollection<Item>();
            Notes = new ObservableCollection<Note>();
        }

        private void RaisePropertyChanged(string v)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public void AddRandomNumberOfEnemies(Enemy e, int min, int max)
        {
            var time = DateTime.Now;
            var random = new Random(time.Millisecond * time.Minute * time.Second);
            var n = random.Next(min, max);
            
            for(var i = 0; i < n; i++)
            {
                Enemies.Add(new Enemy(e));
            }
        }

        public void AddRandomLoot()
        {
            // TODO : Make a corelation with loot enemy such that a given enemy has x items/coins on it
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
