using Dungeon_World_Manager.Models;
using Dungeon_World_Manager.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Dungeon_World_Manager.ViewModels
{
    public class ViewModel : IViewModel
    {
        public EnemyCatalogue EnemyCatalogue { get; set; }

        public ObservableCollection<Encounter> Encounters { get; set; }

        public ViewModel()
        {
            EnemyCatalogue = new EnemyCatalogue();
        }

        public void SetData(IViewModel other)
        {
            this.EnemyCatalogue = other.EnemyCatalogue;
        }
    }
}
