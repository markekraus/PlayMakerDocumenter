using System.ComponentModel.DataAnnotations;
using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter;

internal static class PlayMakerFsmValueFormatter
{
    #region FormatValue
    public static string FormatValue(this FsmBool fsmBool) =>
        fsmBool is null
        ? "null"
        : $"{fsmBool.Value}";
    public static string FormatValue(this FsmColor fsmColor) =>
        fsmColor is null
        ? "null"
        : $"r: {fsmColor.Value.r}, g: {fsmColor.Value.g}, b: {fsmColor.Value.b}, a: {fsmColor.Value.a}";
    public static string FormatValue(this FsmInt fsmInt) =>
        fsmInt is null
        ? "null"
        : $"{fsmInt.Value}";
    public static string FormatValue(this FsmFloat fsmFloat) =>
        fsmFloat is null
        ? "null"
        : $"{fsmFloat.Value}";
    public static string FormatValue(this FsmQuaternion fsmQuaternion) =>
        fsmQuaternion is null
        ? "null"
        : $"x: {fsmQuaternion.Value.x}, y: {fsmQuaternion.Value.y}, z: {fsmQuaternion.Value.z}, w: {fsmQuaternion.Value.w}";
    public static string FormatValue(this FsmRect fsmRect) =>
        fsmRect is null
        ? "null"
        : $"x: {fsmRect.Value.x}, y: {fsmRect.Value.y}, width: {fsmRect.Value.width}, height: {fsmRect.Value.height}";
    public static string FormatValue(this FsmVector2 fsmVector2) =>
        fsmVector2 is null
        ? "null"
        : $"x: {fsmVector2.Value.x}, y: {fsmVector2.Value.y}";
    public static string FormatValue(this FsmVector3 fsmVector3) =>
        fsmVector3 is null
        ? "null"
        : $"x: {fsmVector3.Value.x}, y: {fsmVector3.Value.y}, z: {fsmVector3.Value.z}";
    public static string FormatValue(this FsmTexture fsmTexture) =>
        fsmTexture is null || fsmTexture.Value is null
        ? "null"
        : $"name: {fsmTexture.Value.name}";
    public static string FormatValue(this FsmMaterial fsmMaterial) =>
        fsmMaterial is null || fsmMaterial.Value is null
        ? "null"
        : $"name: {fsmMaterial.Value.name}";
    public static string FormatValue(this FsmGameObject fsmGameObject)
    {
        if (fsmGameObject is null || fsmGameObject.Value is null) return "null";
        try { return fsmGameObject.Value.GetFullPath(); } catch { return "null"; }
    }


    public static string FormatValue(this FsmObject fsmObject) =>
        fsmObject is null || fsmObject.Value is null
        ? "null"
        : $"type: {fsmObject.Value.GetActualType()}, name: {fsmObject.Value.name}, value: {fsmObject.Value}";
    public static string FormatValue(this FsmArray fsmArray) =>
        fsmArray is null || fsmArray.Values is null
        ? "null"
        : $"ElementType: {fsmArray.ElementType}, count: {fsmArray.Values.Count}";
    public static string FormatValue(this FsmEnum fsmEnum) =>
        fsmEnum is null
        ? "null"
        : $"type: {fsmEnum.EnumType.GetActualType()}, intValue: {fsmEnum.intValue}";
    public static string FormatValue(this FsmString fsmString) =>
        fsmString is null || fsmString.Value is null
        ? "null"
        : fsmString.Value;
    #endregion
    #region AddRow
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmBool Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmColor Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmInt Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmFloat Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmQuaternion Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmRect Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmVector2 Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmVector3 Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmTexture Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmMaterial Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmGameObject Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmObject Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmArray Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEnum Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmString Value) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.FormatValue())
            .AddRowNotNull($"{Property}.{nameof(Value.Name)}", Value.Name);
    #endregion
    #region AddRowCtx
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmBool Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmColor Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmInt Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmFloat Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmQuaternion Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmRect Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmVector2 Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmVector3 Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmTexture Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmMaterial Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmGameObject Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmObject Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmArray Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmEnum Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, FsmString Value, ActionContext ctx) =>
        tb.AddRow(Property, Value);
    #endregion
    #region TypeSwitch
    internal static string ValueFormatTypeSwitch(this VariableType type, FsmVariables vars, string name) =>
        type switch
        {
            VariableType.Int => vars.GetFsmInt(name).FormatValue(),
            VariableType.Float => vars.GetFsmFloat(name).FormatValue(),
            VariableType.Bool => vars.GetFsmBool(name).FormatValue(),
            VariableType.Color => vars.GetFsmColor(name).FormatValue(),
            VariableType.Quaternion => vars.GetFsmQuaternion(name).FormatValue(),
            VariableType.Rect => vars.GetFsmRect(name).FormatValue(),
            VariableType.Vector2 => vars.GetFsmVector2(name).FormatValue(),
            VariableType.Vector3 => vars.GetFsmVector3(name).FormatValue(),
            VariableType.Texture => vars.GetFsmTexture(name).FormatValue(),
            VariableType.Material => vars.GetFsmMaterial(name).FormatValue(),
            VariableType.String => vars.GetFsmString(name).FormatValue(),
            VariableType.GameObject => vars.GetFsmGameObject(name).FormatValue(),
            VariableType.Object => vars.GetFsmObject(name).FormatValue(),
            VariableType.Unknown => "*Unknown*",
            VariableType.Array => vars.GetFsmArray(name).FormatValue(),
            VariableType.Enum => vars.GetFsmEnum(name).FormatValue(),
            _ => "*Unknown*"
        };  
    #endregion
}