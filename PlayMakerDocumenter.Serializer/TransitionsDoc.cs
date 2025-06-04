using System;
using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace PlayMakerDocumenter.Serializer;

public class TransitionsDoc : SortedDictionary<string, string>
{
    private static StringComparer comparer = StringComparer.InvariantCultureIgnoreCase;
    public TransitionsDoc() : base(comparer) { }
    private TransitionsDoc(Il2CppReferenceArray<FsmTransition> transitions) : base(comparer)
    {
        foreach (var transition in transitions)
            Add(transition.EventName, transition.ToState);
    }

    public static implicit operator TransitionsDoc(Il2CppReferenceArray<FsmTransition> transitions) =>
        new(transitions);
    public static implicit operator TransitionsDoc(PlayMakerFSM Fsm) =>
        new(Fsm.FsmGlobalTransitions);
}