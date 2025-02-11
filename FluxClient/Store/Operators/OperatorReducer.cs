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

        [ReducerMethod]
        public static OperatorsState ReduceAddOperatorAction(OperatorsState state, AddOperatorAction action)
        {
            var newOperator = new OperatorModel
            {
                Id = action.Operator.Id,
                OpId = action.Operator.OpId,
                OpName = action.Operator.OpName,
                Description = action.Operator.Description,
                Access1 = action.Operator.Access1,
                Access2 = action.Operator.Access2,
                Access3 = action.Operator.Access3,
                ChangedBy = "config-client",
                ChangedTime = DateTime.Now,
                SelectedToBeDeleted = false,
            };

            var updatedOperatorsList = state.Operators.Add(newOperator);

            return state with { Operators = updatedOperatorsList };
        }

        [ReducerMethod]
        public static OperatorsState ReduceToggleSelectedToBeDeletedCheckboxAction(OperatorsState state, ToggleSelectedToBeDeletedCheckboxAction action)
        {
            var itemToUpdate = state.Operators.FirstOrDefault(x => x.Id == action.Id);

            var updatedItem = itemToUpdate with { SelectedToBeDeleted = !itemToUpdate.SelectedToBeDeleted };

            var newOperatorsState = state.Operators.Replace(itemToUpdate, updatedItem);

            return state with { Operators = newOperatorsState };
        }
    }
}
