using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record setTextmeshProTextDoc : FsmActionDoc
{
    internal setTextmeshProTextDoc(ActionContext Ctx, setTextmeshProText action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.everyFrame), action.everyFrame);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.meshproScript), action.meshproScript);
        this.AddProperty(nameof(action.textString), action.textString);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static setTextmeshProTextDoc Document(this ActionContext ctx, setTextmeshProText Action) =>
        new(ctx, Action);
}
