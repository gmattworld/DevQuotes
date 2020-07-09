namespace DevQuotes.Utilities
{
    public static class Helpers
    {
        public static string Trunc(this string value, int count)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= count ? value : $"{value.Substring(0, count)}...";
        }
    }
}
