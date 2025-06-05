using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetNameDoc : FsmActionDoc
{
    internal GetNameDoc(ActionContext Ctx, GetName action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.storeName), action.storeName);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetNameDoc Document(this ActionContext ctx, GetName Action) =>
        new(ctx, Action);
}
