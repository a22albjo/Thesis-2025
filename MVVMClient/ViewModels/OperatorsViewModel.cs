using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using MVVMClient.Models;

namespace MVVMClient.ViewModels
{
	public partial class OperatorsViewModel : ObservableObject, IOperatorsViewModel
    {
        private readonly HttpClient _httpClient;

        public OperatorsViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
            OperatorsData = new ObservableCollection<OperatorModel>();
        }

        private OperatorModel? _operatorBeforeEdit;

        [ObservableProperty]
        private ObservableCollection<OperatorModel> operatorsData;

        public async Task FetchOperators()
        {
            var operatorsResponse = await _httpClient.GetFromJsonAsync<List<OperatorModel>>("https://localhost:7200/Operator");

            OperatorsData.Clear();
            foreach (var operatorResponse in operatorsResponse)
            {
                OperatorsData.Add(operatorResponse);
            }
        }

        public void AddOperator()
        {
            OperatorsData.Add(new OperatorModel
            {
                OpId = "New",
                OpName = "New",
                Access1 = false,
                Access2 = false,
                Access3 = false,
                SelectedToBeDeleted = false,
                Description = "",
            });
        }

        public void RemoveSelectedOperators()
        {
            var newOperatorsState = OperatorsData.Where(op => !op.SelectedToBeDeleted).ToList();
            OperatorsData = new ObservableCollection<OperatorModel>(newOperatorsState);
        }

        public void BackupOperator(object operatorData)
        {
            _operatorBeforeEdit = new OperatorModel
            {
                OpId = ((OperatorModel)operatorData).OpId,
                OpName = ((OperatorModel)operatorData).OpName,
                Access1 = ((OperatorModel)operatorData).Access1,
                Access2 = ((OperatorModel)operatorData).Access2,
                Access3 = ((OperatorModel)operatorData).Access3,
                Description = ((OperatorModel)operatorData).Description
            };
        }

        public void CancelEditing(object operatorData)
        {
            ((OperatorModel)operatorData).OpId = _operatorBeforeEdit.OpId;
            ((OperatorModel)operatorData).OpName = _operatorBeforeEdit.OpName;
            ((OperatorModel)operatorData).Access1 = _operatorBeforeEdit.Access1;
            ((OperatorModel)operatorData).Access2 = _operatorBeforeEdit.Access2;
            ((OperatorModel)operatorData).Access3 = _operatorBeforeEdit.Access3;
            ((OperatorModel)operatorData).Description = _operatorBeforeEdit.Description;
        }
    }
}




