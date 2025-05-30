using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionCutToCamera2(this StringBuilder sb, CutToCamera2 action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(CutToCamera2)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action._go), action._go, ctx)
            .AddRow(nameof(action.camera), action.camera, ctx)
            .AddRow(nameof(action.cutBackOnExit), action.cutBackOnExit, ctx)
            .AddRow(nameof(action.makeMainCamera), action.makeMainCamera, ctx)
            .AddRow(nameof(action.oldCamera), action.oldCamera, ctx)
            .BuildTable();
}
