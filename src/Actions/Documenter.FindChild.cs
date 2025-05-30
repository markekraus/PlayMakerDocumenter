using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFindChild(this StringBuilder sb, FindChild action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FindChild)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.childName), action.childName, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
