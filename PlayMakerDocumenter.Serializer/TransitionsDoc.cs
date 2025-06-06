using System;
using System.Collections.Generic;
using System.Linq;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace PlayMakerDocumenter.Serializer;

public class TransitionsDoc : List<EventToState>
{
    public TransitionsDoc() : base() { }
    private TransitionsDoc(Il2CppReferenceArray<FsmTransition> transitions) : base()
    {
        foreach (var transition in transitions.OrderBy(t => t.EventName))
        {
            if (transition.ToFsmState is null || string.IsNullOrWhiteSpace(transition.ToState)) continue;
            Add(new(transition.EventName, transition.ToState));
        }
    }

    public static implicit operator TransitionsDoc(Il2CppReferenceArray<FsmTransition> transitions) =>
        new(transitions);
    public static implicit operator TransitionsDoc(PlayMakerFSM Fsm) =>
        new(Fsm.FsmGlobalTransitions);
}