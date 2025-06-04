using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListSubtractArrayListDoc : FsmActionDoc
{
    internal ArrayListSubtractArrayListDoc(ActionContext Ctx, ArrayListSubtractArrayList action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.ObjectWithSubtractArray), action.ObjectWithSubtractArray);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.SubtractReference), action.SubtractReference);
        this.AddProperty(nameof(action.Type), action.Type);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListSubtractArrayListDoc Document(this ActionContext ctx, ArrayListSubtractArrayList Action) =>
        new(ctx, Action);
}
