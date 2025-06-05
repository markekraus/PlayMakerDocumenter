using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMaterialDoc : FsmActionDoc
{
    internal SetMaterialDoc(ActionContext Ctx, SetMaterial action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.material), action.material);
        this.AddProperty(nameof(action.materialIndex), action.materialIndex);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMaterialDoc Document(this ActionContext ctx, SetMaterial Action) =>
        new(ctx, Action);
}
