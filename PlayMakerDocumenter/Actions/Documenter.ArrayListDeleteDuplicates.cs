using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionArrayListDeleteDuplicates(this StringBuilder sb, ArrayListDeleteDuplicates action, ActionContext ctx) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(ArrayListDeleteDuplicates)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.atIndex), action.atIndex, ctx)
            .AddRow(nameof(action.atIndex_iplus), action.atIndex_iplus, ctx)
            .AddRow(nameof(action.c), action.c, ctx)
            .AddRow(nameof(action.countRef), action.countRef, ctx)
            .AddRow(nameof(action.failureEvent), action.failureEvent, ctx)
            .AddRow(nameof(action.gameObject), action.gameObject, ctx)
            .AddRow(nameof(action.nullOn), action.nullOn, ctx)
            .AddRow(nameof(action.objType), action.objType, ctx)
            .AddRow(nameof(action.reference), action.reference, ctx)
            .AddRow(nameof(action.restartbool), action.restartbool, ctx)
            .AddRow(nameof(action.sortOn), action.sortOn, ctx)
            .BuildTable();
}
