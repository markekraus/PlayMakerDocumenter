using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record StringCompareDoc : FsmActionDoc
{
    internal StringCompareDoc(ActionContext Ctx, StringCompare action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.compareTo), action.compareTo);
        this.AddProperty(nameof(action.equalEvent), action.equalEvent);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.notEqualEvent), action.notEqualEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        this.AddProperty(nameof(action.stringVariable), action.stringVariable);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static StringCompareDoc Document(this ActionContext ctx, StringCompare Action) =>
        new(ctx, Action);
}
