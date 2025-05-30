using Il2Cpp;
using MelonLoader;
using PlayMakerDocumenter;
using UnityEngine;
namespace MelonExample;

public partial class MelonExample : MelonMod
{
    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        if (sceneName != "Mount Holly Estate") return;

        var toDoc = new (string, string)[]
        {
            ("/__SYSTEM/LOCKED DOORS ENGINE",
                @"D:\Program Files (x86)\Steam\steamapps\common\Blue Prince\ModCode\PlayMakerDocumenter\Examples\FsmDocs\LOCKED DOORS ENGINE.md"),
            ("/__SYSTEM/Luck Calculator",
                @"D:\Program Files (x86)\Steam\steamapps\common\Blue Prince\ModCode\PlayMakerDocumenter\Examples\FsmDocs\Luck Calculator.md")
        };

        foreach (var pair in toDoc)
        {
            var fsmPath = pair.Item1;
            var filePath = pair.Item2;
            var fsmObj = GameObject.Find(fsmPath);
            if (fsmObj == null)
            {
                LoggerInstance.Error($"Could not find '{fsmPath}'");
                return;
            }
            var fsm = fsmObj.GetComponent<PlayMakerFSM>();
            if (fsm == null)
            {
                LoggerInstance.Error($"Could not find PLayMakerFSM on '{fsmPath}'");
                return;
            }
            fsm.DocumentFsm(filePath);
        }
    }
}
