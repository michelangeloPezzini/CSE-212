public static class Arrays
{
    /// <summary>
    /// This method generates an array of 'count' elements, starting with 'start' and followed by its multiples. 
    /// For example, calling MultiplesOf(7, 5) will return: {7, 14, 21, 28, 35}. The 'count' must be a positive integer.
    /// </summary>
    /// <returns>An array of integers representing the multiples of the given number.</returns>
    public static int[] MultiplesOf(int start, int count)
    {
        // Step 1: Create an array to store the calculated multiples
        int[] multiples = new int[count];

        // Step 2: Iterate to calculate each multiple and assign it to the array
        for (int i = 0; i < count; i++)
        {
            // Step 3: Fill the array with multiples of the 'start' number
            multiples[i] = start * (i + 1);
        }

        // Step 4: Return the filled array
        return multiples;
    }

    public class ListOperations
    {
        // Function to rotate the elements of a list to the right by a specified number of positions
        public static List<int> RotateListRight(List<int> data, int amount)
        {
            // Step 1: Calculate the effective rotation, accounting for cases where the amount exceeds the list size
            int n = data.Count;
            int effectiveRotation = amount % n;

            // Step 2: Split the list into two parts based on the rotation value
            List<int> part1 = data.GetRange(n - effectiveRotation, effectiveRotation);
            List<int> part2 = data.GetRange(0, n - effectiveRotation);

            // Step 3: Combine the two parts to form the rotated list
            List<int> rotatedList = new List<int>();
            rotatedList.AddRange(part1);
            rotatedList.AddRange(part2);

            // Step 4: Return the new rotated list
            return rotatedList;
        }
    }
}
