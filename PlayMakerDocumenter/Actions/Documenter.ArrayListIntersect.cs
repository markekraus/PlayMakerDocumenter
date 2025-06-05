using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListIntersect(this StringBuilder sb, ArrayListIntersect action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListIntersect)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.arrayOne), action.arrayOne, ctx)
            .AddRow(nameof(action.arrayTwo), action.arrayTwo, ctx)
            .AddRow(nameof(action.clearArray), action.clearArray, ctx)
            .AddRow(nameof(action.gameObjectOne), action.gameObjectOne, ctx)
            .AddRow(nameof(action.gameObjectSave), action.gameObjectSave, ctx)
            .AddRow(nameof(action.gameObjectTwo), action.gameObjectTwo, ctx)
            .AddRow(nameof(action.referenceOne), action.referenceOne, ctx)
            .AddRow(nameof(action.referenceSave), action.referenceSave, ctx)
            .AddRow(nameof(action.referenceTwo), action.referenceTwo, ctx)
            .BuildTable();
}
