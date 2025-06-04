using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record SetMaterialColorDoc : FsmActionDoc
{
    internal SetMaterialColorDoc(ActionContext Ctx, SetMaterialColor action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.color), action.color);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.material), action.material);
        this.AddProperty(nameof(action.materialIndex), action.materialIndex);
        this.AddProperty(nameof(action.namedColor), action.namedColor);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static SetMaterialColorDoc Document(this ActionContext ctx, SetMaterialColor Action) =>
        new(ctx, Action);
}
