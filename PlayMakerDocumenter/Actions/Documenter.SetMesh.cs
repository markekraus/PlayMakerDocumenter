using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSetMesh(this StringBuilder sb, SetMesh action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetMesh)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.meshObject), action.meshObject, ctx)
            .BuildTable();
}
