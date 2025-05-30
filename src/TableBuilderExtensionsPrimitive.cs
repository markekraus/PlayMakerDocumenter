namespace PlayMakerDocumenter;

/// <summary>
/// AddRow() aliases for primitive types
/// </summary>
internal static class TableBuilderExtensionsPrimitive
{
    public static TableBuilder AddRow(this TableBuilder tb, string Property, bool Value, ActionContext ctx = null) =>
        MarkdownUtilities.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, int Value, ActionContext ctx = null) =>
    MarkdownUtilities.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, long Value, ActionContext ctx = null) =>
        MarkdownUtilities.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, uint Value, ActionContext ctx = null) =>
        MarkdownUtilities.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, ulong Value, ActionContext ctx = null) =>
        MarkdownUtilities.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, float Value, ActionContext ctx = null) =>
        MarkdownUtilities.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, double Value, ActionContext ctx = null) =>
        MarkdownUtilities.TableBuilderExtensions.AddRow(tb, Property, Value);
    public static TableBuilder AddRow(this TableBuilder tb, string Property, string Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value);
    public static TableBuilder AddRow<T>(this TableBuilder tb, string Property, T Value, ActionContext ctx = null) where T : System.Enum =>
        tb.AddRow(Property, Value.ToString());
    public static TableBuilder AddRow(this TableBuilder tb, string Property, char Value, ActionContext ctx = null) =>
        tb.AddRow(Property, Value.ToString());
}