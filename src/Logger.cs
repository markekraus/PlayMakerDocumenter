using System.Text;
using MelonLoader;

namespace PlayMakerDocumenter
{
    public static class Logger
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
        public static StringBuilder LogMsg(this StringBuilder sb)
        {
            Melon<Entry>.Logger.Msg(sb);
            return sb;
        }
    }
}