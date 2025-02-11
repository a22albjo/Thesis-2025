using FluxClient.Models;
namespace FluxClient.Store.Operators;

public class OperatorsFetchInitialDataAction { }

public class OperatorsListReceivedAction
{
    public List<OperatorModel> OperatorsList { get; set; } = new List<OperatorModel>();
}

public class AddOperatorAction
{
    public required OperatorModel Operator { get; set; }
}

public class ToggleSelectedToBeDeletedCheckboxAction
{
    public Guid Id { get; set; }
};

public class RemoveSelectedOperatorsAction { }

public class ChangeOperatorAction
{
    public required OperatorModel Operator { get; set; }
}