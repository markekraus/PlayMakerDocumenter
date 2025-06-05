using System.Collections.Generic;
using System.Linq;

namespace PlayMakerDocumenter.Serializer;

public record FsmVariableDoc
{
    public string Name;
    public string Type;
    public string Value;
    public FsmVariableDoc() { }
    public FsmVariableDoc(string Name, string Type, string Value) =>
        (this.Name, this.Type, this.Value) =
        (Name, Type, Value);
}

internal static class FsmVariableDocExtensions
{
    public static IEnumerable<FsmActionProperty> ConvertToActionProperty(this IEnumerable<FsmVariableDoc> list) =>
        list.Select(fsmVar => (FsmActionProperty)fsmVar);
}