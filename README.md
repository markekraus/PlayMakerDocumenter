# PlayMaker Documenter

A MelonLoader mod for documenting PlayMaker Finite-State Machines (FSMs) in Unity video games.

This mod is currently tested only on Blue Prince.

## Installation

1. Install [Melon Loader](https://melonwiki.xyz/#/?id=automated-installation) for Blue Prince
2. Download an install [UnityExplorer](https://github.com/yukieiji/UnityExplorer)
3. Download the [latest release](https://github.com/markekraus/PlayMakerDocumenter/releases)
4. Copy `PlayMakerDocumenter.ML.IL2CPP.dll` to the `Mods` folder in your Blue Prince install folder (i.e. `C:\Program Files (x86)\Steam\steamapps\common\Blue Prince\Mods`)

## Usage

This mod is primarily used by other mods or in conjunction with [UnityExplorer](https://github.com/yukieiji/UnityExplorer) (yukieji's fork) for reverse engineering [PlayMaker](https://hutonggames.com/) FSMs.
Currently, this mod cannot be used on it's own.
Maybe one day I'll make a UI for it.

### MelonLoader Mod Project

You can reference the DLL in your csproj file:

```xml
    <ItemGroup>
        <Reference Include="PlayMakerDocumenter">
            <HintPath>..\path\to\PlayMakerDocumenter.ML.IL2CPP.dll</HintPath>
            <Private>false</Private>
        </Reference>
    </ItemGroup>
```

You can then use `FsmDocumenter` in your project:

```csharp
using PlayMakerDocumenter;

namespace MyMod;

public class MyMod : MelonMod
{
    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName != "Mount Holly Estate") return;

        string fsmPath = "/__SYSTEM/LOCKED DOORS ENGINE";
        string filePath = @"D:\GameDev\modding\BluePrince\FsmDocs\LOCKED DOORS ENGINE.md";

        GameObject fsmObj = GameObject.Find(fsmPath);
        if (fsmObj is null)
        {
            LoggerInstance.Msg($"Could not find '{fsmPath}'");
            return;
        }
        PlayMakerFSM fsm = fsmObj.GetComponent<PlayMakerFSM>();
        if (fsm is null)
        {
            LoggerInstance.Msg($"Could not find PLayMakerFSM on '{fsmPath}'");
            return;
        }
        fsm.DocumentFsm(filePath);
    }
}
```

### UnityExplorer User Script

UnityExplorer's C# console was the original use case for this mod.
[2 user scripts](Examples\UnityExplorerUserScripts\) have been included in the examples.
Download those an place them in your game's `Mods\sinai-dev-UnityExplorer\Scripts`.
With Blue Prince from Steam, the full path looks like `C:\Program Files (x86)\Steam\steamapps\common\Blue Prince\Mods\sinai-dev-UnityExplorer\Scripts`

Then you can use them in the UnityExplorer C# console.

1. Select the MyUsings.cs from the drop down.
2. Click Compile at least twice.
3. Select the DocFsm.cs from the drop down.
4. Modify the FSM path and file path
5. Click Compile twice

Yes, you must click compile at least twice for each step.

![MyUsings.cs](img\MyUsings.cs.png) ![DocFsm.cs](img\DocFsm.cs.png)

The result will be an entry in the log like this

```text
17:31:16.169] [UnityExplorer] Try Update exists code....
[17:31:16.172] [UnityExplorer] Success!! override
replacing fieldspec for fsmPath
replacing fieldspec for filePath
replacing fieldspec for fsmObj
replacing fieldspec for fsm
[17:31:17.290] [PlayMakerDocumenter] FSM Doc: D:\GameDev\modding\BluePrince\FsmDocs\LOCKED DOORS ENGINE.md
[17:31:17.292] [UnityExplorer] Invoked REPL (no return value)
[17:31:17.293] [UnityExplorer] Try Update exists code....
[17:31:17.295] [UnityExplorer] Success!! override
```
