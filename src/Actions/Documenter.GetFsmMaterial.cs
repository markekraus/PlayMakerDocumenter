using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmMaterial(this StringBuilder sb, GetFsmMaterial action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmMaterial)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(action.everyFrame), action.everyFrame)
            .AddRow(nameof(action.fsm), action.fsm)
            .AddRow(nameof(action.fsmName), action.fsmName)
            .AddRow(nameof(action.fsmNameLastFrame), action.fsmNameLastFrame)
            .AddGameObjectRows(action, action.gameObject)
            .AddRow(nameof(action.goLastFrame), action.goLastFrame)
            .AddRow(nameof(action.storeValue), action.storeValue)
            .AddRow(nameof(action.variableName), action.variableName)
            .BuildTable();
}
