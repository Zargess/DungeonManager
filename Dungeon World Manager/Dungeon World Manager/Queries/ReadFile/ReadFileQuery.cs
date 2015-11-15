using Dungeon_World_Manager.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Queries.ReadFile
{
    public class ReadFileQuery : IQuery<string>
    {
        public string FilePath { get; set; }
    }
}
