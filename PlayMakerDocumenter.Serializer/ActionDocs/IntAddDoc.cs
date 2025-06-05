using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record IntAddDoc : FsmActionDoc
{
    internal IntAddDoc(ActionContext Ctx, IntAdd action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.add), action.add);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static IntAddDoc Document(this ActionContext ctx, IntAdd Action) =>
        new(ctx, Action);
}
