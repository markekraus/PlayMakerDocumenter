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
            new string[] { nameof(fsmName), fsmName.FormatValue() })
        .AddGameObjectRows(action, action.gameObject)
        .AddRowIfNotNull(action.storeValue, storeValue =>
            new string[] { nameof(storeValue), storeValue.FormatValue() })
        .AddRowIfNotNull(action.variableName, variableName =>
            new string[] { nameof(variableName), variableName.FormatValue() })
        .BuildTable();
    private static StringBuilder DocActionGetFsmArrayItem(this StringBuilder sb, GetFsmArrayItem action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmArrayItem)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.index, index =>
                new string[] { nameof(index), $"{index.Value}" })
            .AddRowIfNotNull(action.storeValue, storeValue =>
                new string[] { "storeValue.Type", $"{storeValue.Type}" })
            .AddRowIfNotNull(action.storeValue, storeValue =>
                new string[] { "storeValue.Value", storeValue.GetValue(action.fsmComponent) })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionGetFsmBool(this StringBuilder sb, GetFsmBool action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmBool)} Details:")
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
    private static StringBuilder DocActionGetFsmFloat(this StringBuilder sb, GetFsmFloat action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmFloat)} Details:")
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
                new string[] { "storeValue.Value", storeValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
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
    private static StringBuilder DocActionGetFsmInt(this StringBuilder sb, GetFsmInt action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmInt)} Details:")
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
    private static StringBuilder DocActionGetFsmMaterial(this StringBuilder sb, GetFsmMaterial action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmMaterial)} Details:")
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
    private static StringBuilder DocActionGetFsmState(this StringBuilder sb, GetFsmState action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmState)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsm, fsm =>
                new string[] { nameof(fsm), fsm.GetFullPath() })
            .AddRowIfNotNull(action.fsmComponent, fsmComponent =>
                new string[] { nameof(fsmComponent), fsmComponent.GetFullPath() })
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .BuildTable();
    private static StringBuilder DocActionGetFsmString(this StringBuilder sb, GetFsmString action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmString)} Details:")
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
    private static StringBuilder DocActionGetFsmTexture(this StringBuilder sb, GetFsmTexture action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmTexture)} Details:")
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
    private static StringBuilder DocActionGetFsmVariable(this StringBuilder sb, GetFsmVariable action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmVariable)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.sourceFsm, sourceFsm =>
                new string[] { nameof(sourceFsm), sourceFsm.GetFullPath() })
            .BuildTable();
    private static StringBuilder DocActionGetFsmVector3(this StringBuilder sb, GetFsmVector3 action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(GetFsmVector3)} Details:")
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
    private static StringBuilder DocActionSetFsmArray(this StringBuilder sb, SetFsmArray action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmArray)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("copyValues", $"{action.copyValues}")
            .AddRowIfNotNull(action.fsm, fsm =>
                new string[] { nameof(fsm), fsm.GetFullPath() })
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmBool(this StringBuilder sb, SetFsmBool action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmBool)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmColor(this StringBuilder sb, SetFsmColor action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmColor)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmFloat(this StringBuilder sb, SetFsmFloat action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmFloat)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmGameObject(this StringBuilder sb, SetFsmGameObject action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmGameObject)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmInt(this StringBuilder sb, SetFsmInt action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmInt)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmObject(this StringBuilder sb, SetFsmObject action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmObject)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmString(this StringBuilder sb, SetFsmString action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmString)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmTexture(this StringBuilder sb, SetFsmTexture action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmTexture)} Details:")
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
            .AddRowIfNotNull(action.setValue, setValue =>
                new string[] { nameof(setValue), setValue.FormatValue() })
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
    private static StringBuilder DocActionSetFsmVariable(this StringBuilder sb, SetFsmVariable action) =>
        action is null
        ? sb
        : sb.AppendHeader($"{nameof(SetFsmVariable)} Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRow("everyFrame", $"{action.everyFrame}")
            .AddRowIfNotNull(action.fsmName, fsmName =>
                new string[] { nameof(fsmName), fsmName.FormatValue() })
            .AddGameObjectRows(action, action.gameObject)
            .AddRowIfNotNull(action.variableName, variableName =>
                new string[] { nameof(variableName), variableName.FormatValue() })
            .BuildTable();
}