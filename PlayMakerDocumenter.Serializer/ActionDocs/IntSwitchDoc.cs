using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IntSwitchDoc : FsmActionDoc
{
    internal IntSwitchDoc(ActionContext Ctx, IntSwitch action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.compareTo), action.compareTo);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        this.AddProperty(nameof(action.sendEvent), action.sendEvent);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IntSwitchDoc Document(this ActionContext ctx, IntSwitch Action) =>
        new(ctx, Action);
}
