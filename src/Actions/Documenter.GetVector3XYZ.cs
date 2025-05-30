using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetVector3XYZ(this StringBuilder sb, GetVector3XYZ action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetVector3XYZ)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame, ctx)
            .AddRow(nameof(action.storeX), action.storeX, ctx)
            .AddRow(nameof(action.storeY), action.storeY, ctx)
            .AddRow(nameof(action.storeZ), action.storeZ, ctx)
            .AddRow(nameof(action.vector3Variable), action.vector3Variable, ctx)
            .BuildTable();
}
