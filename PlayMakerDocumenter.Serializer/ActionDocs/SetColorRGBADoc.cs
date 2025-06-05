using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetColorRGBADoc : FsmActionDoc
{
    internal SetColorRGBADoc(ActionContext Ctx, SetColorRGBA action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.alpha), action.alpha);
        this.AddProperty(nameof(action.blue), action.blue);
        this.AddProperty(nameof(action.colorVariable), action.colorVariable);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.green), action.green);
        this.AddProperty(nameof(action.red), action.red);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetColorRGBADoc Document(this ActionContext ctx, SetColorRGBA Action) =>
        new(ctx, Action);
}
