using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record setTextmeshProTextColorDoc : FsmActionDoc
{
    internal setTextmeshProTextColorDoc(ActionContext Ctx, setTextmeshProTextColor action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.meshproScript), action.meshproScript);
        this.AddProperty(nameof(action.textColor), action.textColor);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static setTextmeshProTextColorDoc Document(this ActionContext ctx, setTextmeshProTextColor Action) =>
        new(ctx, Action);
}
