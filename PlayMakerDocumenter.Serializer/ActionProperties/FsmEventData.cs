using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, FsmEventData Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.BoolData)}", Value.BoolData);
        action.AddProperty($"{Property}.{nameof(Value.ColorData)}", Value.ColorData);
        action.AddProperty($"{Property}.{nameof(Value.FloatData)}", Value.FloatData);
        action.AddProperty($"{Property}.{nameof(Value.GameObjectData)}", Value.GameObjectData);
        action.AddProperty($"{Property}.{nameof(Value.IntData)}", Value.IntData);
        action.AddProperty($"{Property}.{nameof(Value.MaterialData)}", Value.MaterialData);
        action.AddProperty($"{Property}.{nameof(Value.ObjectData)}", $"{Value.ObjectData}");
        action.AddProperty($"{Property}.{nameof(Value.QuaternionData)}", Value.QuaternionData);
        action.AddProperty($"{Property}.{nameof(Value.RectData)}", Value.RectData);
        action.AddProperty($"{Property}.{nameof(Value.SentByAction)}.Name", Value.SentByAction.Name);
        action.AddProperty($"{Property}.{nameof(Value.SentByState)}.Name", Value.SentByState.Name);
        action.AddProperty($"{Property}.{nameof(Value.StringData)}", Value.StringData);
        action.AddProperty($"{Property}.{nameof(Value.TextureData)}", Value.TextureData);
    }
}