using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08Anonymous_Threat
{
    class StartUp
    {
        static void Main()
        {
            List<string> entryStrings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > entryStrings.Count - 1)
                    {
                        continue;
                    }
                    if (endIndex > entryStrings.Count - 1)
                    {
                        endIndex = entryStrings.Count - 1;
                    }
                    if (endIndex < 0)
                    {
                        continue;
                    }
                    Merge(entryStrings, startIndex, endIndex);
                }
                else
                {
                    int indexOfEntryStrings = int.Parse(tokens[1]);
                    int parts = int.Parse(tokens[2]);

                    string element = entryStrings[indexOfEntryStrings];
                    entryStrings.RemoveAt(indexOfEntryStrings);
                    List<string> newWords = Divide(element, parts);
                    entryStrings.InsertRange(indexOfEntryStrings, newWords);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", entryStrings));
        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();
            int partLenght = element.Length / parts;
            int lastPartLenght = partLenght + element.Length % parts;

            for (int i = 0; i < parts; i++)
            {
                string newWord = element.Substring(i * partLenght, partLenght);
                if (i == parts - 1)
                {
                    newWord = element.Substring(i * partLenght, lastPartLenght);
                }
                newWords.Add(newWord);
            }

            return newWords;
        }

        private static void Merge(List<string> entryStrings, int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                string entryString = entryStrings[i];
                sb.Append(entryString);
            }
            entryStrings.RemoveRange(startIndex, endIndex - startIndex + 1);
            entryStrings.Insert(startIndex, sb.ToString());
        }
    }


}