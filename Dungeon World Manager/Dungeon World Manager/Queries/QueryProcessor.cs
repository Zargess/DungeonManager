using Autofac;
using Dungeon_World_Manager.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Queries
{
    sealed class QueryProcessor : IQueryProcessor
    {
        private readonly IComponentContext context;

        public QueryProcessor(IComponentContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Automatically figures out which QueryHandler belongs to the given Query, instantiates it, and returns the result of running the Query on that QueryHandler.
        /// </summary>
        /// <typeparam name="TResult">The type of result to return. This can be infered from Query given.</typeparam>
        /// <param name="query">The query to return to use as basis for finding a suitable QueryHandler and returning the result.</param>
        /// <returns></returns>
        public TResult Process<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
            dynamic handler = context.Resolve(handlerType);

            return handler.Handle((dynamic)query);
        }

        public async Task<TResult> ProcessAsync<TResult>(IQuery<TResult> query)
        {
            return await Task.Factory.StartNew(() => Process(query)).ConfigureAwait(false);
        }
    }
}
