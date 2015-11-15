using Dungeon_World_Manager.Commands.Logic.Interfaces;
using Dungeon_World_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Commands.Logic.CreateEnemy
{
    public class CreateEnemyCommand : ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int Armor { get; set; }
        public List<Die> AttackDice { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Move> SpecialMoves { get; set; }
    }
}
