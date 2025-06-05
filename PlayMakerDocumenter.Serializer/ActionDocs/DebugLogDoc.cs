using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record DebugLogDoc : FsmActionDoc
{
    internal DebugLogDoc(ActionContext Ctx, DebugLog action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.logLevel), action.logLevel);
        this.AddProperty(nameof(action.text), action.text);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static DebugLogDoc Document(this ActionContext ctx, DebugLog Action) =>
        new(ctx, Action);
}
