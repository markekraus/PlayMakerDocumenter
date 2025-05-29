using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmArray(this StringBuilder sb, GetFsmArray action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmArray)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.copyValues), action.copyValues)
            .AddRow(nameof(action.fsmName), action.fsmName)
            .AddRow(nameof(action.gameObject), action.gameObject, action)
            .AddRow(nameof(action.storeValue), action.storeValue)
            .AddRow(nameof(action.variableName), action.variableName)
            .BuildTable();
}
