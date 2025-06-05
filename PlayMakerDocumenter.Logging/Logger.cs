using System;
using System.Text;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("PlayMakerDocumenter.Serializer.ML.IL2CPP")]
[assembly: InternalsVisibleTo("PlayMakerDocumenter.ML.IL2CPP")]

namespace PlayMakerDocumenter.Logging;

internal static class Logger
{
    public static Action<string, LogType> LogHandler = (msg, logType) => Console.WriteLine(msg);
    public static string LogMsg(string line)
    {
        LogHandler(line, LogType.Log);
        return line;
    }
    public static string LogError(string line)
    {
        LogHandler(line, LogType.Error);
        return line;
    }
    public static string LogException(Exception ex)
    {
        LogHandler($"{ex}", LogType.Exception);
        return $"{ex}";
    }
    public static string LogWarn(string line)
    {
        LogHandler(line, LogType.Warning);
        return line;
    }
    public static StringBuilder LogMsg(this StringBuilder sb)
    {
        LogHandler(sb.ToString(), LogType.Error);
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