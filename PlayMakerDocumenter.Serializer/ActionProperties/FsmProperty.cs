using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, FsmProperty Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        try { action.AddProperty($"{Property}.{nameof(Value.ArrayParameter)}", Value.ArrayParameter); }
        catch { LogError($"{Property}.{nameof(Value.ArrayParameter)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.BoolParameter)}", Value.BoolParameter); }
        catch { LogError($"{Property}.{nameof(Value.BoolParameter)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.ColorParameter)}", Value.ColorParameter); }
        catch { LogError($"{Property}.{nameof(Value.ColorParameter)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.EnumParameter)}", Value.EnumParameter); }
        catch { LogError($"{Property}.{nameof(Value.EnumParameter)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.FloatParameter)}", Value.FloatParameter); }
        catch { LogError($"{Property}.{nameof(Value.FloatParameter)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.GameObjectParameter)}", Value.GameObjectParameter); }
        catch { LogError($"{Property}.{nameof(Value.GameObjectParameter)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.initialized)}", Value.initialized); }
        catch { LogError($"{Property}.{nameof(Value.initialized)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.IntParameter)}", Value.IntParameter); }
        catch { LogError($"{Property}.{nameof(Value.IntParameter)}"); }
        try { action.AddProperty($"{Property}.{nameof(Value.MaterialParameter)}", Value.MaterialParameter); }
        catch { LogError($"{Property}.{nameof(Value.MaterialParameter)}"); }

        if (Value.memberInfo is not null)
        {
            for (int i = 0; i < Value.memberInfo.Count; i++)
            {
                var memberInfo = Value.memberInfo[i];
                if (memberInfo is null) continue;
                try { action.AddProperty($"{Property}.{nameof(Value.memberInfo)}[{i}]", memberInfo); }
                catch { LogError($"{Property}.{nameof(Value.memberInfo)}[{i}]"); }
            }
        }

        try {action.AddProperty($"{Property}.{nameof(Value.PropertyName)}", Value.PropertyName); }
            catch { LogError($"{Property}.{nameof(Value.PropertyName)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.PropertyType)}", Value.PropertyType);}
            catch { LogError($"{Property}.{nameof(Value.PropertyType)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.QuaternionParameter)}", Value.QuaternionParameter);}
            catch { LogError($"{Property}.{nameof(Value.QuaternionParameter)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.RectParamater)}", Value.RectParamater);}
            catch { LogError($"{Property}.{nameof(Value.RectParamater)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.setProperty)}", Value.setProperty);}
            catch { LogError($"{Property}.{nameof(Value.setProperty)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.StringParameter)}", Value.StringParameter);}
            catch { LogError($"{Property}.{nameof(Value.StringParameter)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.TargetObject)}", Value.TargetObject);}
            catch { LogError($"{Property}.{nameof(Value.TargetObject)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.TargetType)}", Value.TargetType);}
            catch { LogError($"{Property}.{nameof(Value.TargetType)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.TargetTypeName)}", Value.TargetTypeName);}
            catch { LogError($"{Property}.{nameof(Value.TargetTypeName)}"); }
        try{action.AddProperty($"{Property}.{nameof(Value.TextureParameter)}", Value.TextureParameter);}
            catch { LogError($"{Property}.{nameof(Value.TextureParameter)}"); }
    }
}