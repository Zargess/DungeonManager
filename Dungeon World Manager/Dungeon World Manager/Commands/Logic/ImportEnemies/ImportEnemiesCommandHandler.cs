using Dungeon_World_Manager.Commands.Logic.Interfaces;
using Dungeon_World_Manager.Models;
using Dungeon_World_Manager.Queries.Interfaces;
using Dungeon_World_Manager.Queries.ReadFile;
using Dungeon_World_Manager.ViewModels.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Commands.Logic.ImportEnemies
{
    class ImportEnemiesCommandHandler : ICommandHandler<ImportEnemiesCommand>
    {
        private readonly IQueryProcessor processor;
        private readonly IViewModel viewmodel;

        public ImportEnemiesCommandHandler(IViewModel viewmodel, IQueryProcessor processor)
        {
            this.viewmodel = viewmodel;
            this.processor = processor;
        }

        public void Process(ImportEnemiesCommand command)
        {
            var data = processor.Process(new ReadFileQuery()
            {
                FilePath = command.FilePath
            });

            var enemyCatalogue = JsonConvert.DeserializeObject<EnemyCatalogue>(data);

            viewmodel.EnemyCatalogue.ImportEnemies(enemyCatalogue);
        }
    }
}
