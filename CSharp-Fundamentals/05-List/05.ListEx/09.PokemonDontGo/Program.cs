using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();

            int totalSum = 0;

            // Докато списъкът не е празен
            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedValue;

                // Ако индексът е по-малък от 0
                if (index < 0)
                {
                    removedValue = pokemons[0];
                    totalSum += removedValue;
                    // Копираме последния елемент на мястото на първия
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                // Ако индексът е по-голям от последния валиден
                else if (index >= pokemons.Count)
                {
                    removedValue = pokemons[pokemons.Count - 1];
                    totalSum += removedValue;
                    // Копираме първия елемент на мястото на последния
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                // В противен случай – нормално премахване
                else
                {
                    removedValue = pokemons[index];
                    totalSum += removedValue;
                    pokemons.RemoveAt(index);
                }

                // Обработваме останалите елементи
                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= removedValue)
                    {
                        pokemons[i] += removedValue;
                    }
                    else
                    {
                        pokemons[i] -= removedValue;
                    }
                }
            }

            // Печатаме общата стойност на хванатите покемони
            Console.WriteLine(totalSum);

        }
    }
}
