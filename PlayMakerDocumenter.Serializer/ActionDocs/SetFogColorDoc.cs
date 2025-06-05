using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetFogColorDoc : FsmActionDoc
{
    internal SetFogColorDoc(ActionContext Ctx, SetFogColor action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.fogColor), action.fogColor);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetFogColorDoc Document(this ActionContext ctx, SetFogColor Action) =>
        new(ctx, Action);
}
