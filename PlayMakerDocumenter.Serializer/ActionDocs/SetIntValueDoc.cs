using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetIntValueDoc : FsmActionDoc
{
    internal SetIntValueDoc(ActionContext Ctx, SetIntValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.intValue), action.intValue);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetIntValueDoc Document(this ActionContext ctx, SetIntValue Action) =>
        new(ctx, Action);
}
