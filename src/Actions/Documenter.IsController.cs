using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionIsController(this StringBuilder sb, IsController action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IsController)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.storeResult), action.storeResult, ctx)
            .BuildTable();
}
