using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetParent(this StringBuilder sb, SetParent action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetParent)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.parent), action.parent, ctx)
            .AddRow(nameof(action.resetLocalPosition), action.resetLocalPosition, ctx)
            .AddRow(nameof(action.resetLocalRotation), action.resetLocalRotation, ctx)
            .AddRow(nameof(action.worldPositionStays), action.worldPositionStays, ctx)
            .BuildTable();
}
