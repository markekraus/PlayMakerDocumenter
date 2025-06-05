using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ActivateChildrenDoc : FsmActionDoc
{
    internal ActivateChildrenDoc(ActionContext Ctx, ActivateChildren action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.activate), action.activate);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.parent), action.parent);
        this.AddProperty(nameof(action.recursiveDepth), action.recursiveDepth);
        this.AddProperty(nameof(action.resetOnExit), action.resetOnExit);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ActivateChildrenDoc Document(this ActionContext ctx, ActivateChildren Action) =>
        new(ctx, Action);
}
