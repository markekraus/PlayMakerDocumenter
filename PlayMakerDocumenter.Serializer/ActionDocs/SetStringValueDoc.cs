using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetStringValueDoc : FsmActionDoc
{
    internal SetStringValueDoc(ActionContext Ctx, SetStringValue action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.stringValue), action.stringValue);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetStringValueDoc Document(this ActionContext ctx, SetStringValue Action) =>
        new(ctx, Action);
}
