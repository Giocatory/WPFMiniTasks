using System.Collections.Generic;

namespace ForExperiments.Data
{
    internal static class GeneralQuestionsList
    {
        public static List<List<string>> Contents = new();
        public static List<List<string>> JuniorContent = new();
        public static List<List<string>> MiddleContent = new();
        public static List<List<string>> SeniorContent = new();

        public static void ClearContents() => Contents.Clear();
        public static void ClearJuniorContent() => JuniorContent.Clear();
        public static void ClearMiddleContent() => MiddleContent.Clear();
        public static void ClearSeniorContent() => SeniorContent.Clear();
    }
}