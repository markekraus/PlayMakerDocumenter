using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record EnumCompareDoc : FsmActionDoc
{
    internal EnumCompareDoc(ActionContext Ctx, EnumCompare action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.compareTo), action.compareTo);
        this.AddProperty(nameof(action.enumVariable), action.enumVariable);
        this.AddProperty(nameof(action.equalEvent), action.equalEvent);
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.notEqualEvent), action.notEqualEvent);
        this.AddProperty(nameof(action.storeResult), action.storeResult);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static EnumCompareDoc Document(this ActionContext ctx, EnumCompare Action) =>
        new(ctx, Action);
}
