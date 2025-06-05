using System;
using System.Collections.Generic;

namespace PlayMakerDocumenter.Serializer;

public class FsmStateTransitionsDoc : SortedDictionary<string, string>
{
    private static readonly StringComparer compare = StringComparer.InvariantCultureIgnoreCase;
    public FsmStateTransitionsDoc() : base(compare) { }
    public FsmStateTransitionsDoc(StateContext ctx) : base(compare)
    {
        if (ctx is null || ctx.State is null || ctx.State.Transitions is null) return;
        foreach (var transition in ctx.State.Transitions)
        {
            if (transition.ToFsmState is null) continue;
            Add(transition.EventName, transition.ToState);
            ctx.AddEventMap(transition.EventName, transition.ToState);
        }
    }
    public static implicit operator FsmStateTransitionsDoc(StateContext ctx) =>
        new(ctx);
}