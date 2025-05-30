using UnityEngine;


namespace PlayMakerDocumenter;

internal static class TableBuilderExtensionsUnityEngine
{
    public static TableBuilder AddRow(this TableBuilder tb, string Property, GameObject Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow(Property, Value.GetFullPath());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Animation Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Animator Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, AsyncOperation Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.allowSceneActivation)}", Value.allowSceneActivation)
            .AddRow($"{Property}.{nameof(Value.isDone)}", Value.isDone)
            .AddRow($"{Property}.{nameof(Value.priority)}", Value.priority)
            .AddRow($"{Property}.{nameof(Value.progress)}", Value.progress);
    
    public static TableBuilder AddRow(this TableBuilder tb, string Property, ParticleSystem Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.automaticCullingEnabled)}", Value.automaticCullingEnabled)
            .AddRow($"{Property}.{nameof(Value.duration)}", Value.duration)
            .AddRow($"{Property}.{nameof(Value.emissionRate)}", Value.emissionRate)
            .AddRow($"{Property}.{nameof(Value.enableEmission)}", Value.enableEmission)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.gravityModifier)}", Value.gravityModifier)
            .AddRow($"{Property}.{nameof(Value.isEmitting)}", Value.isEmitting)
            .AddRow($"{Property}.{nameof(Value.isPaused)}", Value.isPaused)
            .AddRow($"{Property}.{nameof(Value.isPlaying)}", Value.isPlaying)
            .AddRow($"{Property}.{nameof(Value.isStopped)}", Value.isStopped)
            .AddRow($"{Property}.{nameof(Value.loop)}", Value.loop)
            .AddRow($"{Property}.{nameof(Value.maxParticles)}", Value.maxParticles)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name)
            .AddRow($"{Property}.{nameof(Value.particleCount)}", Value.particleCount)
            .AddRow($"{Property}.{nameof(Value.playbackSpeed)}", Value.playbackSpeed)
            .AddRow($"{Property}.{nameof(Value.playOnAwake)}", Value.playOnAwake)
            .AddRow($"{Property}.{nameof(Value.proceduralSimulationSupported)}", Value.proceduralSimulationSupported)
            .AddRow($"{Property}.{nameof(Value.randomSeed)}", Value.randomSeed)
            .AddRow($"{Property}.{nameof(Value.startColor)}", Value.startColor)
            .AddRow($"{Property}.{nameof(Value.startLifetime)}", Value.startLifetime)
            .AddRow($"{Property}.{nameof(Value.startRotation)}", Value.startRotation)
            .AddRow($"{Property}.{nameof(Value.startRotation3D)}", Value.startRotation3D)
            .AddRow($"{Property}.{nameof(Value.startSize)}", Value.startSize)
            .AddRow($"{Property}.{nameof(Value.startSpeed)}", Value.startSpeed)
            .AddRow($"{Property}.{nameof(Value.time)}", Value.time)
            .AddRow($"{Property}.{nameof(Value.useAutoRandomSeed)}", Value.useAutoRandomSeed);
}


/*
UnityEngine.AudioClip
UnityEngine.AudioSource
UnityEngine.Camera
UnityEngine.Color
UnityEngine.KeyCode
UnityEngine.Light
UnityEngine.Renderer
UnityEngine.Rigidbody
UnityEngine.Rigidbody2D
UnityEngine.Space
UnityEngine.Vector3
UnityEngine.Video.VideoClip
UnityEngine.Video.VideoPlayer
*/
