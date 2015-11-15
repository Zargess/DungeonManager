using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Models
{
    public class EnemyCatalogue
    {
        public ObservableCollection<Enemy> Enemies { get; set; }

        public EnemyCatalogue()
        {
            Enemies = new ObservableCollection<Enemy>();
        }

        public void ImportEnemies(EnemyCatalogue other)
        {
            // TODO : Compare the enemies and include only the new ones.
            throw new NotImplementedException();
        }
    }
}
