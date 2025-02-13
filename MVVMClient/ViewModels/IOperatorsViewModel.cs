using System.Collections.ObjectModel;
using MVVMClient.Models;

namespace MVVMClient.ViewModels
{
    public interface IOperatorsViewModel
    {
        ObservableCollection<OperatorModel> OperatorsData { get; }
        Task FetchOperators();
        void AddOperator();
        void RemoveSelectedOperators();
        void BackupOperator(object Op);
        void CancelEditing(object Op);
    }
}