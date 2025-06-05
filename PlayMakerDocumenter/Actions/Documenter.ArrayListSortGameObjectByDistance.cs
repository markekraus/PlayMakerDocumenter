using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListSortGameObjectByDistance(this StringBuilder sb, ArrayListSortGameObjectByDistance action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListSortGameObjectByDistance)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.distanceFrom), action.distanceFrom, ctx)
            .AddRow(nameof(action.everyframe), action.everyframe, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.orDistanceFromVector3), action.orDistanceFromVector3, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .BuildTable();
}
