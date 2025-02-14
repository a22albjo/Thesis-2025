using System.Collections.ObjectModel;
using System.ComponentModel;
using MVVMClient.Models;

namespace MVVMClient.ViewModels
{
    public interface IOperatorsViewModel : INotifyPropertyChanged
    {
        ObservableCollection<OperatorModel> OperatorsData { get; }
        Task FetchOperators();
        void AddOperator();
        void RemoveSelectedOperators();
        void BackupOperator(object Op);
        void CancelEditing(object Op);
        void ChangeMade();
    }
}