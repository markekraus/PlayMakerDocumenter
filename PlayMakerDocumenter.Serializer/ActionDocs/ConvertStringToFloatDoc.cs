using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertStringToFloatDoc : FsmActionDoc
{
    internal ConvertStringToFloatDoc(ActionContext Ctx, ConvertStringToFloat action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.floatVariable), action.floatVariable);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertStringToFloatDoc Document(this ActionContext ctx, ConvertStringToFloat Action) =>
        new(ctx, Action);
}
