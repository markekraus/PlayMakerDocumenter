using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionFindGameObject(this StringBuilder sb, FindGameObject action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(FindGameObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.objectName), action.objectName, ctx)
            .AddRow(nameof(action.store), action.store, ctx)
            .AddRow(nameof(action.withTag), action.withTag, ctx)
            .BuildTable();
}
