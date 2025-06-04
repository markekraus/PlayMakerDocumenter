using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetVector3XYZDoc : FsmActionDoc
{
    internal GetVector3XYZDoc(ActionContext Ctx, GetVector3XYZ action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.storeX), action.storeX);
        this.AddProperty(nameof(action.storeY), action.storeY);
        this.AddProperty(nameof(action.storeZ), action.storeZ);
        this.AddProperty(nameof(action.vector3Variable), action.vector3Variable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetVector3XYZDoc Document(this ActionContext ctx, GetVector3XYZ Action) =>
        new(ctx, Action);
}
