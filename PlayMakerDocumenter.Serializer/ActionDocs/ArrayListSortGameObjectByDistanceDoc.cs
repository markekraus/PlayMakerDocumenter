using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListSortGameObjectByDistanceDoc : FsmActionDoc
{
    internal ArrayListSortGameObjectByDistanceDoc(ActionContext Ctx, ArrayListSortGameObjectByDistance action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.distanceFrom), action.distanceFrom);
        this.AddProperty(nameof(action.everyframe), action.everyframe);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.orDistanceFromVector3), action.orDistanceFromVector3);
        this.AddProperty(nameof(action.reference), action.reference);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListSortGameObjectByDistanceDoc Document(this ActionContext ctx, ArrayListSortGameObjectByDistance Action) =>
        new(ctx, Action);
}
