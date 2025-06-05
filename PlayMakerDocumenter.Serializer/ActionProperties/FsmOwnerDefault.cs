using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, FsmOwnerDefault Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.OwnerOption)}", Value.OwnerOption);
        if (Value.OwnerOption == OwnerDefaultOption.UseOwner)
        {
            action.AddProperty($"{Property}.{nameof(Value.GameObject)}", action.ctx.Fsm);
        }
        if (Value.OwnerOption == OwnerDefaultOption.SpecifyGameObject)
        {
            action.AddProperty($"{Property}.{nameof(Value.GameObject)}", Value.GameObject);
        }
    }
}