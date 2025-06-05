using System;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter;

internal record ActionContext(PlayMakerFSM Fsm, FsmState State, int StateIndex, FsmStateAction Action, int ActionIndex, Dictionary<string,string> EventToState)
{
    public Type ActionType => Action.GetActualType();
    public object ActionCasted = Action.TryCast();
    public static ActionContext Create(StateContext ctx, FsmStateAction Action, int ActionIndex) =>
        new(ctx.Fsm, ctx.State, ctx.StateIndex, Action, ActionIndex, ctx.EventToState);
}
internal static class ActionContextExtensions
{
    public static string GetEventState(this ActionContext ctx, string eventName, string defaultString = "*Unknown*") =>
        ctx is null || eventName is null
        ? defaultString
        : ctx.EventToState.GetValueOrDefault(eventName, defaultString);
    public static string GetEventState(this ActionContext ctx, FsmEvent fsmEvent, string defaultString = "*Unknown*") =>
        ctx is null || fsmEvent is null || fsmEvent.Name is null
        ? defaultString
        : ctx.EventToState.GetValueOrDefault(fsmEvent.Name, defaultString);
    public static ActionContext Create(StateContext ctx, FsmStateAction Action, int ActionIndex) =>
        new(ctx.Fsm, ctx.State, ctx.StateIndex, Action, ActionIndex, ctx.EventToState);
}