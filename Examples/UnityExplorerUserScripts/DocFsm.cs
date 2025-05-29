string fsmPath = "/__SYSTEM/LOCKED DOORS ENGINE";
string filePath = @"D:\GameDev\modding\BluePrince\FsmDocs\LOCKED DOORS ENGINE.md";

GameObject fsmObj = GameObject.Find(fsmPath);
if (fsmObj == null)
{
    Log($"Could not find '{fsmPath}'");
    return;
}
PlayMakerFSM fsm = fsmObj.GetComponent<PlayMakerFSM>();
if (fsm == null)
{
    Log($"Could not find PLayMakerFSM on '{fsmPath}'");
    return;
}
fsm.DocumentFsm(filePath);