using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Queries.Interfaces
{
    public interface IQueryProcessor
    {
        TResult Process<TResult>(IQuery<TResult> query);

        Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query);
    }
}
