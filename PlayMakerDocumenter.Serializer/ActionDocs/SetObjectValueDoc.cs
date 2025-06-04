using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetObjectValueDoc : FsmActionDoc
{
    internal SetObjectValueDoc(ActionContext Ctx, SetObjectValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.objectValue), action.objectValue);
        this.AddProperty(nameof(action.objectVariable), action.objectVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetObjectValueDoc Document(this ActionContext ctx, SetObjectValue Action) =>
        new(ctx, Action);
}
