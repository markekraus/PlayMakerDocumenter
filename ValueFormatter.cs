using Il2CppHutongGames.PlayMaker;
using UniverseLib;

namespace PlayMakerDocumenter;

public static class ValueFormatter
{
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
    public static string FormatValue(this FsmGameObject fsmGameObject) =>
        fsmGameObject is null || fsmGameObject.Value is null
        ? "null"
        : fsmGameObject.value.GetFullPath();
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
    
    public static string ValueFormatTypeSwitch(this VariableType type, FsmVariables vars, string name) =>
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
}