using UnityEngine;
using UnityEngine.Video;


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
    public static TableBuilder AddRow(this TableBuilder tb, string Property, AudioClip Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.ambisonic)}", Value.ambisonic)
            .AddRow($"{Property}.{nameof(Value.channels)}", Value.channels)
            .AddRow($"{Property}.{nameof(Value.frequency)}", Value.frequency)
            .AddRow($"{Property}.{nameof(Value.isReadyToPlay)}", Value.isReadyToPlay)
            .AddRow($"{Property}.{nameof(Value.length)}", Value.length)
            .AddRow($"{Property}.{nameof(Value.loadInBackground)}", Value.loadInBackground)
            .AddRow($"{Property}.{nameof(Value.loadState)}", Value.loadState)
            .AddRow($"{Property}.{nameof(Value.loadType)}", Value.loadType)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name)
            .AddRow($"{Property}.{nameof(Value.preloadAudioData)}", Value.preloadAudioData)
            .AddRow($"{Property}.{nameof(Value.samples)}", Value.samples);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, AudioSource Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Camera Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, KeyCode Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Light Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, ParticleSystem Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Renderer Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Rigidbody Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, Rigidbody2D Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);

    public static TableBuilder AddRow(this TableBuilder tb, string Property, VideoClip Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.name)}", Value.name)
            .AddRow($"{Property}.{nameof(Value.originalPath)}", Value.originalPath);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, VideoPlayer Value, ActionContext ctx = null) =>
        Value is null
        ? tb
        : tb.AddRow($"{Property}.{nameof(Value.enabled)}", Value.enabled)
            .AddRow($"{Property}.{nameof(Value.gameObject)}", Value.gameObject)
            .AddRow($"{Property}.{nameof(Value.name)}", Value.name);
}
