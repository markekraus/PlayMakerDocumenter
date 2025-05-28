using System.Text;
using MelonLoader;
using UnityEngine;

namespace PlayMakerDocumenter;

internal static class Logger
{
    public static string LogMsg(string line)
    {
        Melon<Entry>.Logger.Msg(line);
        return line;
    }
    public static string LogError(string line)
    {
        Melon<Entry>.Logger.Error(line);
        return line;
    }
    public static string LogWarn(string line)
    {
        Melon<Entry>.Logger.Error(line);
        return line;
    }
    public static StringBuilder LogMsg(this StringBuilder sb)
    {
        Melon<Entry>.Logger.Msg(sb);
        return sb;
    }
    internal static void LogUniverseLib(string message, LogType logType)
    {
        string log = message?.ToString() ?? "";

        switch (logType)
        {
            case LogType.Assert:
            case LogType.Log:
                LogMsg(log);
                break;
            case LogType.Warning:
                LogWarn(log);
                break;
            case LogType.Error:
            case LogType.Exception:
                LogError(log);
                break;
        }
    }
}