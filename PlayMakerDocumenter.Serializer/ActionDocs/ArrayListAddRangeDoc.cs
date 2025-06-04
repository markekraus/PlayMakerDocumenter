using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListAddRangeDoc : FsmActionDoc
{
    internal ArrayListAddRangeDoc(ActionContext Ctx, ArrayListAddRange action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.convertIntsToBytes), action.convertIntsToBytes);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.variables), action.variables);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListAddRangeDoc Document(this ActionContext ctx, ArrayListAddRange Action) =>
        new(ctx, Action);
}
