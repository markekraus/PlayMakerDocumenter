using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListAddDoc : FsmActionDoc
{
    internal ArrayListAddDoc(ActionContext Ctx, ArrayListAdd action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.convertIntToByte), action.convertIntToByte);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.index), action.index);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.variable), action.variable);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListAddDoc Document(this ActionContext ctx, ArrayListAdd Action) =>
        new(ctx, Action);
}
