using System.Linq;
using Il2CppHutongGames.PlayMaker.Actions;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using UnityEngine;
using Il2CppSystem.Reflection;
using UniverseLib;
using Il2CppSystem;
using System.Collections;
using Il2CppTMPro;

namespace PlayMakerDocumenter;

internal static class TableBuilderExtensions
{
    
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEvent Value, ActionContext ctx) =>
         Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.Name)}", Value.name)
            .AddRow($"{Property}.targetState", ctx.GetEventState(Value));
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerFSM Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.GetFullPath());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEventData Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.BoolData)}", Value.BoolData)
            .AddRow($"{Property}.{nameof(Value.ColorData)}", Value.ColorData)
            .AddRow($"{Property}.{nameof(Value.FloatData)}", Value.FloatData)
            .AddRow($"{Property}.{nameof(Value.GameObjectData)}", Value.GameObjectData)
            .AddRow($"{Property}.{nameof(Value.IntData)}", Value.IntData)
            .AddRow($"{Property}.{nameof(Value.MaterialData)}", Value.MaterialData)
            .AddRow($"{Property}.{nameof(Value.ObjectData)}", $"{Value.ObjectData}")
            .AddRow($"{Property}.{nameof(Value.QuaternionData)}", Value.QuaternionData)
            .AddRow($"{Property}.{nameof(Value.RectData)}", Value.RectData)
            .AddRow($"{Property}.{nameof(Value.SentByAction)}.Name", Value.SentByAction.Name)
            .AddRow($"{Property}.{nameof(Value.SentByState)}.Name", Value.SentByState.Name)
            .AddRow($"{Property}.{nameof(Value.StringData)}", Value.StringData)
            .AddRow($"{Property}.{nameof(Value.TextureData)}", Value.TextureData);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmVar Value, ActionContext ctx) =>
        Value is null
        ? tb
        : tb
            .AddRow($"{Property}.{nameof(Value.Type)}", Value.Type, ctx)
            .AddRow($"{Property}.Value", Value.GetValue(ctx.Fsm))
            .AddRow($"{Property}.{nameof(Value.variableName)}", Value.variableName);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, DelayedEvent Value, ActionContext ctx) =>
       Value is null
       ? tb
       : tb.AddRow($"{Property}.{nameof(Value.delay)}", Value.delay)
           .AddRow($"{Property}.{nameof(Value.eventFired)}", Value.eventFired)
           .AddRow($"{Property}.{nameof(Value.eventData)}", Value.eventData)
           .AddRow($"{Property}.{nameof(Value.Finished)}", Value.Finished)
           .AddRow($"{Property}.{nameof(Value.FsmEvent)}", Value.FsmEvent, ctx)
           .AddRow($"{Property}.{nameof(Value.Timer)}", Value.Timer);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerHashTableProxy Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.addEvent)}", Value.hashTable)
            .AddRow($"{Property}.{nameof(Value.contentPreviewMaxRows)}", Value.contentPreviewMaxRows)
            .AddRow($"{Property}.{nameof(Value.condensedView)}", Value.condensedView)
            .AddRow($"{Property}.{nameof(Value.contentPreviewStartIndex)}", Value.contentPreviewStartIndex)
            .AddRow($"{Property}.{nameof(Value.enablePlayMakerEvents)}", Value.enablePlayMakerEvents)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name)
            .AddRow($"{Property}.{nameof(Value.removeEvent)}", Value.removeEvent)
            .AddRow($"{Property}.{nameof(Value.setEvent)}", Value.setEvent)
            .AddRow($"{Property}.{nameof(Value.showContent)}", Value.showContent)
            .AddRow($"{Property}.{nameof(Value.showEvents)}", Value.showEvents);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerProxyBase Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;

        if (Value.TargetFSMs is not null)
        {
            tb.AddRow(
                $"{Property}.{nameof(Value.TargetFSMs)}",
                string.Join(", ", Value.TargetFSMs.ToArray().Select(fsm => fsm.GetFullPath())));
        }
        if (Value.playMakerFSMs is not null)
        {
            tb.AddRow(
                $"{Property}.{nameof(Value.playMakerFSMs)}",
                string.Join(", ", Value.playMakerFSMs.ToArray().Select(fsm => fsm.GetFullPath())));
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, DelegateData Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.curried_first_arg)}", Value.curried_first_arg)
            .AddRow($"{Property}.{nameof(Value.method_name)}", Value.method_name)
            .AddRow($"{Property}.{nameof(Value.target_type)}", Value.target_type);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, EaseFsmAction.EasingFunction Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.data)}", Value.data)
            .AddRow($"{Property}.{nameof(Value.Method)}", Value.Method)
            .AddRow($"{Property}.{nameof(Value.method_is_virtual)}", Value.method_is_virtual);

    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmOwnerDefault fsmOwner, ActionContext ctx) =>
        fsmOwner is null
        ? tb
        : tb
            .AddRow($"{Property}.{nameof(fsmOwner.OwnerOption)}", fsmOwner.OwnerOption.ToString())
            .AddRow($"{Property}.FullPath", fsmOwner.GetFsmOwnerDefaultPath(ctx.Action.fsmComponent));
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEventTarget Value, ActionContext ctx) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.excludeSelf)}", Value.excludeSelf, ctx)
            .AddRow($"{Property}.{nameof(Value.fsmComponent)}", Value.fsmComponent, ctx)
            .AddRow($"{Property}.{nameof(Value.fsmName)}", Value.fsmName, ctx)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject, ctx)
            .AddRow($"{Property}.{nameof(Value.sendToChildren)}", Value.sendToChildren)
            .AddRow($"{Property}.{nameof(Value.target)}", Value.target);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, MemberInfo Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb
            .AddRow($"{Property}.{nameof(Value.DeclaringType)}", Value.DeclaringType)
            .AddRow($"{Property}.{nameof(Value.MemberType)}", Value.MemberType)
            .AddRow($"{Property}.{nameof(Value.Name)}", Value.Name)
            .AddRow($"{Property}.{nameof(Value.ToString)}", Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Type Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.Fullname", Value.GetActualType().FullName);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmProperty Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb
            .AddRow($"{Property}.{nameof(Value.ArrayParameter)}", Value.ArrayParameter)
            .AddRow($"{Property}.{nameof(Value.BoolParameter)}", Value.BoolParameter)
            .AddRow($"{Property}.{nameof(Value.ColorParameter)}", Value.ColorParameter)
            .AddRow($"{Property}.{nameof(Value.EnumParameter)}", Value.EnumParameter)
            .AddRow($"{Property}.{nameof(Value.FloatParameter)}", Value.FloatParameter)
            .AddRow($"{Property}.{nameof(Value.GameObjectParameter)}", Value.GameObjectParameter)
            .AddRow($"{Property}.{nameof(Value.initialized)}", Value.initialized)
            .AddRow($"{Property}.{nameof(Value.IntParameter)}", Value.IntParameter)
            .AddRow($"{Property}.{nameof(Value.MaterialParameter)}", Value.MaterialParameter);
        foreach (var memberInfo in Value.memberInfo)
        {
            tb.AddRow($"{Property}.{nameof(Value.memberInfo)}", memberInfo);
        }
        tb
            .AddRow($"{Property}.{nameof(Value.PropertyName)}", Value.PropertyName)
            .AddRow($"{Property}.{nameof(Value.PropertyType)}", Value.PropertyType)
            .AddRow($"{Property}.{nameof(Value.QuaternionParameter)}", Value.QuaternionParameter)
            .AddRow($"{Property}.{nameof(Value.RectParamater)}", Value.RectParamater)
            .AddRow($"{Property}.{nameof(Value.setProperty)}", Value.setProperty)
            .AddRow($"{Property}.{nameof(Value.StringParameter)}", Value.StringParameter)
            .AddRow($"{Property}.{nameof(Value.TargetObject)}", Value.TargetObject)
            .AddRow($"{Property}.{nameof(Value.TargetType)}", Value.TargetType)
            .AddRow($"{Property}.{nameof(Value.TargetTypeName)}", Value.TargetTypeName)
            .AddRow($"{Property}.{nameof(Value.TextureParameter)}", Value.TextureParameter);
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, ParameterInfo Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.Attributes)}", Value.Attributes)
            .AddRow($"{Property}.{nameof(Value.DefaultValue)}", Value.DefaultValue.ToString())
            .AddRow($"{Property}.{nameof(Value.IsIn)}", Value.IsIn)
            .AddRow($"{Property}.{nameof(Value.IsOut)}", Value.IsOptional)
            .AddRow($"{Property}.{nameof(Value.IsOut)}", Value.IsOut)
            .AddRow($"{Property}.{nameof(Value.Member)}", Value.Member)
            .AddRow($"{Property}.{nameof(Value.Name)}", Value.Name)
            .AddRow($"{Property}.{nameof(Value.ParameterType)}", Value.ParameterType)
            .AddRow($"{Property}.{nameof(Value.Position)}", Value.Position)
            .AddRow($"{Property}.{nameof(Value.ToString)}", Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, ArrayList Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.Count", Value.Count);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, TextMeshPro Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.text)}", Value.text);
    public static TableBuilder AddRowNotNull(this TableBuilder tb, string Property, string Value) =>
        Value is null || string.IsNullOrWhiteSpace(Value)
        ? tb
        : tb.AddRow(Property, Value);
}
