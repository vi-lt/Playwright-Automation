public static class Randomizes
{
    // Add more helper methods as needed
    public static T RandomArray<T>(T[] array)
    {
        Random random = new();
        int randomIndex = random.Next(0, array.Length);
        return array[randomIndex];
    }

}