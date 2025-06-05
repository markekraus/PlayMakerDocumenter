using Il2CppHutongGames.PlayMaker;

namespace PlayMakerDocumenter.Serializer;

public record FsmEventDoc(string Name, string Path)
{
    public static implicit operator FsmEventDoc(FsmEvent fsmEvent)
    {
        if (fsmEvent is null) return new("null", "null");
        var name = fsmEvent.Name is null ? "null" : fsmEvent.Name;
        var path = fsmEvent.Path is null ? "null" : fsmEvent.Path;
        return new(name, path);
    }
}