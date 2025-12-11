using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
public class Word
{
    public static void ConvertToDashes(List<string> item)
    {
        HashSet<int> uniqueIndeces = new HashSet<int>();
        Random random1 = new Random();

        for (double i = item.Count; i >= 1; i *= 0.2)
        {
            int number;
            for (int j = 0; j < item.Count; j += 5)
            {
                do
                {
                    number = random1.Next(0, item.Count);
                    uniqueIndeces.Add(number);
                } while (uniqueIndeces.Contains(number) && uniqueIndeces.Count < item.Count);
            }
            foreach (var index in uniqueIndeces)
            {
                item[index] = new string('_', item[index].Length);
                Console.WriteLine(string.Join(' ', item));
                Console.ReadLine();
                Console.Clear();
            }
        }
        for (int j = 0; j < item.Count; j++)
        {
            if(!uniqueIndeces.Contains(j))
            {
            item[j] = new string('_', item[j].Length);
            }
        }

Console.WriteLine(string.Join(' ', item));


    }

}