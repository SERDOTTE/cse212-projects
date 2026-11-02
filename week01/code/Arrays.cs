public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Plan:
        // 1. Create and allocate a new array of type double with the size especified by the 'length' parameter.
        // 2. Craate and repeat loop (for) that goes from 0 to length - 1 and fills each element with the multiple of 'number'.
        // 3. In each iteration of the loop, calculate the multiple of 'number' and assign it to the corresponding element in the array.
        // 4. After the loop, return the array.
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Plan:
        // Step 1: Edge cases (if the list is empty or amount is 0/the total size, nothing changes)
        if (data == null || data.Count <= 1 || amount <= 0)
            return;

        // Adjust 'amount' to ensure it does not exceed the size of the list.
        amount = amount % data.Count;
        if (amount == 0)
            return;

        // Step 2 & 3: Get the slice from the end of the list that will move to the beginning
        int startIndex = data.Count - amount;
        List<int> suffix = data.GetRange(startIndex, amount);

        // Step 4: Remove these elements from the end of the original list
        data.RemoveRange(startIndex, amount);

        // Step 5: Insert the removed elements at the first position (index 0)
        data.InsertRange(0, suffix);
    }
}
