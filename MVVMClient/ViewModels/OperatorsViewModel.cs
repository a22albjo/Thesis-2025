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
            OnPropertyChanged(nameof(OperatorsData));
        }

        public void AddOperator()
        {
            return;
        }

        public void RemoveSelectedOperators()
        {
            return;
        }

        public void StartEditing(object Op)
        {
            return;
        }

        public void CancelEditing(object Op)
        {
            return;
        }

        public void SaveChanges()
        {
            return;
        }
    }
}

