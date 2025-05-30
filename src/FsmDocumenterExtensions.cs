using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PlayMakerDocumenter;

internal static class FsmDocumenterExtensions
{
    internal static TableBuilder ForEachAddRow<TKey, TValue>(
        this TableBuilder tb,
        Il2CppSystem.Collections.Generic.Dictionary<TKey, TValue> dict,
        Func<Il2CppSystem.Collections.Generic.KeyValuePair<TKey, TValue>, IEnumerable<string>> forEach)
    {
        foreach (var item in dict)
        {
            tb.AddRow(forEach(item).ToArray());
        }
        return tb;
    }
    internal static bool IsNullOrWhiteSpace(this string @string) => string.IsNullOrWhiteSpace(@string);
    internal static StringBuilder AppendHeader(this StringBuilder sb, string header) =>
        sb.AppendLine(header).AppendLine("");
    internal static StringBuilder WriteToFile(this StringBuilder sb, string filePath)
    {
        File.WriteAllText(filePath, sb.ToString());
        return sb;
    }
    internal static StringBuilder WriteToLog(this StringBuilder sb)
    { LogMsg(sb.ToString()); return sb; }
}
