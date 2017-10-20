using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countng_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]
{
    1, 5, 4, 11, 20, 8, 2, 98, 90, 16
};

            int[] sortedArray = CountingSort(arr);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < sortedArray.Length; i++)
                Console.WriteLine(sortedArray[i]);
        }
 
//Output:
//Sorted Values:
//1
//2
//4
//5
//8
//11
//16
//20
//90
//98

public static int[] CountingSort(int[] array)
{
    int[] sortedArray = new int[array.Length];
 
    // find smallest and largest value
    int minVal = array[0];
    int maxVal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minVal) minVal = array[i];
        else if (array[i] > maxVal) maxVal = array[i];
    }
 
    // init array of frequencies
    int[] counts = new int[maxVal - minVal + 1];
 
    // init the frequencies
    for (int i = 0; i < array.Length; i++)
    {
        counts[array[i] - minVal]++;
    }
 
    // recalculate
    counts[0]--;
    for (int i = 1; i < counts.Length; i++)
    {
        counts[i] = counts[i] + counts[i - 1];
    }
 
    // Sort the array
    for (int i = array.Length - 1; i >= 0; i--)
    {
        sortedArray[counts[array[i] - minVal]--] = array[i];
    }
 
    return sortedArray;
}
        }
    }
