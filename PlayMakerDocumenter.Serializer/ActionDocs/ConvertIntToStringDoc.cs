using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertIntToStringDoc : FsmActionDoc
{
    internal ConvertIntToStringDoc(ActionContext Ctx, ConvertIntToString action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.format), action.format);
        this.AddProperty(nameof(action.intVariable), action.intVariable);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertIntToStringDoc Document(this ActionContext ctx, ConvertIntToString Action) =>
        new(ctx, Action);
}
