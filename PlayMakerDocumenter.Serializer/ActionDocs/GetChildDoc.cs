using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetChildDoc : FsmActionDoc
{
    internal GetChildDoc(ActionContext Ctx, GetChild action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.childName), action.childName);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.withTag), action.withTag);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetChildDoc Document(this ActionContext ctx, GetChild Action) =>
        new(ctx, Action);
}
