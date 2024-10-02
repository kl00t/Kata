public static class Extensions
{
    public static string OutputAsString(this object[] myArray)
    {
        return string.Join(", ", myArray.Select(item => item.ToString()));
    }
}