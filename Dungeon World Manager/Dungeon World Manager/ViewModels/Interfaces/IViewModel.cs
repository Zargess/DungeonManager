using Dungeon_World_Manager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.ViewModels.Interfaces
{
    public interface IViewModel
    {
        EnemyCatalogue EnemyCatalogue { get; }
        ObservableCollection<Encounter> Encounters { get; }

        void SetData(IViewModel other);
    }
}
