using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        var methods = typeof(ActionDocs.ActionContextExtensions)
            .GetMethods(BindingFlags.Static | BindingFlags.Public)
            .Where(meth => meth.Name == "Document")
            .GroupBy(meth =>
                meth.GetParameters()
                .Where(param => param.Name == "Action")
                .First()
                .ParameterType)
            .ToDictionary(g => g.Key, g=> g.First());
        LogError($"Found {methods.Count} methods");
        for (int i = 0; i < actions.Count; i++)
        {
            try
            {
                var aCtx = ActionContext.Create(ctx, actions[i], i);
                FsmActionDoc result = null;
                if (methods.TryGetValue(aCtx.ActionType, out var method))
                    result = method.Invoke(null, new[] { aCtx, aCtx.ActionCasted }) as FsmActionDoc;
                result = result is not null
                    ? result
                    : aCtx.Document(aCtx.ActionCasted);
                Add(result);
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
