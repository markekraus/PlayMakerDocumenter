using System.Collections.Generic;
using System.Text;
using Il2CppHutongGames.PlayMaker.Actions;

namespace PlayMakerDocumenter.Actions;

internal static partial class Documenter
{
    private static StringBuilder DocActionSendRandomEvent(this StringBuilder sb, SendRandomEvent action, ActionContext ctx)
    {
        if (action is null || action.events is null || action.events.Count < 1)
            return sb;
        var tb = sb
            .AppendHeader($"{nameof(SendRandomEvent)} Details:")
            .NewTable()
            .WithNameValueHeaders()
            .AddRow(nameof(action.delay), action.delay)
            .AddRow(nameof(action.delayedEvent), action.delayedEvent, ctx.EventToState)
            .BuildTable()
            .NewTable()
            .WithHeaders("Weight", "Event", "Target State");
        for (int i = 0; i < action.events.Count; i++)
        {
            var fsmEvent = action.events[i];
            var weight = action.weights[i];
            tb.AddRow(weight.FormatValue(), fsmEvent.Name, ctx.EventToState.GetValueOrDefault(fsmEvent.Name));
        }
        return tb.BuildTable();
    }
}
