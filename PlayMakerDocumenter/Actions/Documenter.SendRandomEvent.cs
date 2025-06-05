using System;
using System.Collections.Generic;
using System.Text;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
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
            .WithNameValueHeaders();
        try{tb.AddRow(nameof(action.delay), action.delay, ctx);}
            catch { LogError($"Could not access 'delay'. '{ctx.Fsm.GetFullPath()}'.States[{ctx.StateIndex}].Actions[{ctx.ActionIndex}].delay"); }
        try{tb.AddRow(nameof(action.delayedEvent), action.delayedEvent, ctx);}
            catch { LogError($"Could not access 'delayedEvent'. '{ctx.Fsm.GetFullPath()}'.States[{ctx.StateIndex}].Actions[{ctx.ActionIndex}].delayedEvent"); }
        tb = tb
            .BuildTable()
            .NewTable()
            .WithHeaders("Weight", "Event", "Target State");
        for (int i = 0; i < action.events.Count; i++)
        {
            FsmEvent fsmEvent;
            FsmFloat fsmFloat;
            string eventName;
            string weight;
            string stateName;
            try
            {
                fsmEvent = action.events[i];
                if (fsmEvent is null)
                {
                    eventName = " null";
                    stateName = "";
                }
                else
                {
                    eventName = fsmEvent.Name;
                    stateName = ctx.GetEventState(fsmEvent.Name);   
                }
            }
            catch (Exception ex)
            {
                eventName = "";
                stateName = "";
                LogError($"Could not evaluate event/state. '{ctx.Fsm.GetFullPath()}'.States[{ctx.StateIndex}].Actions[{ctx.ActionIndex}].events[{i}]");
                LogException(ex);
            }
            try
            {
                fsmFloat = action.weights[i];
                weight = fsmFloat?.FormatValue();
            }
            catch (Exception ex)
            {
                weight = "";
                LogError($"Could not evaluate weight. '{ctx.Fsm.GetFullPath()}'.States[{ctx.StateIndex}].Actions[{ctx.ActionIndex}].weights[{i}]");
                LogException(ex);
            }
            
            tb.AddRow(weight, eventName, stateName);
        }
        return tb.BuildTable();
    }
}
