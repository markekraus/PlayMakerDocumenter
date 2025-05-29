using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmState(this StringBuilder sb, GetFsmState action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmState)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.fsm), action.fsm)
            .AddRow(nameof(action.fsmComponent), action.fsmComponent)
            .AddRow(nameof(action.fsmName), action.fsmName)
            .AddRow(nameof(action.gameObject), action.gameObject, action)
            .BuildTable();
}
