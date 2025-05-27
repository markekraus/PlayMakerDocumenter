using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter;

public static partial class FsmDocumenter
{
        private static StringBuilder DocActionGetFsmArray(this StringBuilder sb, GetFsmArray action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmArray)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("copyValues", $"{action.copyValues}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { "fsmName", $"{fsmName.Value}" })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.gameObject, gameObject =>
                new string[] { "gameObject.OwnerOption", $"{gameObject.OwnerOption}" })
            .AddRowIfNotNull(action.gameObject, gameObject =>
                new string[] { "GameObject Path", $"{GetFsmOwnerDefaultPath(gameObject, action.fsmComponent)}" })
            .AddRowIfNotNull(action.storeValue, storeValue =>
                new string[] { "storeValue.Name", $"{storeValue.Name}" })
            .AddRowIfNotNull(action.storeValue, storeValue =>
                new string[] { "storeValue.Length", $"{storeValue.Length}" })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { "variableName", $"{variableName.Value}" })
            .BuildTable();
    private static StringBuilder DocActionGetFsmArrayItem(this StringBuilder sb, GetFsmArrayItem action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmArrayItem)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmBool(this StringBuilder sb, GetFsmBool action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmBool)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmFloat(this StringBuilder sb, GetFsmFloat action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmFloat)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmGameObject(this StringBuilder sb, GetFsmGameObject action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmGameObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmInt(this StringBuilder sb, GetFsmInt action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmInt)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmMaterial(this StringBuilder sb, GetFsmMaterial action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmMaterial)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmState(this StringBuilder sb, GetFsmState action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmState)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmString(this StringBuilder sb, GetFsmString action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmString)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmTexture(this StringBuilder sb, GetFsmTexture action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmTexture)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmVariable(this StringBuilder sb, GetFsmVariable action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmVariable)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionGetFsmVector3(this StringBuilder sb, GetFsmVector3 action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmVector3)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmArray(this StringBuilder sb, SetFsmArray action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmArray)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmBool(this StringBuilder sb, SetFsmBool action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmBool)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmColor(this StringBuilder sb, SetFsmColor action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmColor)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmFloat(this StringBuilder sb, SetFsmFloat action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmFloat)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmGameObject(this StringBuilder sb, SetFsmGameObject action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmGameObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmInt(this StringBuilder sb, SetFsmInt action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmInt)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmObject(this StringBuilder sb, SetFsmObject action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmObject)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmString(this StringBuilder sb, SetFsmString action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmString)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmTexture(this StringBuilder sb, SetFsmTexture action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmTexture)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
    private static StringBuilder DocActionSetFsmVariable(this StringBuilder sb, SetFsmVariable action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmVariable)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .BuildTable();
}