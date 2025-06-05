using UnityEngine;

namespace PlayMakerDocumenter.Serializer.ActionProperties;

internal static partial class ActionPropertiesExtensions
{
    public static void AddProperty(this FsmActionDoc action, string Property, AudioClip Value)
    {
        if (action is null || Property is null) return;
        if (Value is null) { action.AddProperty(Property, "null"); return; }
        action.AddProperty($"{Property}.{nameof(Value.ambisonic)}", Value.ambisonic);
        action.AddProperty($"{Property}.{nameof(Value.channels)}", Value.channels);
        action.AddProperty($"{Property}.{nameof(Value.frequency)}", Value.frequency);
        action.AddProperty($"{Property}.{nameof(Value.isReadyToPlay)}", Value.isReadyToPlay);
        action.AddProperty($"{Property}.{nameof(Value.length)}", Value.length);
        action.AddProperty($"{Property}.{nameof(Value.loadInBackground)}", Value.loadInBackground);
        action.AddProperty($"{Property}.{nameof(Value.loadState)}", Value.loadState);
        action.AddProperty($"{Property}.{nameof(Value.loadType)}", Value.loadType);
        action.AddProperty($"{Property}.{nameof(Value.name)}", Value.name);
        action.AddProperty($"{Property}.{nameof(Value.preloadAudioData)}", Value.preloadAudioData);
        action.AddProperty($"{Property}.{nameof(Value.samples)}", Value.samples);
    }
}