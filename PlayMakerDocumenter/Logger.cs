using System.Text;
using MelonLoader;
using UnityEngine;

namespace PlayMakerDocumenter;

internal static class Logger
{
    internal static void LogPlayMakerDocumenter(string message, LogType logType)
    {
        string log = message?.ToString() ?? "";

        switch (logType)
        {
            case LogType.Assert:
            case LogType.Log:
                Melon<Entry>.Logger.Msg(log);
                break;
            case LogType.Warning:
                Melon<Entry>.Logger.Warning(log);
                break;
            case LogType.Error:
                Melon<Entry>.Logger.Error(log);
                break;
            case LogType.Exception:
                Melon<Entry>.Logger.BigError(log);
                break;
        }
    }
    internal static void LogUniverseLib(string message, LogType logType) => LogPlayMakerDocumenter(message, logType);
}