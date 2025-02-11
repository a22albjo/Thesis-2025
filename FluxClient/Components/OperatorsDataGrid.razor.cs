
using FluxClient.Store.Operators;
using Fluxor;
using Microsoft.AspNetCore.Components;
using FluxClient.Models;

namespace FluxClient.Components
{
    public partial class OperatorsDataGrid
    {
        [Inject]
        public required IDispatcher Dispatcher { get; set; }

        [Inject]
        public required IState<OperatorsState> OperatorState { get; set; }

        protected override Task OnInitializedAsync()
        {
            if (OperatorState.Value.Operators.Count == 0)
            {
                Dispatcher.Dispatch(new OperatorsFetchInitialDataAction());
            }
            return base.OnInitializedAsync();
        }

        private void AddOperator()
        {
            Dispatcher.Dispatch(new AddOperatorAction
            {
                Operator = new OperatorModel
                {
                    Id = Guid.NewGuid(),
                    OpId = "New",
                    OpName = "New",
                    SelectedToBeDeleted = false,
                    Access1 = false,
                    Access2 = false,
                    Access3 = false
                }
            });
        }

        private void ToggleSelectedToBeDeletedCheckbox(Guid id)
        {
            Dispatcher.Dispatch(new ToggleSelectedToBeDeletedCheckboxAction
            {
                Id = id
            });
        }
    }
}

