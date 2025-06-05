using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record StringContainsDoc : FsmActionDoc
{
    internal StringContainsDoc(ActionContext Ctx, StringContains action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.containsString), action.containsString);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.falseEvent), action.falseEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        this.AddProperty(nameof(action.trueEvent), action.trueEvent);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static StringContainsDoc Document(this ActionContext ctx, StringContains Action) =>
        new(ctx, Action);
}
