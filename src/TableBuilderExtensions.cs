using System.Collections.Generic;
using System.Linq;
using Il2CppHutongGames.PlayMaker.Actions;
using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using UnityEngine;
using Il2CppSystem.Reflection;
using UniverseLib;

namespace PlayMakerDocumenter;

internal static class TableBuilderExtensions
{
    public static TableBuilder AddRow(this TableBuilder tb, string Property, int Value, ActionContext ctx = null) =>
        PlayMakerDocumenter.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, GameObject Value, ActionContext ctx = null) =>
        tb.AddRowIfNotNull(Value, value => new string[] { Property, value.GetFullPath() });
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppSystem.Collections.ArrayList Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppSystem.Collections.Hashtable Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerArrayListProxy Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.addEvent)}", Value.arrayList)
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
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEvent Value, Dictionary<string, string> eventToState) =>
        tb
            .AddRowIfNotNull(Value, value => new string[] { $"{Property}.{nameof(value.Name)}", value.name })
            .AddRowIfNotNull(Value, value => new string[] { $"{Property}.targetState", eventToState.GetValueOrDefault(value.name, "*Unknown*") });
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerFSM Value, ActionContext ctx = null) =>
        tb.AddRowIfNotNull(Value, value =>
            new string[] { Property, value.GetFullPath() });
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
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmVar Value, FsmStateAction action) =>
        tb
            .AddRowIfNotNull(Value, value =>
                new string[] { $"{Property}.{nameof(value.Type)}", $"{value.Type}" })
            .AddRowIfNotNull(Value, value =>
                new string[] { $"{Property}.Value", value.GetValue(action.fsmComponent) })
            .AddRowIfNotNull(Value, value =>
                new string[] { $"{Property}.{nameof(value.variableName)}", value.variableName });
    public static TableBuilder AddRow(this TableBuilder tb, string Property, DelayedEvent Value, Dictionary<string, string> eventToState) =>
       Value is null
       ? tb
       : tb.AddRow($"{Property}.{nameof(Value.delay)}", Value.delay)
           .AddRow($"{Property}.{nameof(Value.eventFired)}", Value.eventFired)
           .AddRow($"{Property}.{nameof(Value.eventData)}", Value.eventData)
           .AddRow($"{Property}.{nameof(Value.Finished)}", Value.Finished)
           .AddRow($"{Property}.{nameof(Value.FsmEvent)}", Value.FsmEvent, eventToState)
           .AddRow($"{Property}.{nameof(Value.Timer)}", Value.Timer);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerActionsUtils.EveryFrameUpdateSelector Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerCollectionProxy.VariableEnum Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
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
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerProxyBase Value)
    {
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
    public static TableBuilder AddRow(this TableBuilder tb, string Property, ConvertFloatToInt.FloatRounding Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, EaseFsmAction.EaseType Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, EaseFsmAction.EasingFunction Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FloatOperator.Operation Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, GetSceneActionBase.SceneSimpleReferenceOptions Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, IntOperator.Operation Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmOwnerDefault fsmOwner, ActionContext ctx) =>
        fsmOwner is null
        ? tb
        : tb
            .AddRow($"{Property}.{nameof(fsmOwner.OwnerOption)}", fsmOwner.OwnerOption.ToString())
            .AddRow($"{Property}.FullPath", fsmOwner.GetFsmOwnerDefaultPath(ctx.Action.fsmComponent));
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEventTarget.EventTarget Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
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
            .AddRow($"{Property}.{nameof(Value.DeclaringType)}.{nameof(Value.DeclaringType.FullName)}", Value.DeclaringType.GetActualType().FullName)
            .AddRow($"{Property}.{nameof(Value.MemberType)}.FullName", Value.MemberType.GetActualType().FullName)
            .AddRow($"{Property}.{nameof(Value.Name)}", Value.Name)
            .AddRow($"{Property}.{nameof(Value.ToString)}", Value.ToString())
        ;
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmProperty Value)
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
            .AddRow($"{Property}.{nameof(Value.PropertyType)}.FullName", Value.PropertyType.GetActualType().FullName)
            .AddRow($"{Property}.{nameof(Value.QuaternionParameter)}", Value.QuaternionParameter)
            .AddRow($"{Property}.{nameof(Value.RectParamater)}", Value.RectParamater)
            .AddRow($"{Property}.{nameof(Value.setProperty)}", Value.setProperty)
            .AddRow($"{Property}.{nameof(Value.StringParameter)}", Value.StringParameter)
            .AddRow($"{Property}.{nameof(Value.TargetObject)}", Value.TargetObject)
            .AddRow($"{Property}.{nameof(Value.TargetType)}.FullName", Value.TargetType.GetActualType().FullName)
            .AddRow($"{Property}.{nameof(Value.TargetTypeName)}", Value.TargetTypeName)
            .AddRow($"{Property}.{nameof(Value.TextureParameter)}", Value.TextureParameter);
        return tb;
    }
}

/*
Il2CppHutongGames.PlayMaker.InterpolationType
Il2CppHutongGames.PlayMaker.LogLevel
Il2CppHutongGames.PlayMaker.MouseButton
Il2CppHutongGames.PlayMaker.TriggerType
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmBool, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmEvent, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmFloat, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmInt, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmObject, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmOwnerDefault, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmString, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmVar, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppHutongGames.PlayMaker.FsmVector3, Il2CppPlayMaker, Version=1.6.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppSystem.Object, Il2Cppmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null]]        
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[Il2CppSystem.Reflection.ParameterInfo, Il2Cppmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[UnityEngine.GameObject, UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray`1[[UnityEngine.ParticleSystem, UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray`1[[Il2CppHutongGames.PlayMaker.Actions.IgnoreEvents+EventType, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray`1[[System.Boolean, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray`1[[System.Char, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray`1[[System.Single, System.Private.CoreLib, Version=9.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e]]
Il2CppPathologicalGames.SpawnPool
Il2CppSystem.Collections.ArrayList
Il2CppSystem.Reflection.MethodInfo
Il2CppSystem.Type
Il2CppTMPro.TextMeshPro
System.Char
System.Int32
UnityEngine.Animation
UnityEngine.Animator
UnityEngine.AsyncOperation
UnityEngine.AudioClip
UnityEngine.AudioSource
UnityEngine.Camera
UnityEngine.Color
UnityEngine.KeyCode
UnityEngine.Light
UnityEngine.ParticleSystem
UnityEngine.Renderer
UnityEngine.Rigidbody
UnityEngine.Rigidbody2D
UnityEngine.Space
UnityEngine.Transform
UnityEngine.Vector3
UnityEngine.Video.VideoClip
UnityEngine.Video.VideoPlayer
*/
