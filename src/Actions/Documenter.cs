using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    internal static StringBuilder DocStateActions(this StringBuilder sb, StateContext ctx) =>
        ctx is null || ctx.State.Actions is null || ctx.State.Actions.Count < 1
        ? sb
        : sb
            .AppendHeader($"### {ctx.StateIndex} {ctx.State.Name}: Actions").DocEachStateAction(ctx);

    private static StringBuilder DocEachStateAction(this StringBuilder sb, StateContext ctx)
    {
        if (ctx.State is null || ctx.State.Actions is null || ctx.State.Actions.Count < 1)
            return sb;
        for (int actionIndex = 0; actionIndex < ctx.State.Actions.Count; actionIndex++)
        {
            var aCtx = ActionContext.Create(
                ctx,
                ctx.State.Actions[0],
                actionIndex);
            sb
                .AppendHeader($"#### Action: {aCtx.StateIndex}-{aCtx.ActionIndex} {aCtx.ActionType.Name}")
                .DocStateActionGeneralDetails(aCtx)
                .DocStateActionTypeDetails(aCtx);
        }
        return sb;
    }
    private static StringBuilder DocStateActionTypeDetails(this StringBuilder sb, ActionContext ctx) =>
        ctx is null || ctx.Action is null || ctx.EventToState is null
        ? sb
        : ctx.ActionType.FullName switch
        {
            "Il2CppHutongGames.PlayMaker.Actions.ActivateGameObject" => sb.DocActionActivateGameObject(ctx.Action.TryCast<ActivateGameObject>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListGet" => sb.DocActionArrayListGet(ctx.Action.TryCast<ArrayListGet>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListSet" => sb.DocActionArrayListSet(ctx.Action.TryCast<ArrayListSet>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.ArrayListShuffle" => sb.DocActionArrayListShuffle(ctx.Action.TryCast<ArrayListShuffle>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmArray" => sb.DocActionGetFsmArray(ctx.Action.TryCast<GetFsmArray>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmArrayItem" => sb.DocActionGetFsmArrayItem(ctx.Action.TryCast<GetFsmArrayItem>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmBool" => sb.DocActionGetFsmBool(ctx.Action.TryCast<GetFsmBool>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmFloat" => sb.DocActionGetFsmFloat(ctx.Action.TryCast<GetFsmFloat>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmGameObject" => sb.DocActionGetFsmGameObject(ctx.Action.TryCast<GetFsmGameObject>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmInt" => sb.DocActionGetFsmInt(ctx.Action.TryCast<GetFsmInt>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmMaterial" => sb.DocActionGetFsmMaterial(ctx.Action.TryCast<GetFsmMaterial>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmState" => sb.DocActionGetFsmState(ctx.Action.TryCast<GetFsmState>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmString" => sb.DocActionGetFsmString(ctx.Action.TryCast<GetFsmString>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmTexture" => sb.DocActionGetFsmTexture(ctx.Action.TryCast<GetFsmTexture>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmVariable" => sb.DocActionGetFsmVariable(ctx.Action.TryCast<GetFsmVariable>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.GetFsmVector3" => sb.DocActionGetFsmVector3(ctx.Action.TryCast<GetFsmVector3>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.IntCompare" => sb.DocActionIntCompare(ctx.Action.TryCast<IntCompare>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SendRandomEvent" => sb.DocActionSendRandomEvent(ctx.Action.TryCast<SendRandomEvent>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmArray" => sb.DocActionSetFsmArray(ctx.Action.TryCast<SetFsmArray>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmBool" => sb.DocActionSetFsmBool(ctx.Action.TryCast<SetFsmBool>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmColor" => sb.DocActionSetFsmColor(ctx.Action.TryCast<SetFsmColor>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmFloat" => sb.DocActionSetFsmFloat(ctx.Action.TryCast<SetFsmFloat>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmGameObject" => sb.DocActionSetFsmGameObject(ctx.Action.TryCast<SetFsmGameObject>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmInt" => sb.DocActionSetFsmInt(ctx.Action.TryCast<SetFsmInt>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmObject" => sb.DocActionSetFsmObject(ctx.Action.TryCast<SetFsmObject>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmString" => sb.DocActionSetFsmString(ctx.Action.TryCast<SetFsmString>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmTexture" => sb.DocActionSetFsmTexture(ctx.Action.TryCast<SetFsmTexture>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.SetFsmVariable" => sb.DocActionSetFsmVariable(ctx.Action.TryCast<SetFsmVariable>(), ctx),
            "Il2CppHutongGames.PlayMaker.Actions.Wait" => sb.DocActionWait(ctx.Action.TryCast<Wait>(), ctx),
            _ => sb
        };
    private static StringBuilder DocStateActionGeneralDetails(this StringBuilder sb, ActionContext ctx) =>
        ctx is null || ctx.Action is null
        ? sb
        : sb.AppendHeader("General Action Details:")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(ctx.ActionIndex), ctx.ActionIndex)
            .AddRow("Type", ctx.ActionType.Name)
            .AddRow(nameof(ctx.Action.BlocksFinish), ctx.Action.BlocksFinish)
            .AddRow(nameof(ctx.Action.Enabled), ctx.Action.Enabled)
            .AddRow(nameof(ctx.Action.Name), ctx.Action.Name)
            .BuildTable();
}