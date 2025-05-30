using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker;
using Il2CppHutongGames.PlayMaker.Actions;
using UniverseLib;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    internal static StringBuilder DocStateActions(this StringBuilder sb, FsmState fsmState, int stateIndex, Dictionary<string, string> eventToState) =>
        fsmState is null || fsmState.Actions is null || fsmState.Actions.Count < 1
        ? sb
        : sb
            .AppendHeader($"### {stateIndex} {fsmState.Name}: Actions").DocEachStateAction(fsmState, stateIndex, eventToState);

    private static StringBuilder DocEachStateAction(this StringBuilder sb, FsmState fsmState, int stateIndex, Dictionary<string, string> eventToState)
    {
        if (fsmState is null || fsmState.Actions is null || fsmState.Actions.Count < 1)
            return sb;
        for (int actionIndex = 0; actionIndex < fsmState.Actions.Count; actionIndex++)
        {
            var action = fsmState.Actions[0];
            var type = fsmState.Actions[0].GetActualType();
            var context = new ActionContext(action.fsmComponent, fsmState, stateIndex, action, actionIndex, eventToState);
            sb
                .AppendHeader($"#### Action: {stateIndex}-{actionIndex} {type.Name}")
                .DocStateActionGeneralDetails(context)
                .DocStateActionTypeDetails(context);
        }
        return sb;
    }
    private static StringBuilder DocStateActionTypeDetails(this StringBuilder sb, ActionContext context) =>
        context is null || context.Action is null || context.EventToState is null
        ? sb
        : context.Action.GetActualType().FullName switch
        {
            "Il2CppHutongGames.PlayMaker.Actions.ActivateGameObject" => sb.DocActionActivateGameObject(context.Action.TryCast<ActivateGameObject>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListGet" => sb.DocActionArrayListGet(context.Action.TryCast<ArrayListGet>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListSet" => sb.DocActionArrayListSet(context.Action.TryCast<ArrayListSet>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle" => sb.DocActionArrayListShuffle(context.Action.TryCast<ArrayListShuffle>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmArray" => sb.DocActionGetFsmArray(context.Action.TryCast<GetFsmArray>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmArrayItem" => sb.DocActionGetFsmArrayItem(context.Action.TryCast<GetFsmArrayItem>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmBool" => sb.DocActionGetFsmBool(context.Action.TryCast<GetFsmBool>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmFloat" => sb.DocActionGetFsmFloat(context.Action.TryCast<GetFsmFloat>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmGameObject" => sb.DocActionGetFsmGameObject(context.Action.TryCast<GetFsmGameObject>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmInt" => sb.DocActionGetFsmInt(context.Action.TryCast<GetFsmInt>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmMaterial" => sb.DocActionGetFsmMaterial(context.Action.TryCast<GetFsmMaterial>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmState" => sb.DocActionGetFsmState(context.Action.TryCast<GetFsmState>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmString" => sb.DocActionGetFsmString(context.Action.TryCast<GetFsmString>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmTexture" => sb.DocActionGetFsmTexture(context.Action.TryCast<GetFsmTexture>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmVariable" => sb.DocActionGetFsmVariable(context.Action.TryCast<GetFsmVariable>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmVector3" => sb.DocActionGetFsmVector3(context.Action.TryCast<GetFsmVector3>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.IntCompare" => sb.DocActionIntCompare(context.Action.TryCast<IntCompare>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent" => sb.DocActionSendRandomEvent(context.Action.TryCast<SendRandomEvent>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmArray" => sb.DocActionSetFsmArray(context.Action.TryCast<SetFsmArray>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmBool" => sb.DocActionSetFsmBool(context.Action.TryCast<SetFsmBool>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmColor" => sb.DocActionSetFsmColor(context.Action.TryCast<SetFsmColor>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmFloat" => sb.DocActionSetFsmFloat(context.Action.TryCast<SetFsmFloat>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmGameObject" => sb.DocActionSetFsmGameObject(context.Action.TryCast<SetFsmGameObject>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmInt" => sb.DocActionSetFsmInt(context.Action.TryCast<SetFsmInt>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmObject" => sb.DocActionSetFsmObject(context.Action.TryCast<SetFsmObject>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmString" => sb.DocActionSetFsmString(context.Action.TryCast<SetFsmString>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmTexture" => sb.DocActionSetFsmTexture(context.Action.TryCast<SetFsmTexture>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmVariable" => sb.DocActionSetFsmVariable(context.Action.TryCast<SetFsmVariable>(), context),
            "Il2CppHutongGames.PlayMaker.Actions.Wait" => sb.DocActionWait(context.Action.TryCast<Wait>(), context),
            _ => sb
        };
    private static StringBuilder DocStateActionGeneralDetails(this StringBuilder sb, ActionContext context) =>
        context is null || context.Action is null
        ? sb
        : sb.AppendHeader("General Action Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(context.ActionIndex), context.ActionIndex)
            .AddRow("Type", context.Action.GetActualType().Name)
            .AddRow(nameof(context.Action.BlocksFinish), context.Action.BlocksFinish)
            .AddRow(nameof(context.Action.Enabled), context.Action.Enabled)
            .AddRow(nameof(context.Action.Name), context.Action.Name)
            .BuildTable();
}