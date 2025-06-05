using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetObjectValue(this StringBuilder sb, SetObjectValue action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetObjectValue)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.objectValue), action.objectValue, ctx)
            .AddRow(nameof(action.objectVariable), action.objectVariable, ctx)
            .BuildTable();
}
