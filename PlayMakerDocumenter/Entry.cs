using System;
using System.Linq;
using MelonLoader;
using MelonLoader.Utils;
using UniverseLib;

namespace PlayMakerDocumenter;

public class Entry : MelonMod
{
    public override void OnLateInitializeMelon()
    {
        LogHandler = Logger.LogPlayMakerDocumenter;
        if (AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(ass => ass.FullName.Contains("UnityExplorer"), null) is not null)
        {
            LogMsg("UnityExplorer will initialize UniverseLib for us. Skipping.");
            return;
        }
        Universe.Init(1f, null, LogUniverseLib, new()
        {
            Unhollowed_Modules_Folder = MelonEnvironment.Il2CppAssembliesDirectory
        });
        LogMsg("Initialized");
    }
}
