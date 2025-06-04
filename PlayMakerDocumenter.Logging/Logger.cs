using System;
using System.Text;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("PlayMakerDocumenter.Serializer.ML.IL2CPP")]
[assembly: InternalsVisibleTo("PlayMakerDocumenter")]

namespace PlayMakerDocumenter.Logging;

internal static class Logger
{
    public static Action<string, LogType> logHandler = (msg, logType) => Console.WriteLine(msg);
    public static string LogMsg(string line)
    {
        logHandler(line, LogType.Log);
        return line;
    }
    public static string LogError(string line)
    {
        logHandler(line, LogType.Error);
        return line;
    }
    public static string LogException(Exception ex)
    {
        logHandler($"{ex}", LogType.Exception);
        return $"{ex}";
    }
    public static string LogWarn(string line)
    {
        logHandler(line, LogType.Warning);
        return line;
    }
    public static StringBuilder LogMsg(this StringBuilder sb)
    {
        logHandler(sb.ToString(), LogType.Error);
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