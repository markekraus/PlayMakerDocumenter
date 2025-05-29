using System.Collections.Generic;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using UnityEngine;

namespace PlayMakerDocumenter;

internal static class TableBuilderExtensions
{
    public static TableBuilder AddRow(this TableBuilder tb, string Property, GameObject Value) =>
        tb.AddRowIfNotNull(Value, value => new string[] { Property, value.GetFullPath() });
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEvent Value) =>
        tb.AddRowIfNotNull(Value, value => new string[] { Property, value.Name });
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEvent Value, Dictionary<string, string> eventToState) =>
        tb.AddRowIfNotNull(Value, value => new string[] { $"{Property} State", eventToState.GetValueOrDefault(value.name, "*Unknown*") });
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerFSM Value) =>
        tb.AddRowIfNotNull(Value, value =>
            new string[] { Property, value.GetFullPath() });
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmVar Value, FsmStateAction action) =>
        tb
            .AddRowIfNotNull(Value, value =>
                new string[] { $"{Property}.{nameof(value.Type)}", $"{value.Type}" })
            .AddRowIfNotNull(Value, value =>
                new string[] { $"{Property}.value", value.GetValue(action.fsmComponent) })
            .AddRowIfNotNull(Value, value =>
                new string[] { $"{Property}.{nameof(value.variableName)}", value.variableName });
}