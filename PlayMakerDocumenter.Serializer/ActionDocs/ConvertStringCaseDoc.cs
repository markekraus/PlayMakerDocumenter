using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertStringCaseDoc : FsmActionDoc
{
    internal ConvertStringCaseDoc(ActionContext Ctx, ConvertStringCase action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.operation), action.operation);
        this.AddProperty(nameof(action.result), action.result);
        this.AddProperty(nameof(action.String), action.String);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertStringCaseDoc Document(this ActionContext ctx, ConvertStringCase Action) =>
        new(ctx, Action);
}
