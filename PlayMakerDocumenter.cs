using Il2Cpp;
using MelonLoader;
using UnityEngine;
using System.Collections.Generic;
using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter
{
    public class Entry : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName != "Mount Holly Estate") return;

            System.Console.WriteLine("# PlayMaker FSM Documentation");
            System.Console.WriteLine("");
            System.Console.WriteLine($"- productName: {Application.productName}");
            System.Console.WriteLine($"- companyName: {Application.companyName}");
            System.Console.WriteLine($"- version: {Application.version}");
            System.Console.WriteLine($"- buildGUID: {Application.buildGUID}");
            System.Console.WriteLine($"- unityVersion: {Application.unityVersion}");
            System.Console.WriteLine($"- PlayMaker Assembly Version: {typeof(PlayMakerFSM).Assembly.GetName().Version}");
            System.Console.WriteLine("");

            foreach (var fsm in Resources.FindObjectsOfTypeAll<PlayMakerFSM>())
            {
                System.Console.WriteLine($"## {fsm.name}");
                System.Console.WriteLine("");
                System.Console.WriteLine($"- Full Path: {fsm.transform.GetFullPath()}");
                System.Console.WriteLine($"- FsmName: {fsm.FsmName}");
                System.Console.WriteLine($"- Active: {fsm.Active}");
                System.Console.WriteLine($"- ActiveStateName: {fsm.ActiveStateName}");
                System.Console.WriteLine($"- enabled: {fsm.enabled}");
                System.Console.WriteLine($"- FsmDescription: {fsm.FsmDescription}");
                System.Console.WriteLine("");
                DocumentFsmEvents(fsm);
                var globalTransitionLookup = DocumentFsmGlobalTransitions(fsm);
                DocumentFsmVariables(fsm);

            }
        }

        private static void DocumentFsmVariables(PlayMakerFSM fsm, bool tailingLine = true)
        {
            if (fsm.FsmVariables is null ||
                fsm.FsmVariables._variableLookup is null ||
                fsm.FsmVariables._variableLookup.Count <= 0)
                return;

            System.Console.WriteLine("### FsmVariables");
            System.Console.WriteLine("");
            var tb = new MDTableBuilder();
            tb.WithHeaders("Name", "Value", "Type");

            foreach (var variable in fsm.FsmVariables._variableLookup)
            {
                var name = variable.key;
                var type = variable.value.ObjectType;
                string value = "";

                switch (variable.Value)
                {
                    case null:
                        break;
                    case FsmGameObject fsmGameObject:
                        value = fsmGameObject.Value.transform.GetFullPath();
                        break;
                    case FsmFloat fsmFloat:
                        value = $"{fsmFloat.Value}";
                        break;
                    case FsmInt fsmInt:
                        value = $"{fsmInt.Value}";
                        break;
                    case FsmBool fsmBool:
                        value = $"{fsmBool}";
                        break;
                    case FsmVector2 fsmVector2:
                        value = $"x: {fsmVector2.Value.x}, y: {fsmVector2.Value.y}";
                        break;
                    case FsmVector3 fsmVector3:
                        value = $"x: {fsmVector3.Value.x}, y: {fsmVector3.Value.y}, z: {fsmVector3.Value.z}";
                        break;
                    case FsmString fsmString:
                        value = fsmString.Value;
                        break;
                    case FsmRect fsmRect:
                        value = $"x: {fsmRect.Value.x}, y: {fsmRect.Value.y}, width: {fsmRect.Value.width}, height: {fsmRect.Value.height}";
                        break;
                    case FsmQuaternion fsmQuaternion:
                        value = $"x: {fsmQuaternion.Value.x}, y: {fsmQuaternion.Value.y}, z: {fsmQuaternion.Value.z}, w: {fsmQuaternion.Value.w}";
                        break;
                    case FsmColor fsmColor:
                        value = $"r: {fsmColor.Value.r}, g: {fsmColor.Value.g}, b: {fsmColor.Value.b}, a: {fsmColor.Value.a}";
                        break;
                    case FsmMaterial fsmMaterial:
                        value = $"name: {fsmMaterial.Value.name}";
                        break;
                    case FsmTexture fsmTexture:
                        value = $"name: {fsmTexture.Value.name}";
                        break;
                    case FsmObject fsmObject:
                        value = $"type: {fsmObject.ObjectType}, name: {fsmObject.name}";
                        break;
                    case FsmEnum fsmEnum:
                        value = $"type: {fsmEnum.EnumType}, value: {fsmEnum.Value}";
                        break;
                    case FsmArray fsmArray:
                        value = $"ElementType: {fsmArray.ElementType}, count: {fsmArray.Values.Count}";
                        break;
                }

                tb.AddRow(name, value, type.Name);
                System.Console.WriteLine(tb);
                if (tailingLine)
                    System.Console.WriteLine("");
            }
        }

        private static Dictionary<string, string> DocumentFsmGlobalTransitions(PlayMakerFSM fsm, bool tailingLine = true)
        {
            var result = new Dictionary<string, string>();

            if (fsm.FsmGlobalTransitions is null || fsm.FsmGlobalTransitions.Count <= 0) return result;

            System.Console.WriteLine($"### FsmGlobalTransitions");
            System.Console.WriteLine("");
            var tb = new MDTableBuilder();
            tb.WithHeaders("EventName", "ToState");

            foreach (var transition in fsm.FsmGlobalTransitions)
            {
                tb.AddRow(transition.EventName, transition.ToState);
                result.Add(transition.EventName, transition.ToState);
            }

            System.Console.WriteLine(tb);
            if (tailingLine)
                System.Console.WriteLine("");
            return result;
        }

        private static void DocumentFsmEvents(PlayMakerFSM fsm, bool tailingLine = true)
        {
            if (fsm.FsmEvents is null || fsm.FsmEvents.Count <= 0) return;

            System.Console.WriteLine($"### FsmEvents");
            System.Console.WriteLine("");
            System.Console.WriteLine("| Name | Path |");
            System.Console.WriteLine("| ---- | ---- |");

            foreach (var fsmEvent in fsm.FsmEvents)
            {
                System.Console.WriteLine($"| {fsmEvent.Name} | {fsmEvent.Path} |");
            }

            if (tailingLine)
                System.Console.WriteLine("");
        }
    }
}
