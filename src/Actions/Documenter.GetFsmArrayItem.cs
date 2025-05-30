using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmArrayItem(this StringBuilder sb, GetFsmArrayItem action, ActionContext ctx = null) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmArrayItem)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.fsmName), action.fsmName)
            .AddRow(nameof(action.gameObject), action.gameObject, action)
            .AddRow(nameof(action.index), action.index)
            .AddRow(nameof(action.storeValue), action.storeValue, action)
            .BuildTable();
}
