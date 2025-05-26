using System;
using System.Collections.Generic;
using System.Text;

namespace PlayMakerDocumenter;

public class MDTableBuilder
{
    private string[] headers;
    private List<string[]> rows = new();
    private List<int> maxWidths = new();

    public MDTableBuilder() { }

    public MDTableBuilder WithHeaders(params string[] headers)
    {
        this.headers = headers;
        return this;
    }

    public MDTableBuilder AddRow(params string[] row)
    {
        rows.Add(row);
        UpdateMaxWidth(row);
        return this;
    }

    private void UpdateMaxWidth(string[] items)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (!(maxWidths.Count >= i + 1))
                maxWidths.Add(1);
            maxWidths[i] = Math.Max(EscapeMarkdown(items[i]).Length, maxWidths[i]);
        }
    }

    public string Build() => ToString();

    public override string ToString()
    {
        var sb = new StringBuilder();

        AppendHeaderRow(sb);
        AppendSeparatorRow(sb);
        AppendRows(sb);

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
    
}