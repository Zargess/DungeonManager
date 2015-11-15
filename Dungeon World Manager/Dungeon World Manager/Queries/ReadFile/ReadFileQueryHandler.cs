using Dungeon_World_Manager.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Queries.ReadFile
{
    class ReadFileQueryHandler : IQueryHandler<ReadFileQuery, string>
    {
        public string Handle(ReadFileQuery query)
        {
            if (!File.Exists(query.FilePath)) throw new FileNotFoundException();
            using (var reader = File.OpenText(query.FilePath))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
