public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) => str.Split(delimiter)[1];   

    public static string SubstringBetween(this string str, string remover, string remover2) => str.Split(remover)[1].Split(remover2)[0];

    public static string Message(this string str) => str.Split(':')[1].Trim();

    public static string LogLevel(this string str) => str.Split(':')[0].Replace("[", "").Replace("]", "");
    
}