using Fluxor;
using System.Net.Http.Json;
using FluxClient.Models;

namespace FluxClient.Store.Operators;

public class OperatorsEffect
{

    private readonly HttpClient _httpclient;

    public OperatorsEffect(HttpClient httpClient)
    {
        _httpclient = httpClient;
    }

    [EffectMethod(typeof(OperatorsFetchInitialDataAction))]
    public async Task OnOperatorsFetchInitialDataAction(IDispatcher dispatcher)
    {
        var operatorsResponse = await _httpclient.GetFromJsonAsync<List<OperatorModel>>("https://localhost:7200/Operator");

        if (operatorsResponse == null) return;

        var operatorsList = operatorsResponse.Select(x => new OperatorModel
        {
            Id = x.Id,
            OpId = x.OpId,
            Access1 = x.Access1,
            Access2 = x.Access2,
            Access3 = x.Access3,
            OpName = x.OpName,
            Description = x.Description,
        }).ToList();

        dispatcher.Dispatch(new OperatorsListReceivedAction
        {
            OperatorsList = operatorsList
        });
    }
}
