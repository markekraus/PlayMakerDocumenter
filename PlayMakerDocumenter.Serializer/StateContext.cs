using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer;

public record StateContext(PlayMakerFSM Fsm, FsmState State, int StateIndex, Dictionary<string,string> EventToState) : FsmContext(Fsm);

internal static class StateContextExtensions
{
    internal static bool AddEventMap(this StateContext ctx, string fsmEvent, string fsmState) =>
        ctx.EventToState.TryAdd(fsmEvent, fsmState);
}