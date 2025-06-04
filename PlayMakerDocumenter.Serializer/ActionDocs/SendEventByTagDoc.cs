using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SendEventByTagDoc : FsmActionDoc
{
    internal SendEventByTagDoc(ActionContext Ctx, SendEventByTag action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.fsmName), action.fsmName);
        this.AddProperty(nameof(action.gos), action.gos);
        this.AddProperty(nameof(action.layer), action.layer);
        this.AddProperty(nameof(action.layerFilterOn), action.layerFilterOn);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        this.AddProperty(nameof(action.sendEventName), action.sendEventName);
        this.AddProperty(nameof(action.tag), action.tag);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SendEventByTagDoc Document(this ActionContext ctx, SendEventByTag Action) =>
        new(ctx, Action);
}
