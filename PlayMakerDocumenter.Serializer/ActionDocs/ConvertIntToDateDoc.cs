using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ConvertIntToDateDoc : FsmActionDoc
{
    internal ConvertIntToDateDoc(ActionContext Ctx, ConvertIntToDate action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.dateInt), action.dateInt);
        this.AddProperty(nameof(action.dateString), action.dateString);
        this.AddProperty(nameof(action.dayOfMonth), action.dayOfMonth);
        this.AddProperty(nameof(action.dayOfWeek), action.dayOfWeek);
        this.AddProperty(nameof(action.month), action.month);
        this.AddProperty(nameof(action.year), action.year);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ConvertIntToDateDoc Document(this ActionContext ctx, ConvertIntToDate Action) =>
        new(ctx, Action);
}
