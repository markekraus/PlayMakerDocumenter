using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayMakerDocumenter;

public class TableBuilder
{
    private string[] headers;
    private readonly List<string[]> rows = new();
    private readonly List<int> maxWidths = new();
    private readonly StringBuilder sb;

    public TableBuilder() => sb = new();
    public TableBuilder(StringBuilder sb) => this.sb = sb;

    public TableBuilder WithHeaders(params string[] headers)
    {
        this.headers = headers;
        return this;
    }

    public TableBuilder AddRow(params string[] row)
    {
        rows.Add(row);
        UpdateMaxWidth(row);
        return this;
    }

    private void UpdateMaxWidth(string[] items)
    {
        while (maxWidths.Count < items.Length)
        {
            maxWidths.Add(1);
        }
        for (int i = 0; i < items.Length; i++)
        {
            maxWidths[i] = Math.Max(EscapeMarkdown(items[i]).Length, maxWidths[i]);
        }
    }

    public StringBuilder BuildTable()
    {
        AppendHeaderRow(sb);
        AppendSeparatorRow(sb);
        AppendRows(sb);
        sb.AppendLine();
        return sb;
    }

    public override string ToString()
    {
        AppendHeaderRow(sb);
        AppendSeparatorRow(sb);
        AppendRows(sb);
        sb.AppendLine();
        return sb.ToString();
    }

    private string EscapeMarkdown(string text) =>
        String.IsNullOrWhiteSpace(text) ? " " :
            text.Replace("\\", "\\\\")
                .Replace("|", "\\|");

    private string GetPaddedCell(string cellText, int Column)
    {
        var escaped = EscapeMarkdown(cellText);

        if (cellText.Length == maxWidths[Column]) return escaped;

        var padding = maxWidths[Column] - escaped.Length;
        var sb = new StringBuilder(escaped);
        for (int i = 0; i < padding; i++)
            sb.Append(' ');
        return sb.ToString();
    }

    private StringBuilder AppendSeparatorRow(StringBuilder sb)
    {
        sb.Append('|');
        for (int i = 0; i < headers.Length; i++)
        {
            sb.Append(' ');
            for (int j = 0; j < maxWidths[i]; j++)
                sb.Append('-');
            sb.Append(" |");
        }
        sb.AppendLine();
        return sb;
    }

    private StringBuilder AppendHeaderRow(StringBuilder sb)
    {
        sb.Append('|');
        for (int i = 0; i < headers.Length; i++)
        {
            sb.Append(' ')
                .Append(GetPaddedCell(headers[i], i))
                .Append(" |");
        }
        sb.AppendLine();
        return sb;
    }

    private StringBuilder AppendRows(StringBuilder sb)
    {

        foreach (var row in rows)
        {
            sb.Append('|');
            for (int i = 0; i < row.Length; i++)
                sb.Append(' ')
                    .Append(GetPaddedCell(row[i], i))
                    .Append(" |");
            sb.AppendLine();
        }
        return sb;
    }
    
    public static string Testy(int choice) =>
        choice switch
        {
            _ => new StringBuilder().NewTable()
            .WithHeaders("EventName", "ToFsmState")
            .ForEachAddRow(new string[] {"a","b","c"},
                gt => new string[] { gt, gt }).BuildTable().ToString()
        };
}

public static class TableBuilderExtensions
{
    public static TableBuilder NewTable(this StringBuilder sb) => new(sb);
    public static TableBuilder ForEachAddRow<T>(this TableBuilder tb, IEnumerable<T> enumerator, Func<T, IEnumerable<string>> forEach)
    {
        foreach (var item in enumerator)
        {
            tb.AddRow(forEach(item).ToArray());
        }
        return tb;
    }
    public static TableBuilder ForEachAddRow<TKey, TValue>(
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

    public static TableBuilder WithPropertyValueHeaders(this TableBuilder tb) => tb.WithHeaders("Property", "Value");
    public static TableBuilder AddRowIfNotNull<T>(this TableBuilder tb, T nullCheckObject, Func<T, IEnumerable<string>> notNullAction) =>
        nullCheckObject is null
        ? tb
        : tb.AddRow(notNullAction(nullCheckObject).ToArray());
}