using System.Collections.Generic;
using System.Text;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using UnityEngine;
using UniverseLib;

using static PlayMakerDocumenter.Actions.Documenter;

namespace PlayMakerDocumenter;

public static partial class FsmDocumenter
{
    public static void DocumentFsm(string fsmPath, string filePath)
    {
        var fsmObj = GameObject.Find(fsmPath);
        if (fsmObj is null) { LogError($"Could not find '{fsmPath}'"); return; }

        var fsm = fsmObj.GetComponent<PlayMakerFSM>();
        if (fsm is null) { LogError($"Could not find PLayMakerFSM on '{fsmPath}'"); return; }

        DocumentFsm(fsm, filePath);
    }
    public static void DocumentFsm(this PlayMakerFSM fsm, string filePath)
    {
        if (fsm is null) { LogError("Fsm was null"); return; }
        if (filePath.IsNullOrWhiteSpace()) { LogError("Fsm was null"); return; }

        new StringBuilder()
            .AppendHeader("# PlayMaker FSM Documentation")
            .DocEnvironmentDetails()
            .DocFsmDetails(fsm)
            .DocGlobalTransitions(fsm)
            .DocFsmVariables(fsm)
            .DocFsmEvents(fsm)
            .DocFsmStates(fsm)
            .WriteToFile(filePath);
        LogMsg($"FSM Doc: {filePath}");
    }
    private static StringBuilder DocFsmStates(this StringBuilder sb, PlayMakerFSM fsm) =>
        fsm is null || fsm.FsmStates is null || fsm.FsmStates.Count < 1
        ? sb
        : sb.DocEachFsmState(fsm);
    private static StringBuilder DocEachFsmState(this StringBuilder sb, PlayMakerFSM fsm)
    {
        if (fsm.FsmStates is null || fsm.FsmStates.Count < 1)
            return sb;
        for (int stateIndex = 0; stateIndex < fsm.FsmStates.Count; stateIndex++)
        {
            var fsmState = fsm.FsmStates[stateIndex];
            var ctx = new StateContext(
                fsm,
                fsm.FsmStates[stateIndex],
                stateIndex,
                new Dictionary<string, string>());
            sb
                .DocStateDetails(ctx)
                .DocStateTransitions(ctx)
                .DocStateActions(ctx);
        }
        return sb;
    }

    private static StringBuilder DocStateTransitions(this StringBuilder sb, StateContext ctx) =>
         ctx is null || ctx.State is null || ctx.State.transitions is null || ctx.State.transitions.Count < 1
        ? sb
        : sb.AppendHeader($"### {ctx.StateIndex} {ctx.State.Name}: Transitions")
            .NewTable()
            .WithHeaders("EventName", "ToState")
            .ForEachAddRow(ctx.State.transitions, transition =>
            {
                ctx.EventToState.Add(transition.EventName, transition.ToState);
                return new string[] { transition.EventName, transition.ToState };
            })
            .BuildTable();
    private static StringBuilder DocStateDetails(this StringBuilder sb, StateContext ctx) =>
        ctx is null || ctx.State is null
        ? sb
        : sb.AppendHeader($"## State {ctx.StateIndex}: {ctx.State.Name}")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow(nameof(ctx.State.Description), ctx.State.Description)
            .AddRow(nameof(ctx.State.HandlesOnEvent), ctx.State.HandlesOnEvent)
            .AddRow(nameof(ctx.State.IsSequence), ctx.State.IsSequence)
            .AddRow(nameof(ctx.State.maxLoopCount), ctx.State.maxLoopCount)
            .BuildTable();
    private static StringBuilder DocFsmEvents(this StringBuilder sb, PlayMakerFSM fsm) =>
        fsm is null || fsm.FsmEvents is null || fsm.FsmEvents.Count < 1
        ? sb
        : sb.AppendHeader("## Events")
            .NewTable()
            .WithHeaders("Name", "Path")
            .ForEachAddRow(fsm.FsmEvents, fsmEvent =>
                new string[] { fsmEvent.Name, fsmEvent.Path })
            .BuildTable();
    private static StringBuilder DocFsmVariables(this StringBuilder sb, PlayMakerFSM fsm) =>
        fsm is null || fsm.FsmVariables is null || fsm.FsmVariables._variableLookup is null
        ? sb
        : sb.AppendHeader("## Variables")
            .NewTable()
            .WithHeaders("Name", "Value", "Type")
            .ForEachAddRow(fsm.FsmVariables._variableLookup, variable =>
                variable.Value is null
                ? new string[] { variable.Key, "null", "null" }
                : new string[] {
                    variable.Key,
                    variable.Value.GetValue(fsm),
                    variable.Value.GetActualType().Name })
            .BuildTable();


    private static StringBuilder DocFsmDetails(this StringBuilder sb, PlayMakerFSM fsm) =>
        fsm is null
        ? sb
        : sb.AppendHeader($"## {fsm.name}")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("Active", $"{fsm.Active}")
            .AddRow("ActiveStateName", fsm.ActiveStateName)
            .AddRow("enabled", $"{fsm.enabled}")
            .AddRow("FsmDescription", $"{fsm.FsmDescription}")
            .AddRow("FsmName", $"{fsm.FsmName}")
            .AddRow("FullPath", $"{fsm.transform.GetFullPath()}")
            .BuildTable();

    private static StringBuilder DocEnvironmentDetails(this StringBuilder sb) =>
        sb.AppendHeader("## Environment details")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("productName", Application.productName)
            .AddRow("companyName", Application.companyName)
            .AddRow("version", Application.version)
            .AddRow("buildGUID", Application.buildGUID)
            .AddRow("unityVersion", Application.unityVersion)
            .AddRow("PlayMaker Assembly Version", typeof(PlayMakerFSM).Assembly.GetName().Version.ToString())
            .BuildTable();

    private static StringBuilder DocGlobalTransitions(this StringBuilder sb, PlayMakerFSM fsm) =>
        fsm is null || fsm.FsmGlobalTransitions is null || fsm.FsmGlobalTransitions.Count < 1
        ? sb
        : sb.AppendHeader("### Global Transitions")
            .NewTable()
            .WithHeaders("EventName", "ToFsmState")
            .ForEachAddRow(fsm.FsmGlobalTransitions,
                gt => new string[] { gt.EventName, gt.ToFsmState.Name })
            .BuildTable();

    internal static string GetValue(this FsmVar fsmVar, PlayMakerFSM fsm) =>
        fsm == null || fsmVar == null
        ? "null"
        : fsmVar.Type.ValueFormatTypeSwitch(fsm.FsmVariables, fsmVar.variableName);

    internal static string GetValue(this NamedVariable fsmVar, PlayMakerFSM fsm) =>
        fsm == null || fsmVar == null
        ? "null"
        : fsmVar.VariableType.ValueFormatTypeSwitch(fsm.FsmVariables, fsmVar.name);

    internal static string GetFsmOwnerDefaultPath(this FsmOwnerDefault fsmOwner, PlayMakerFSM fsm) =>
        fsmOwner.OwnerOption == OwnerDefaultOption.UseOwner
        ? fsm.transform.GetFullPath()
        : fsmOwner.GameObject == null || fsmOwner.GameObject.Value == null
            ? "null"
            : fsmOwner.GameObject.Value.GetFullPath();
}