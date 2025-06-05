using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionDestroyObject(this StringBuilder sb, DestroyObject action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(DestroyObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.delay), action.delay, ctx)
            .AddRow(nameof(action.detachChildren), action.detachChildren, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .BuildTable();
}
