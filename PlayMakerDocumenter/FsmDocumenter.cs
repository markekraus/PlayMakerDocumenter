using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Il2Cpp;
using Newtonsoft.Json;
using UnityEngine;

namespace PlayMakerDocumenter;

/// <summary>
/// Public interface for PlayMakerDocumenter.
/// </summary>
public static partial class FsmDocumenter
{
    public const string AppNamespaceString = "c9d71ad1-b78e-4bc8-94cc-404db44cfd48";
    public static readonly Guid AppNamespace = new(AppNamespaceString);
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
    /// <param name="enableLogs">Whether or not to enable logging. Default is True.</param>
    public static void DocumentFsm(string fsmPath, string filePath, bool enableLogs = true)
    {
        var fsmObj = GameObject.Find(fsmPath);
        if (fsmObj is null) { LogError($"Could not find '{fsmPath}'"); return; }

        var fsm = fsmObj.GetComponent<PlayMakerFSM>();
        if (fsm is null) { LogError($"Could not find PLayMakerFSM on '{fsmPath}'"); return; }

        fsm.DocumentFsm(filePath, enableLogs);
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
    /// <param name="enableLogs">Whether or not to enable logging. Default is True.</param>
    public static void DocumentFsm(this PlayMakerFSM fsm, string filePath, bool enableLogs = true)
    {
        if (fsm is null) { LogError("fsm was null"); return; }
        if (filePath.IsNullOrWhiteSpace()) { LogError("filePath was null"); return; }

        new StringBuilder()
            .AppendHeader($"# {fsm.GetFullPath()}")
            .DocEnvironmentDetails()
            .DocFsmDetails(fsm)
            .DocGlobalTransitions(fsm)
            .DocFsmVariables(fsm)
            .DocFsmEvents(fsm)
            .DocFsmStates(fsm)
            .WriteToFile(filePath);
        if (enableLogs)
            LogMsg($"FSM Doc: {filePath}");
    }
    /// <summary>
    /// Documents all <see cref="PlayMakerFSM"/>s in markdown to the specified <paramref name="OutputDirectory"/>.
    /// <example>
    /// <code>
    /// FsmDocumenter.DocumentAllFsm("c:\path\to\output\directory\");
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="OutputDirectory">Directory where <see cref="PlayMakerFSM"/> markdown docs will be stored.</param> 
    /// <param name="IncludeInactive"><see cref="FindObjectsInactive"/> setting to include or exclude inactive <see cref="PlayMakerFSM"/>s. Default is Include.</param> 
    /// <param name="DeleteExistingFiles">Whether to delete existing markdown files (*.md) from <paramref name="OutputDirectory"/>. Default is False.</param> 
    public static void DocumentAllFsm(string OutputDirectory, FindObjectsInactive IncludeInactive = FindObjectsInactive.Include, bool DeleteExistingFiles = false)
    {
        if (OutputDirectory.IsNullOrWhiteSpace()) { LogError("outputDirectory was null"); return; }

        DirectoryInfo outputDir;
        try { outputDir = Directory.CreateDirectory(OutputDirectory); }
        catch (Exception ex) { LogError(ex.Message); return; }

        if (DeleteExistingFiles)
        {
            foreach (var file in outputDir.EnumerateFiles("*.md"))
            {
                try { file.Delete(); }
                catch (Exception ex) { LogError(ex.Message); return; }
            }
        }
        var indexFile = Path.Join(outputDir.FullName, "index.json");
        LogMsg($"Index file: {indexFile}");
        LogWarn($"This process may take some time and the game will be frozen until it completes or fails.");
        var fsmList = GameObject.FindObjectsByType<PlayMakerFSM>(IncludeInactive, FindObjectsSortMode.None);
        var index = new List<DocumentMap>(fsmList.Count);
        var i = 1;
        var fails = 0;
        LogMsg($"Processing {i} of {fsmList.Count}...");
        var nextUpdate = DateTime.UtcNow.AddSeconds(3);
        foreach (var fsm in fsmList)
        {
            if (DateTime.UtcNow > nextUpdate)
            {
                LogMsg($"Processing {i} of {fsmList.Count}...");
                nextUpdate = DateTime.UtcNow.AddSeconds(3);
            }
            var curDoc = DocumentMap.Create(fsm);
            try
            {
                fsm.DocumentFsm(curDoc.GetFullPath(outputDir), false);
                index.Add(curDoc);
            }
            catch (Exception ex)
            {
                fails++;
                LogError($"Failed to process FSM: {curDoc}");
                LogException(ex);
            }
            i++;
        }
        File.WriteAllText(indexFile, JsonConvert.SerializeObject(index.OrderBy(ind => ind.FileName), Formatting.Indented));
        LogMsg($"Index file: {indexFile}");
        LogMsg($"Documented {fsmList.Count - fails} of {fsmList.Count} PlayMakerFSMs with {fails} failures.");
    }

    /// <summary>
    /// Documents all <see cref="PlayMakerFSM"/>s in markdown to the specified <paramref name="OutputDirectory"/>.
    /// <example>
    /// <code>
    /// FsmDocumenter.DocumentAllFsm("c:\path\to\output\directory\", true);
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="OutputDirectory">Directory where <see cref="PlayMakerFSM"/> markdown docs will be stored.</param> 
    /// <param name="DeleteExistingFiles">Whether to delete existing markdown files (*.md) from <paramref name="OutputDirectory"/>. Default is False.</param> 
    public static void DocumentAllFsm(string OutputDirectory, bool DeleteExistingFiles) =>
        DocumentAllFsm(OutputDirectory, DeleteExistingFiles: DeleteExistingFiles);

    /// <summary>
    /// Documents all <see cref="PlayMakerFSM"/>s in markdown to the specified <paramref name="OutputDirectory"/>.
    /// <example>
    /// <code>
    /// FsmDocumenter.DocumentAllFsm("c:\path\to\output\directory\", FindObjectsInactive.Exclude);
    /// </code>
    /// </example>
    /// </summary>
    /// <param name="OutputDirectory">Directory where <see cref="PlayMakerFSM"/> markdown docs will be stored.</param> 
    /// <param name="IncludeInactive"><see cref="FindObjectsInactive"/> setting to include or exclude inactive <see cref="PlayMakerFSM"/>s. Default is Include.</param> 
    public static void DocumentAllFsm(string OutputDirectory, FindObjectsInactive IncludeInactive) =>
        DocumentAllFsm(OutputDirectory, IncludeInactive: IncludeInactive);
}