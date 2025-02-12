namespace MVVMClient.Components
{
    public partial class OperatorsTable
    {
        protected override async Task OnInitializedAsync()
        {
            await OperatorsViewModel.FetchOperators();
        }
    }
}