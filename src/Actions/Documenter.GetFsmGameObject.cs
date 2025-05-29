using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionGetFsmGameObject(this StringBuilder sb, GetFsmGameObject action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmGameObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsm, fsm =>
                new string[] { nameof(fsm), fsm.GetFullPath() })
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddRowIfNotNull(action.fsmNameLastFrame, fsmNameLastFrame =>
                new string[] { nameof(fsmNameLastFrame), fsmNameLastFrame })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.goLastFrame, goLastFrame =>
                new string[] { nameof(goLastFrame), goLastFrame.GetFullPath() })
            .AddRowIfNotNull(action.storeValue, storeValue =>
                new string[] { nameof(storeValue), storeValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
}
