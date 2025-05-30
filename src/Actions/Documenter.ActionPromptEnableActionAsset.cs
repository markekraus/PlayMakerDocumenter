using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionActionPromptEnableActionAsset(this StringBuilder sb, ActionPromptEnableActionAsset action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ActionPromptEnableActionAsset)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.IsEnabled), action.IsEnabled, ctx)
            .AddRow(nameof(action.TargetAsset), action.TargetAsset, ctx)
            .BuildTable();
}
