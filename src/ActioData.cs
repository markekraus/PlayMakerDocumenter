using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter;

internal record ActionContext(PlayMakerFSM Fsm, FsmState State, int StateIndex, FsmStateAction Action, int ActionIndex, Dictionary<string,string> EventToState);

internal static class ActionContextExtensions
{
    public static string GetEventState(this ActionContext ctx, string eventName) =>
        ctx is null || eventName is null
        ? string.Empty
        : ctx.EventToState.GetValueOrDefault(eventName, string.Empty);
    public static string GetEventState(this ActionContext ctx, FsmEvent fsmEvent) =>
        ctx is null || fsmEvent is null || fsmEvent.Name is null
        ? string.Empty
        : ctx.EventToState.GetValueOrDefault(fsmEvent.Name, string.Empty);
}