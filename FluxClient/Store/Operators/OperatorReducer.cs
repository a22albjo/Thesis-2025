using Fluxor;
using System.Collections.Immutable;
using FluxClient.Models;

namespace FluxClient.Store.Operators
{
    public class OperatorsReducer
    {
        [ReducerMethod]
        public static OperatorsState OperatorsListReceived(OperatorsState state, OperatorsListReceivedAction action)
        {
            var builder = ImmutableList.CreateBuilder<OperatorModel>();
            builder.AddRange(action.OperatorsList.ToList());

            return state with
            {
                Operators = builder.ToImmutableList()
            };
        }
    }
}
