using System;

using System.Linq;

class Program
{
    static void Main()
    {
        int[] nums = {1,2,3,4,5};

        var result =
        nums.Where(n => n > 2);

        foreach(int n in result)
        {
            Console.WriteLine(n);
        }
    }
}
    