using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] bestSequence = new int[length];
            int bestSampleIndex = 0;
            int bestLongestOnes = 0;
            int bestStartingIndex = length;
            int bestSum = 0;
            int sampleIndex = 0;

            string input;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                // Split by one or more '!' characters and parse to integers
                int[] sequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sampleIndex++;
                int currentSum = sequence.Sum();

                // Find longest subsequence of 1s and its start index
                int currentLongest = 0;
                int currentBestStart = 0;
                int tempCount = 0;
                int tempStart = 0;

                for (int i = 0; i < length; i++)
                {
                    if (sequence[i] == 1)
                    {
                        if (tempCount == 0)
                            tempStart = i;

                        tempCount++;

                        if (tempCount > currentLongest)
                        {
                            currentLongest = tempCount;
                            currentBestStart = tempStart;
                        }
                    }
                    else
                    {
                        tempCount = 0;
                    }
                }

                // Determine if this is the best sample
                bool isBetter = false;

                if (currentLongest > bestLongestOnes)
                    isBetter = true;
                else if (currentLongest == bestLongestOnes)
                {
                    if (currentBestStart < bestStartingIndex)
                        isBetter = true;
                    else if (currentBestStart == bestStartingIndex)
                    {
                        if (currentSum > bestSum)
                            isBetter = true;
                    }
                }

                if (isBetter)
                {
                    bestSequence = sequence;
                    bestSampleIndex = sampleIndex;
                    bestLongestOnes = currentLongest;
                    bestStartingIndex = currentBestStart;
                    bestSum = currentSum;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
