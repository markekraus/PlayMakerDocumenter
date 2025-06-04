using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record StringReplaceDoc : FsmActionDoc
{
    internal StringReplaceDoc(ActionContext Ctx, StringReplace action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.replace), action.replace);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        this.AddProperty(nameof(action.with), action.with);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static StringReplaceDoc Document(this ActionContext ctx, StringReplace Action) =>
        new(ctx, Action);
}
