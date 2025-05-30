using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmVector3(this StringBuilder sb, GetFsmVector3 action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmVector3)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.fsm), action.fsm, ctx)
            .AddRow(nameof(action.fsmName), action.fsmName, ctx)
            .AddRow(nameof(action.fsmNameLastFrame), action.fsmNameLastFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.goLastFrame), action.goLastFrame, ctx)
            .AddRow(nameof(action.storeValue), action.storeValue, ctx)
            .AddRow(nameof(action.variableName), action.variableName, ctx)
            .BuildTable();
}
