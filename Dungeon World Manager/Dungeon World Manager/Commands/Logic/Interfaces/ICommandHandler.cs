using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Commands.Logic.Interfaces
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Process(T command);
    }
}
