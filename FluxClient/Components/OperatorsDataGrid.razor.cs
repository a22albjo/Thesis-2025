
using FluxClient.Store.Operators;
using Fluxor;
using Microsoft.AspNetCore.Components;

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
    }
}

