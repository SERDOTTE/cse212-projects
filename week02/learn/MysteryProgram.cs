using System;
using System.Collections.Generic;

class D
{
    static void Main()
    {
        int[] d = R(5);
        Array.Sort(d);
        Console.WriteLine("Values: " + string.Join(", ", d));
        int s = C(d);
        Console.WriteLine("Total: " + s);
    }

    static int[] R(int n)
    {
        Random r = new Random();
        int[] d = new int[n];
        for (int i = 0; i < n; i++)
        {
            d[i] = r.Next(1, 7);
        }
        return d;
    }

    static int C(int[] d)
    {
        int s = 0;
        Dictionary<int, int> c = new Dictionary<int, int>();
        foreach (int x in d)
        {
            if (c.ContainsKey(x))
            {
                c[x]++;
            }
            else
            {
                c[x] = 1;
            }
        }
        foreach (int v in c.Values)
        {
            switch (v)
            {
                case 2:
                    s += 10;
                    break;
                case 3:
                    s += 20;
                    break;
                case 4:
                    s += 30;
                    break;
                case 5:
                    s += 40;
                    break;
            }
        }
        return s;
    }
}



// Main()
// ├── R(int n)        --> Generates and returns an array of n random integers between 1 and 6 (simulating dice rolls)
// └── C(int[] d)      --> Processes the frequency of values in the array and calculates the total score

//  Manual Variable Tracking (d = [2, 2, 3, 3, 3])
//  For the input array [2, 2, 3, 3, 3], the variables behave in this exact sequence:

//  1. Sorting (Array.Sort(d)): The array remains [2, 2, 3, 3, 3] (already sorted).

//  2. Dictionary Construction c in C(d): The loop iterates through each array value and maps its occurrences:
//  Key 2: appears 2 times $\rightarrow$ c[2] = 2
//  Key 3: appears 3 times $\rightarrow$ c[3] = 3
//  Final dictionary: { 2: 2, 3: 3 }

//  3. Score Calculation (s): The loop evaluates the frequencies (c.Values = [2, 3]):
//  Frequency 2 (Pair of 2s): hits case 2 $\rightarrow$ s += 10 (Running total: 10)
//  Frequency 3 (Three-of-a-kind of 3s): hits case 3 $\rightarrow$ s += 20 (Final total: 30)

// Based on the execution path for the [2, 2, 3, 3, 3] input, the console output will be:

// Values: 2, 2, 3, 3, 3
// Total: 30