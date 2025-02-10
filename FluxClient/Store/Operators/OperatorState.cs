using FluxClient.Models;
using Fluxor;
using System.Collections.Immutable;

namespace FluxClient.Store.Operators
{
    [FeatureState]
    public record OperatorsState
    {
        public ImmutableList<OperatorModel> Operators { get; init; } = ImmutableList<OperatorModel>.Empty;
    }
}

