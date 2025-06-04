using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record BoolTestDoc : FsmActionDoc
{
    internal BoolTestDoc(ActionContext Ctx, BoolTest action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.boolVariable), action.boolVariable);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.isFalse), action.isFalse);
        this.AddProperty(nameof(action.isTrue), action.isTrue);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static BoolTestDoc Document(this ActionContext ctx, BoolTest Action) =>
        new(ctx, Action);
}
