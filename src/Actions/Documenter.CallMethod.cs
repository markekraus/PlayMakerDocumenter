using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionCallMethod(this StringBuilder sb, CallMethod action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(CallMethod)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.behaviour), action.behaviour, ctx)
            .AddRow(nameof(action.cachedBehaviour), action.cachedBehaviour, ctx)
            .AddRow(nameof(action.cachedMethodInfo), action.cachedMethodInfo, ctx)
            .AddRow(nameof(action.cachedMethodName), action.cachedMethodName, ctx)
            .AddRow(nameof(action.cachedParameterInfo), action.cachedParameterInfo, ctx)
            .AddRow(nameof(action.cachedType), action.cachedType, ctx)
            .AddRow(nameof(action.errorString), action.errorString, ctx)
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.manualUI), action.manualUI, ctx)
            .AddRow(nameof(action.methodName), action.methodName, ctx)
            .AddRow(nameof(action.parameters), action.parameters, ctx)
            .AddRow(nameof(action.parametersArray), action.parametersArray, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
