using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IntSubtractDoc : FsmActionDoc
{
    internal IntSubtractDoc(ActionContext Ctx, IntSubtract action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action._acc), action._acc);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        this.AddProperty(nameof(action.perSecond), action.perSecond);
        this.AddProperty(nameof(action.subtract), action.subtract);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IntSubtractDoc Document(this ActionContext ctx, IntSubtract Action) =>
        new(ctx, Action);
}
