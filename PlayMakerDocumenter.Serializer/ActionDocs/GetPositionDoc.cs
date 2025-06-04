using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetPositionDoc : FsmActionDoc
{
    internal GetPositionDoc(ActionContext Ctx, GetPosition action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.space), action.space);
        this.AddProperty(nameof(action.vector), action.vector);
        this.AddProperty(nameof(action.x), action.x);
        this.AddProperty(nameof(action.y), action.y);
        this.AddProperty(nameof(action.z), action.z);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetPositionDoc Document(this ActionContext ctx, GetPosition Action) =>
        new(ctx, Action);
}
