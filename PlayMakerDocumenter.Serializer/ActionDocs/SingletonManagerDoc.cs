using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SingletonManagerDoc : FsmActionDoc
{
    internal SingletonManagerDoc(ActionContext Ctx, SingletonManager action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.reference), action.reference);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SingletonManagerDoc Document(this ActionContext ctx, SingletonManager Action) =>
        new(ctx, Action);
}
