using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record TrackIncreaseLevelActionDoc : FsmActionDoc
{
    internal TrackIncreaseLevelActionDoc(ActionContext Ctx, TrackIncreaseLevelAction action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.GroupID), action.GroupID);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static TrackIncreaseLevelActionDoc Document(this ActionContext ctx, TrackIncreaseLevelAction Action) =>
        new(ctx, Action);
}
