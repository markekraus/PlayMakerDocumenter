using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace PlayMakerDocumenter.Serializer;

public class FsmEventsDoc : List<FsmEventDoc>
{
    public FsmEventsDoc() : base() { }
    private FsmEventsDoc(Il2CppReferenceArray<FsmEvent> events) : base()
    {
        foreach (var fsmEvent in events)
            Add(fsmEvent);
    }
    public static implicit operator FsmEventsDoc(Il2CppReferenceArray<FsmEvent> events) =>
        events is null
        ? new()
        : new(events);
    public static implicit operator FsmEventsDoc(PlayMakerFSM Fsm) =>
        Fsm is null
        ? new()
        : new(Fsm.FsmEvents);
}
