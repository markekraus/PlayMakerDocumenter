using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using PlayMakerDocumenter.Serializer.ActionDocs;

namespace PlayMakerDocumenter.Serializer;

public class FsmActionsDoc : List<FsmActionDoc>
{
    internal StateContext ctx;
    private static readonly Lazy<Dictionary<Type, MethodInfo>> methodsCache = new(GetMethods);
    private static Dictionary<Type, MethodInfo> methods => methodsCache.Value;
    private static Dictionary<Type, MethodInfo> GetMethods() =>
        typeof(ActionDocs.ActionContextExtensions)
            .GetMethods(BindingFlags.Static | BindingFlags.Public)
            .Where(meth => meth.Name == "Document")
            .GroupBy(meth =>
                meth.GetParameters()
                .Where(param => param.Name == "Action")
                .First()
                .ParameterType)
            .ToDictionary(g => g.Key, g=> g.First());
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
