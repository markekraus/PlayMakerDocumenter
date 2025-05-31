using Il2Cpp;
using Il2CppHutongGames.PlayMaker;
using Il2CppHutongGames.PlayMaker.Actions;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using UnityEngine;
using UniverseLib;

namespace PlayMakerDocumenter;

internal static class TableBuilderExtensionsArrays
{
    #region FsmTypes
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmBool> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmColor> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmInt> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmFloat> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmQuaternion> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmRect> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmVector2> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmVector3> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmTexture> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmMaterial> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmGameObject> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmArray> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmEnum> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmString> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmEvent> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}].Name", Value[i].Name);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmOwnerDefault> Value, ActionContext ctx)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i], ctx);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<FsmVar> Value, ActionContext ctx)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i], ctx);
        }
        return tb;
    }
    #endregion
    #region Primitive
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppSystem.Collections.ArrayList Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}].Type", Value[i].GetActualType().FullName);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppSystem.Collections.Hashtable Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<Il2CppSystem.Object> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i].ToString());
            tb.AddRow($"{Property}[{i}].Type", Value[i].GetActualType().FullName);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<ParameterInfo> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppStructArray<bool> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppStructArray<float> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppStructArray<char> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    #endregion
    #region Unity
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<GameObject> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppReferenceArray<ParticleSystem> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    #endregion
    #region  PlayMaker
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Il2CppStructArray<IgnoreEvents.EventType> Value, ActionContext ctx = null)
    {
        if (Value is null) return tb;
        tb.AddRow($"{Property}.{nameof(Value.Count)}", Value.Count);
        for (int i = 0; i < Value.Count; i++)
        {
            tb.AddRow($"{Property}[{i}]", Value[i]);
        }
        return tb;
    }
    public static TableBuilder AddRow(this TableBuilder tb, string Property, PlayMakerArrayListProxy Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.addEvent)}", Value.addEvent)
            .AddRow($"{Property}.{nameof(Value.arrayList)}", Value.arrayList)
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
    #endregion
}
