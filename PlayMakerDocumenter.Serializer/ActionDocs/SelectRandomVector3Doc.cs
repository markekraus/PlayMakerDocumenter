using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SelectRandomVector3Doc : FsmActionDoc
{
    internal SelectRandomVector3Doc(ActionContext Ctx, SelectRandomVector3 action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.storeVector3), action.storeVector3);
        this.AddProperty(nameof(action.vector3Array), action.vector3Array);
        this.AddProperty(nameof(action.weights), action.weights);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SelectRandomVector3Doc Document(this ActionContext ctx, SelectRandomVector3 Action) =>
        new(ctx, Action);
}
