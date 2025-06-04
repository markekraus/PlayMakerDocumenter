using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record MoveTowardsDoc : FsmActionDoc
{
    internal MoveTowardsDoc(ActionContext Ctx, MoveTowards action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.finishDistance), action.finishDistance);
        this.AddProperty(nameof(action.finishEvent), action.finishEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.go), action.go);
        this.AddProperty(nameof(action.goTarget), action.goTarget);
        this.AddProperty(nameof(action.ignoreVertical), action.ignoreVertical);
        this.AddProperty(nameof(action.maxSpeed), action.maxSpeed);
        this.AddProperty(nameof(action.targetObject), action.targetObject);
        this.AddProperty(nameof(action.targetPos), action.targetPos);
        this.AddProperty(nameof(action.targetPosition), action.targetPosition);
        this.AddProperty(nameof(action.targetPosWithVertical), action.targetPosWithVertical);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static MoveTowardsDoc Document(this ActionContext ctx, MoveTowards Action) =>
        new(ctx, Action);
}
