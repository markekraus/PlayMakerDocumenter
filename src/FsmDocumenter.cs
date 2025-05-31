using System.Text;
using Il2Cpp;
using UnityEngine;

namespace PlayMakerDocumenter;

/// <summary>
/// Public interface for PlayMakerDocumenter.
/// </summary>
public static partial class FsmDocumenter
{
    /// <summary>
    /// Documents a <see cref="PlayMakerFSM"/> in markdown to the specified <paramref name="filePath"/>.
    /// <example>
    /// <code>
    /// FsmDocumenter.DocumentFsm("/path/to/target/fsm". "c:\path\to\file.md");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="fsmPath">The GameObject path of the <see cref="PlayMakerFSM"/> to document.</param>
    /// <param name="filePath">The file system path of the output markdown file.</param>
    public static void DocumentFsm(string fsmPath, string filePath)
    {
        var fsmObj = GameObject.Find(fsmPath);
        if (fsmObj is null) { LogError($"Could not find '{fsmPath}'"); return; }

        var fsm = fsmObj.GetComponent<PlayMakerFSM>();
        if (fsm is null) { LogError($"Could not find PLayMakerFSM on '{fsmPath}'"); return; }

        fsm.DocumentFsm(filePath);
    }
    /// <summary>
    /// Documents a <see cref="PlayMakerFSM"/> in markdown to the specified <paramref name="filePath"/>.
    /// <example>
    /// <code>
    /// fsm.DocumentFsm("c:\path\to\file.md");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="fsm">The <see cref="PlayMakerFSM"/> to document.</param>
    /// <param name="filePath">The file system path of the output markdown file.</param>
    public static void DocumentFsm(this PlayMakerFSM fsm, string filePath)
    {
        if (fsm is null) { LogError("Fsm was null"); return; }
        if (filePath.IsNullOrWhiteSpace()) { LogError("Fsm was null"); return; }

        new StringBuilder()
            .AppendHeader("# PlayMaker FSM Documentation")
            .DocEnvironmentDetails()
            .DocFsmDetails(fsm)
            .DocGlobalTransitions(fsm)
            .DocFsmVariables(fsm)
            .DocFsmEvents(fsm)
            .DocFsmStates(fsm)
            .WriteToFile(filePath);
        LogMsg($"FSM Doc: {filePath}");
    }
}