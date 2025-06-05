using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionIsActive(this StringBuilder sb, IsActive action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IsActive)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.isActive), action.isActive, ctx)
            .AddRow(nameof(action.isActiveEvent), action.isActiveEvent, ctx)
            .AddRow(nameof(action.isNotActiveEvent), action.isNotActiveEvent, ctx)
            .BuildTable();
}
