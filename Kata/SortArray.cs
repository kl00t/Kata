namespace Kata;

public static class SortArray
{
    public static object[] Sort(object[] array)
    {
        var nonZeros = array.Where(item => item is not (object)0 or null).ToList();
        var zeros = array.Where(item => item != null && item.Equals(0)).ToList();
        return nonZeros.Concat(zeros).ToArray();
    }
}