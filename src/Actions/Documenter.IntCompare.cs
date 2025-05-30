using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    

    private static StringBuilder DocActionIntCompare(this StringBuilder sb, IntCompare action, ActionContext actionData) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(IntCompare)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.integer1), action.integer1)
            .AddRow(nameof(action.integer2), action.integer2)
            .AddRow(nameof(action.equal), action.equal, actionData.EventToState)
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.greaterThan), action.greaterThan, actionData.EventToState)
            .AddRow(nameof(action.lessThan), action.lessThan, actionData.EventToState)
            .BuildTable();
}
