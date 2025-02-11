
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

        private OperatorModel? _editingOperator;

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

        private void RemoveSelectedOperators()
        {
            Dispatcher.Dispatch(new RemoveSelectedOperatorsAction());
        }

        private void StartEditing(OperatorModel operatorData)
        {
            _editingOperator = new OperatorModel
            {
                Id = operatorData.Id,
                OpId = operatorData.OpId,
                OpName = operatorData.OpName,
                SelectedToBeDeleted = operatorData.SelectedToBeDeleted,
                Access1 = operatorData.Access1,
                Access2 = operatorData.Access2,
                Access3 = operatorData.Access3,
                Description = operatorData.Description
            };
        }

        private void CancelEditing()
        {
            _editingOperator = null;
        }

        private void SaveChanges()
        {
            if (_editingOperator == null) return;

            Dispatcher.Dispatch(new ChangeOperatorAction
            {
                Operator = new OperatorModel
                {
                    Id = _editingOperator.Id,
                    OpId = _editingOperator.OpId,
                    OpName = _editingOperator.OpName,
                    SelectedToBeDeleted = _editingOperator.SelectedToBeDeleted,
                    Access1 = _editingOperator.Access1,
                    Access2 = _editingOperator.Access2,
                    Access3 = _editingOperator.Access3,
                    Description = _editingOperator.Description
                }
            });

            _editingOperator = null;
        }
    }
}
