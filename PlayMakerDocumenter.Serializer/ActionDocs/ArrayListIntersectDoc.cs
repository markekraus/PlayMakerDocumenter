using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListIntersectDoc : FsmActionDoc
{
    internal ArrayListIntersectDoc(ActionContext Ctx, ArrayListIntersect action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.arrayOne), action.arrayOne);
        this.AddProperty(nameof(action.arrayTwo), action.arrayTwo);
        this.AddProperty(nameof(action.clearArray), action.clearArray);
        this.AddProperty(nameof(action.gameObjectOne), action.gameObjectOne);
        this.AddProperty(nameof(action.gameObjectSave), action.gameObjectSave);
        this.AddProperty(nameof(action.gameObjectTwo), action.gameObjectTwo);
        this.AddProperty(nameof(action.referenceOne), action.referenceOne);
        this.AddProperty(nameof(action.referenceSave), action.referenceSave);
        this.AddProperty(nameof(action.referenceTwo), action.referenceTwo);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListIntersectDoc Document(this ActionContext ctx, ArrayListIntersect Action) =>
        new(ctx, Action);
}
