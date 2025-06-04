using Il2CppHutongGames.PlayMaker.Actions;
using PlayMakerDocumenter.Serializer.ActionProperties;

namespace PlayMakerDocumenter.Serializer.ActionDocs;

public record ArrayListDeleteDuplicatesDoc : FsmActionDoc
{
    internal ArrayListDeleteDuplicatesDoc(ActionContext Ctx, ArrayListDeleteDuplicates action) : base(Ctx)
    {
        if (action is null || Ctx is null) return;
        this.AddProperty(nameof(action.atIndex), action.atIndex);
        this.AddProperty(nameof(action.atIndex_iplus), action.atIndex_iplus);
        this.AddProperty(nameof(action.c), action.c);
        this.AddProperty(nameof(action.countRef), action.countRef);
        this.AddProperty(nameof(action.failureEvent), action.failureEvent);
        this.AddProperty(nameof(action.gameObject), action.gameObject);
        this.AddProperty(nameof(action.nullOn), action.nullOn);
        this.AddProperty(nameof(action.objType), action.objType);
        this.AddProperty(nameof(action.reference), action.reference);
        this.AddProperty(nameof(action.restartbool), action.restartbool);
        this.AddProperty(nameof(action.sortOn), action.sortOn);
        DocumentationSupported = true;
    }
}

internal static partial class ActionContextExtensions
{
    public static ArrayListDeleteDuplicatesDoc Document(this ActionContext ctx, ArrayListDeleteDuplicates Action) =>
        new(ctx, Action);
}
