using Microsoft.CodeAnalysis;

namespace Lagrange.Milky.Implementation.Api.Generator;

public static class DiagnosticDescriptors
{
    public static DiagnosticDescriptor NotImplementIApiHandler = new(
        id: "MA001",
        title: "{0} does not implement IApiHandler<TParameter, TResult>",
        messageFormat: "{0} does not implement IApiHandler<TParameter, TResult>",
        category: "Usage",
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true
    );

    public static DiagnosticDescriptor NotUsedJsonSerializable = new(
        id: "MA002",
        title: "{0} is not used in MilkyJsonContext [JsonSerializable(typeof({0}))]",
        messageFormat: "{0} is not used in MilkyJsonContext [JsonSerializable(typeof({0}))]",
        category: "Usage",
        defaultSeverity: DiagnosticSeverity.Error,
        isEnabledByDefault: true
    );
}