using Dungeon_World_Manager.Commands.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Commands.Logic.ImportEnemies
{
    public class ImportEnemiesCommand : ICommand
    {
        public string FilePath { get; set; }
    }
}
