using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record DontDestroyOnLoadDoc : FsmActionDoc
{
    internal DontDestroyOnLoadDoc(ActionContext Ctx, DontDestroyOnLoad action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        ActionTypeSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static DontDestroyOnLoadDoc Document(this ActionContext ctx, DontDestroyOnLoad Action) =>
        new(ctx, Action);
}
