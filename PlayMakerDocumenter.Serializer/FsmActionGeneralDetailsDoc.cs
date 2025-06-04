using MelonLoader.ICSharpCode.SharpZipLib.Core;
using UnityEngine;

namespace PlayMakerDocumenter.Serializer;

public record FsmActionGeneralDetailsDoc
{
    public int StateIndex;
    public int ActionIndex;
    public string Name;
    public string Type;
    public bool BlockFinish;
    public bool Enabled;
    public FsmActionGeneralDetailsDoc() { }
    public FsmActionGeneralDetailsDoc(ActionContext ctx)
    {
        StateIndex = ctx.StateIndex;
        ActionIndex = ctx.ActionIndex;
        Name = ctx.Action.Name;
        Type = ctx.ActionType.FullName;
        BlockFinish = ctx.Action.blocksFinish;
        Enabled = ctx.Action.enabled;
    }
    public static implicit operator FsmActionGeneralDetailsDoc(ActionContext ctx) =>
        new(ctx);
}
