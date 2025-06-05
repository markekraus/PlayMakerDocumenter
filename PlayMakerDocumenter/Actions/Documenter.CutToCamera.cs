using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionCutToCamera(this StringBuilder sb, CutToCamera action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(CutToCamera)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.camera), action.camera, ctx)
            .AddRow(nameof(action.cutBackOnExit), action.cutBackOnExit, ctx)
            .AddRow(nameof(action.makeMainCamera), action.makeMainCamera, ctx)
            .AddRow(nameof(action.oldCamera), action.oldCamera, ctx)
            .BuildTable();
}
