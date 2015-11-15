using Autofac;
using Dungeon_World_Manager.Commands.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Commands.Logic
{
    sealed class CommandProcessor : ICommandProcessor
    {
        private readonly IComponentContext context;

        public CommandProcessor(IComponentContext context)
        {
            this.context = context;
        }

        public void Process(ICommand command)
        {
            var handlerType = typeof(ICommandHandler<>).MakeGenericType(command.GetType());
            dynamic handler = context.Resolve(handlerType);

            handler.Handle((dynamic)command);
        }
    }
}
