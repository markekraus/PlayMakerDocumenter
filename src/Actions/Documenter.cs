using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker;
using Il2CppHutongGames.PlayMaker.Actions;
using UniverseLib;

namespace PlayMakerDocumenter.Actions;

public static partial class Documenter
{
    internal static StringBuilder DocStateActions(this StringBuilder sb, FsmState fsmState, int stateIndex, Dictionary<string, string> eventToState) =>
        fsmState is null || fsmState.Actions is null || fsmState.Actions.Count < 1
        ? sb
        : sb.DocEachStateAction(fsmState, stateIndex, eventToState);

    private static StringBuilder DocEachStateAction(this StringBuilder sb, FsmState fsmState, int stateIndex, Dictionary<string, string> eventToState)
    {
        if (fsmState is null || fsmState.Actions is null || fsmState.Actions.Count < 1)
            return sb;
        for (int actionIndex = 0; actionIndex < fsmState.Actions.Count; actionIndex++)
        {
            var action = fsmState.Actions[0];
            var type = fsmState.Actions[0].GetActualType();
            sb
                .AppendHeader($"### {stateIndex} {fsmState.Name} - Action {actionIndex}: {type.Name}")
                .DocStateActionGeneralDetails(action, actionIndex)
                .DocStateActionTypeDetails(action, eventToState);
        }
        return sb;
    }
    private static StringBuilder DocStateActionTypeDetails(this StringBuilder sb, FsmStateAction action, Dictionary<string, string> eventToState) =>
        action is null || eventToState is null
        ? sb
        : action.GetActualType().FullName switch
        {
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListGet" => sb.DocActionArrayListGet(action.TryCast<ArrayListGet>(), eventToState),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListSet" => sb.DocActionArrayListSet(action.TryCast<ArrayListSet>()),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle" => sb.DocActionArrayListShuffle(action.TryCast<ArrayListShuffle>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmArray" => sb.DocActionGetFsmArray(action.TryCast<GetFsmArray>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmArrayItem" => sb.DocActionGetFsmArrayItem(action.TryCast<GetFsmArrayItem>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmBool" => sb.DocActionGetFsmBool(action.TryCast<GetFsmBool>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmFloat" => sb.DocActionGetFsmFloat(action.TryCast<GetFsmFloat>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmGameObject" => sb.DocActionGetFsmGameObject(action.TryCast<GetFsmGameObject>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmInt" => sb.DocActionGetFsmInt(action.TryCast<GetFsmInt>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmMaterial" => sb.DocActionGetFsmMaterial(action.TryCast<GetFsmMaterial>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmState" => sb.DocActionGetFsmState(action.TryCast<GetFsmState>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmString" => sb.DocActionGetFsmString(action.TryCast<GetFsmString>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmTexture" => sb.DocActionGetFsmTexture(action.TryCast<GetFsmTexture>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmVariable" => sb.DocActionGetFsmVariable(action.TryCast<GetFsmVariable>()),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmVector3" => sb.DocActionGetFsmVector3(action.TryCast<GetFsmVector3>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmArray" => sb.DocActionSetFsmArray(action.TryCast<SetFsmArray>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmBool" => sb.DocActionSetFsmBool(action.TryCast<SetFsmBool>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmColor" => sb.DocActionSetFsmColor(action.TryCast<SetFsmColor>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmFloat" => sb.DocActionSetFsmFloat(action.TryCast<SetFsmFloat>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmGameObject" => sb.DocActionSetFsmGameObject(action.TryCast<SetFsmGameObject>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmInt" => sb.DocActionSetFsmInt(action.TryCast<SetFsmInt>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmObject" => sb.DocActionSetFsmObject(action.TryCast<SetFsmObject>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmString" => sb.DocActionSetFsmString(action.TryCast<SetFsmString>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmTexture" => sb.DocActionSetFsmTexture(action.TryCast<SetFsmTexture>()),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmVariable" => sb.DocActionSetFsmVariable(action.TryCast<SetFsmVariable>()),
            "Il2CppHutongGames.PlayMaker.Actions.IntCompare" => sb.DocActionIntCompare(action.TryCast<IntCompare>(), eventToState),
            "Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent" => sb.DocActionSendRandomEvent(action.TryCast<SendRandomEvent>(), eventToState),
            "Il2CppHutongGames.PlayMaker.Actions.Wait" => sb.DocActionWait(action.TryCast<Wait>(), eventToState),
            _ => sb
        };
    private static StringBuilder DocStateActionGeneralDetails(this StringBuilder sb, FsmStateAction action, int actionIndex) =>
        action is null
        ? sb
        : sb.AppendHeader("General Action Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("Action Index", $"{actionIndex}")
            .AddRow("Type", action.GetActualType().Name)
            .AddRow("BlocksFinish", $"{action.BlocksFinish}")
            .AddRow("Enabled", $"{action.Enabled}")
            .AddRow("Name", $"{action.Name}")
            .BuildTable();
}