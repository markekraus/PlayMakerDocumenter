using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record RandomIntDoc : FsmActionDoc
{
    internal RandomIntDoc(ActionContext Ctx, RandomInt action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.inclusiveMax), action.inclusiveMax);
        this.AddProperty(nameof(action.lastIndex), action.lastIndex);
        this.AddProperty(nameof(action.max), action.max);
        this.AddProperty(nameof(action.min), action.min);
        this.AddProperty(nameof(action.noRepeat), action.noRepeat);
        this.AddProperty(nameof(action.randomIndex), action.randomIndex);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static RandomIntDoc Document(this ActionContext ctx, RandomInt Action) =>
        new(ctx, Action);
}
