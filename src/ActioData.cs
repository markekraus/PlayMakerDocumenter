using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter;

internal record ActionContext(PlayMakerFSM Fsm, FsmState State, int StateIndex, FsmStateAction Action, int ActionIndex, Dictionary<string,string> EventToState);

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
}