namespace MVVMClient.Components
{
    public partial class OperatorsTable
    {
        protected override void OnInitialized()
        {
            OperatorsViewModel.PropertyChanged += (_, _) => StateHasChanged();
            base.OnInitialized();
        }
    }
}