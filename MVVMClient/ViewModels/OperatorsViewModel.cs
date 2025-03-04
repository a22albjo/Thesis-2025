using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using MVVMClient.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVVMClient.ViewModels
{
	public partial class OperatorsViewModel : ObservableObject, IOperatorsViewModel
    {
        private readonly HttpClient _httpClient;

        public OperatorsViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
            OperatorsData = new ObservableCollection<OperatorModel>();
            FetchOperators();
        }

        [ObservableProperty]
        private ObservableCollection<OperatorModel> operatorsData;

        private OperatorModel? _operatorBeforeEdit;

        public async Task FetchOperators()
        {
            var operatorsResponse = await _httpClient.GetFromJsonAsync<List<OperatorModel>>("https://localhost:7200/Operator");
            if (operatorsResponse == null) return;
            OperatorsData.Clear();
            foreach (var operatorResponse in operatorsResponse)
            {
                OperatorsData.Add(operatorResponse);
            }
            OnPropertyChanged(nameof(OperatorsData));
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
                ChangedBy = "config-client",
                ChangedTime = DateTime.Now,
            });
            OnPropertyChanged(nameof(OperatorsData));
        }

        public void RemoveSelectedOperators()
        {
            //The fluxor way
            //var newOperatorsState = OperatorsData.Where(op => !op.SelectedToBeDeleted).ToList();
            //OperatorsData = new ObservableCollection<OperatorModel>(newOperatorsState);
            //OnPropertyChanged(nameof(OperatorsData));

            for (int i = OperatorsData.Count - 1; i >= 0; i--)
            {
                if (OperatorsData[i].SelectedToBeDeleted)
                {
                    OperatorsData.RemoveAt(i);
                }
            }
        }

        public void ChangeMade()
        {
            OnPropertyChanged(nameof(OperatorsData));
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




