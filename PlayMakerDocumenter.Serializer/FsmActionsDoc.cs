using System.Collections.Generic;
using PlayMakerDocumenter.Serializer.ActionDocs;

namespace PlayMakerDocumenter.Serializer;

public class FsmActionsDoc : List<FsmActionDoc>
{
    internal StateContext ctx;
    public FsmActionsDoc() : base() { }
    internal FsmActionsDoc(StateContext ctx) : base()
    {
        if (ctx is null || ctx.State is null || ctx.State.Actions is null) return;
        this.ctx = ctx;
        var actions = ctx.State.Actions;
        for (int i = 0; i < actions.Count; i++)
        {
            try
            {
                var aCtx = ActionContext.Create(ctx, actions[i], i);
                Add(aCtx.Document(aCtx.ActionCasted));
            }
            catch (System.Exception ex)
            {
                LogError($"Failed to process Action: {ctx.Fsm.GetFullPath()}.FsmStates[{ctx.StateIndex}].Actions[{i}]");
                LogException(ex);
            } 
        }
    }
    public static implicit operator FsmActionsDoc(StateContext ctx) => new(ctx);
}
