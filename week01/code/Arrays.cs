public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static int[] MultiplesOf(int start, int count)
    {
        // Step 1: Initialize an array to hold the multiples
        int[] multiples = new int[count];

        // Step 2: Loop to calculate each multiple
        for (int i = 0; i < count; i++)
        {
            // Step 3: Store each calculated multiple in the array
            multiples[i] = start * (i + 1);
        }

        // Step 4: Return the array
        return multiples;
    }

    public class ListOperations
    {
        // Function to rotate a list to the right by a given amount
        public static List<int> RotateListRight(List<int> data, int amount)
        {
            // Step 1: Calculate effective rotation using modulo
            int n = data.Count;
            int effectiveRotation = amount % n;

            // Step 2: Slice the list into two parts
            List<int> part1 = data.GetRange(n - effectiveRotation, effectiveRotation);
            List<int> part2 = data.GetRange(0, n - effectiveRotation);

            // Step 3: Reconstruct the list by concatenating the two parts
            List<int> rotatedList = new List<int>();
            rotatedList.AddRange(part1);
            rotatedList.AddRange(part2);

            // Step 4: Return the new rotated list
            return rotatedList;
        }
    }
}
