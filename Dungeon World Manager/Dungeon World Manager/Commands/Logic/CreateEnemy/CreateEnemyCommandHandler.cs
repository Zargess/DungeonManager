using Dungeon_World_Manager.Commands.Logic.Interfaces;
using Dungeon_World_Manager.Models;
using Dungeon_World_Manager.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Commands.Logic.CreateEnemy
{
    class CreateEnemyCommandHandler : ICommandHandler<CreateEnemyCommand>
    {
        private readonly IViewModel viewmodel;

        public CreateEnemyCommandHandler(IViewModel viewmodel)
        {
            this.viewmodel = viewmodel;
        }

        public void Process(CreateEnemyCommand command)
        {
            var enemy = new Enemy()
            {
                Name = command.Name,
                Description = command.Description,
                HP = command.HP,
                Armor = command.Armor,
                AttackDice = command.AttackDice,
                Tags = command.Tags,
                SpecialMoves = command.SpecialMoves,
                ID = Guid.NewGuid()
            };

            viewmodel.EnemyCatalogue.Enemies.Add(enemy);
        }
    }
}
