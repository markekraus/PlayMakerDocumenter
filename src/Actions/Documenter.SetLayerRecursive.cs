using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetLayerRecursive(this StringBuilder sb, SetLayerRecursive action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetLayerRecursive)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.children), action.children, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.layer), action.layer, ctx)
            .BuildTable();
}
