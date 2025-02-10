using FluxClient.Models;
namespace FluxClient.Store.Operators;

public class OperatorsFetchInitialDataAction { }

public class OperatorsListReceivedAction
{
    public List<OperatorModel> OperatorsList { get; set; } = new List<OperatorModel>();
}