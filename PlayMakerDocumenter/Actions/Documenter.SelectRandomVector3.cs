using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSelectRandomVector3(this StringBuilder sb, SelectRandomVector3 action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SelectRandomVector3)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.storeVector3), action.storeVector3, ctx)
            .AddRow(nameof(action.vector3Array), action.vector3Array, ctx)
            .AddRow(nameof(action.weights), action.weights, ctx)
            .BuildTable();
}
