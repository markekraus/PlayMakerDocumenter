using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using UnityEngine;
using UniverseLib;

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

        File.WriteAllText(filePath, "# PlayMaker FSM Documentation");
        using var writer = File.AppendText(filePath);
        NewStringBuilder()
            .AppendLine("")
            .DocEnvironmentDetails()
            .DocFsmDetails(fsm)
            .DocGlobalTransitions(fsm)
            .DocFsmVariables(fsm)
            .DocFsmEvents(fsm)
            .DocFsmStates(fsm)
            .WriteToFile(writer)
            .WriteToLog();
        LogMsg($"FSM Doc: {filePath}");
    }
    private static StringBuilder DocFsmStates(this StringBuilder sb, PlayMakerFSM fsm) =>
        fsm is null || fsm.FsmStates is null || fsm.FsmStates.Count < 1
        ? sb
        : sb.AppendHeader("## States")
            .DocEachFsmState(fsm);
    private static StringBuilder DocEachFsmState(this StringBuilder sb, PlayMakerFSM fsm)
    {
        if (fsm.FsmStates is null || fsm.FsmStates.Count < 1)
            return sb;
        for (int stateIndex = 0; stateIndex < fsm.FsmStates.Count; stateIndex++)
        {
            var fsmState = fsm.FsmStates[stateIndex];
            var eventToState = new Dictionary<string, string>();
            sb
                .DocStateDetails(fsmState, stateIndex)
                .DocStateTransitions(fsmState, stateIndex, eventToState)
                .DocStateActions(fsmState, stateIndex, eventToState);
        }
        return sb;
    }

    private static StringBuilder DocStateTransitions(this StringBuilder sb, FsmState fsmState, int stateIndex, Dictionary<string, string> eventToState) =>
        fsmState is null || fsmState.transitions is null || fsmState.transitions.Count < 1
        ? sb
        : sb.AppendHeader($"### {stateIndex} {fsmState.Name}: Transitions")
            .NewTable()
            .WithHeaders("EventName", "ToState")
            .ForEachAddRow(fsmState.transitions, transition =>
            {
                eventToState.Add(transition.EventName, transition.ToState);
                return new string[] { transition.EventName, transition.ToState };
            })
            .BuildTable();
    private static StringBuilder DocStateDetails(this StringBuilder sb, FsmState fsmState, int stateIndex) =>
        fsmState is null
        ? sb
        : sb.AppendHeader($"### State {stateIndex}: {fsmState.Name}")
            .NewTable()
            .WithPropertyValueHeaders()
            .AddRow("Description", fsmState.Description)
            .AddRow("HandlesOnEvent", $"{fsmState.HandlesOnEvent}")
            .AddRow("IsSequence", $"{fsmState.IsSequence}")
            .AddRow("maxLoopCount", $"{fsmState.maxLoopCount}")
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
                    variable.Value.GetValueFromNamedVariable(fsm),
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
        fsm is null || fsm.FsmGlobalTransitions is null
        ? sb
        : sb.AppendHeader("## Global Transitions")
            .NewTable()
            .WithHeaders("EventName", "ToFsmState")
            .ForEachAddRow(fsm.FsmGlobalTransitions,
                gt => new string[] { gt.EventName, gt.ToFsmState.Name })
            .BuildTable();

    public static string TypeSwitch(VariableType type, FsmVariables vars, string name)
    {
        switch (type)
        {
            case VariableType.Int:
                return vars.GetFsmInt(name).Value.ToString();
            case VariableType.Float:
                return vars.GetFsmFloat(name).Value.ToString();
            case VariableType.Bool:
                return vars.GetFsmBool(name).ToString();
            case VariableType.Color:
                var fsmColor = vars.GetFsmColor(name).Value;
                return $"r: {fsmColor.r}, g: {fsmColor.g}, b: {fsmColor.b}, a: {fsmColor.a}";
            case VariableType.Quaternion:
                var fsmQuaternion = vars.GetFsmQuaternion(name).Value;
                return $"x: {fsmQuaternion.x}, y: {fsmQuaternion.y}, z: {fsmQuaternion.z}, w: {fsmQuaternion.w}";
            case VariableType.Rect:
                var fsmRect = vars.GetFsmRect(name).Value;
                return $"x: {fsmRect.x}, y: {fsmRect.y}, width: {fsmRect.width}, height: {fsmRect.height}";
            case VariableType.Vector2:
                var fsmVector2 = vars.GetFsmVector2(name).Value;
                return $"x: {fsmVector2.x}, y: {fsmVector2.y}";
            case VariableType.Vector3:
                var fsmVector3 = vars.GetFsmVector3(name).Value;
                return $"x: {fsmVector3.x}, y: {fsmVector3.y}, z: {fsmVector3.z}";
            case VariableType.Texture:
                var fsmTexture = vars.GetFsmTexture(name).Value;
                return $"name: {fsmTexture.name}";
            case VariableType.Material:
                var fsmMaterial = vars.GetFsmMaterial(name).Value;
                return $"name: {fsmMaterial.name}";
            case VariableType.String:
                return vars.GetFsmString(name).Value;
            case VariableType.GameObject:
                var fsmGameObject = vars.GetFsmGameObject(name);
                return fsmGameObject.Value == null ? "null" : fsmGameObject.Value.GetFullPath();
            case VariableType.Object:
                var fsmObject = vars.GetFsmObject(name);
                return $"type: {fsmObject.Value.GetActualType()}, value: {fsmObject.Value.ToString()}"; ;
            case VariableType.Unknown:
                return "*Unknown*";
            case VariableType.Array:
                var fsmArray = vars.GetFsmArray(name);
                return $"ElementType: {fsmArray.ElementType}, count: {fsmArray.Values.Count}";
            case VariableType.Enum:
                var fsmEnum = vars.GetFsmEnum(name);
                return $"type: {fsmEnum.EnumType}, value: {fsmEnum.Value}";
            default:
                return "*Unknown*";
        }
    }

    public static string GetValueFromFsmVar(this FsmVar fsmVar, PlayMakerFSM fsm) =>
        fsm == null || fsmVar == null
        ? "null"
        : TypeSwitch(fsmVar.Type, fsm.FsmVariables, fsmVar.variableName);

    public static string GetValueFromNamedVariable(this NamedVariable fsmVar, PlayMakerFSM fsm) =>
        fsm == null || fsmVar == null
        ? "null"
        : TypeSwitch(fsmVar.VariableType, fsm.FsmVariables, fsmVar.name);

    public static string GetFsmOwnerDefaultPath(this FsmOwnerDefault fsmOwner, PlayMakerFSM fsm) =>
        fsmOwner.OwnerOption == OwnerDefaultOption.UseOwner
        ? fsm.transform.GetFullPath()
        : fsmOwner.GameObject == null || fsmOwner.GameObject.Value == null
            ? "null"
            : fsmOwner.GameObject.Value.GetFullPath();
    public static StringBuilder AppendHeader(this StringBuilder sb, string header) =>
        sb.AppendLine(header).AppendLine("");

    public static StringBuilder NewStringBuilder() => new();
    public static TOut Devoid<TOut>(TOut output, Func<TOut, TOut> devoid) => devoid(output);
    public static StringBuilder WriteToFile(this StringBuilder sb, StreamWriter writer)
    { writer.Write(sb); return sb; }

    public static StringBuilder WriteToLog(this StringBuilder sb)
    { LogMsg(sb.ToString()); return sb; }

    public static bool IsNullOrWhiteSpace(this string @string) => string.IsNullOrWhiteSpace(@string);
    public static TableBuilder AddGameObjectRows(this TableBuilder tb, FsmStateAction action, FsmOwnerDefault fsmOwner) =>
        fsmOwner is null
        ? tb
        : tb
            .AddRowIfNotNull(fsmOwner, gameObject =>
                new string[] { "gameObject.OwnerOption", $"{gameObject.OwnerOption}" })
            .AddRowIfNotNull(fsmOwner, gameObject =>
                new string[] { "GameObject Path", gameObject.GetFsmOwnerDefaultPath(action.fsmComponent) });
}