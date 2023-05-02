using System;

class GFG
{

    // assumes that n is a positive integer
    static bool isMultipleof5(int n)
    {
        while (n > 0)
            n = n - 5;

        if (n == 0)
            return true;

        return false;
    }

    // Driver Code
    public static void Main()
    {
        int n =0;
        if (isMultipleof5(n) == true)
            Console.Write(n + " is multiple of 5\n");
        else
            Console.Write(n + " is not a multiple of 5\n");
    }
}