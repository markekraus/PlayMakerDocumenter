using System;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace PlayMakerDocumenter.Serializer;
// TODO: Dictionary may not work. There are instance one-to-many mappings of event-to-state
public class TransitionsDoc : SortedDictionary<string, string>
{
    private static StringComparer comparer = StringComparer.InvariantCultureIgnoreCase;
    public TransitionsDoc() : base(comparer) { }
    private TransitionsDoc(Il2CppReferenceArray<FsmTransition> transitions) : base(comparer)
    {
        foreach (var transition in transitions)
        {
            if (transition.ToFsmState is null || string.IsNullOrWhiteSpace(transition.ToState)) continue;
            if (!this.TryAdd(transition.EventName, transition.ToState))
                LogWarn($"Duplicate key EventName: '{transition.EventName}' New ToState: '{transition.ToState}' Existing ToState: '{this[transition.EventName]}'");
        }
    }

    public static implicit operator TransitionsDoc(Il2CppReferenceArray<FsmTransition> transitions) =>
        new(transitions);
    public static implicit operator TransitionsDoc(PlayMakerFSM Fsm) =>
        new(Fsm.FsmGlobalTransitions);
}