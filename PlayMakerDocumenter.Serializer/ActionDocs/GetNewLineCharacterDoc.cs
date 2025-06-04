using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record GetNewLineCharacterDoc : FsmActionDoc
{
    internal GetNewLineCharacterDoc(ActionContext Ctx, GetNewLineCharacter action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.newLine), action.newLine);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static GetNewLineCharacterDoc Document(this ActionContext ctx, GetNewLineCharacter Action) =>
        new(ctx, Action);
}
