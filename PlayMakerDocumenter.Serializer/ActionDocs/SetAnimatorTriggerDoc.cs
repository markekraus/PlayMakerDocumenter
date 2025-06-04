using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetAnimatorTriggerDoc : FsmActionDoc
{
    internal SetAnimatorTriggerDoc(ActionContext Ctx, SetAnimatorTrigger action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.trigger), action.trigger);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetAnimatorTriggerDoc Document(this ActionContext ctx, SetAnimatorTrigger Action) =>
        new(ctx, Action);
}
