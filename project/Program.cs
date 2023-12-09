// Дан файл numsTask4.txt с целыми числами. Вычислите сумму элементов, отличающихся от максимального на 1;

using System;
using System.IO;
using System.Linq;
class work_5_4
{
    static void Main()
    {
        string[] use = File.ReadAllLines("numsTask4.txt"); 
        int[] chosenUse = use[0].Split(' ').Select(int.Parse).ToArray(); 
        int max = chosenUse.Max(); 
        int sum = 0; 

        for (int i = 0; i < chosenUse.Length; i++) 
        {
            if (chosenUse[i] == max - 1) 
            {
                sum += chosenUse[i]; 
            }
        }
        Console.WriteLine($"Произведение элементов после минимального числа: {sum}");
    }
}
