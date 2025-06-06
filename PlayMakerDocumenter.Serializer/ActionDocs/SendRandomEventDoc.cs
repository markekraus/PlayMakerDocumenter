using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SendRandomEventDoc : FsmActionDoc
{
    internal SendRandomEventDoc(ActionContext Ctx, SendRandomEvent action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.delay), action.delay);
        this.AddProperty(nameof(action.delayedEvent), action.delayedEvent);
        this.AddProperty(nameof(action.events), action.events);
        this.AddProperty(nameof(action.weights), action.weights);
        for (int i = 0; i < action.events.Count; i++)
        {
            var fsmEvent = action.events[i];
            string eventName;
            string stateName;
            (eventName, stateName) = fsmEvent is null
                ? ("null", "")
                : (fsmEvent.Name, ctx.GetEventState(fsmEvent));
            var fsmFloat = action.weights[i];
            var weight = fsmFloat?.Value;
            this.AddProperty($"weight: {weight}",$"Event: '{eventName}' State: '{stateName}'");
        }
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SendRandomEventDoc Document(this ActionContext ctx, SendRandomEvent Action) =>
        new(ctx, Action);
}
