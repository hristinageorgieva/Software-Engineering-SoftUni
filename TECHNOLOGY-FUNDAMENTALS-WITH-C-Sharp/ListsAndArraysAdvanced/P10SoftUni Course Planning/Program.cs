using System;
using System.Collections.Generic;
using System.Linq;

namespace P10SoftUniCoursePanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string commands = Console.ReadLine();
            while (commands != "course start")
            {
                string[] actions = commands.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (actions[0] == "Add")
                {
                    Add(lessons, actions);
                }
                if (actions[0] == "Insert")
                {
                    Insert(lessons, actions);
                }
                if (actions[0] == "Remove")
                {
                    Remove(lessons, actions);
                }
                if (actions[0] == "Swap")
                {
                    Swap(lessons, actions);
                }
                if (actions[0] == "Exercise")
                {
                    Exercise(lessons, actions);
                }
                commands = Console.ReadLine();
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }

        static void Swap(List<string> lessons, string[] actions)
        {
            bool firstLesson = false;
            bool secondLesson = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == actions[1])
                {
                    firstLesson = true;
                }
                if (lessons[i] == actions[2])
                {
                    secondLesson = true;
                }
            }
            if (firstLesson && secondLesson)
            {

                string firstOfLesson = actions[1];
                string secondOfLesson = actions[2];
                int indexOfFirst = lessons.IndexOf(firstOfLesson);
                int indexOfSecond = lessons.IndexOf(secondOfLesson);
                if (indexOfFirst != -1 && indexOfSecond != -1)
                {
                    lessons[indexOfFirst] = secondOfLesson;
                    lessons[indexOfSecond] = firstOfLesson;
                    if (lessons.Contains($"{firstOfLesson}-Exercise"))
                    {
                        bool exerciseExist = false;
                        for (int i = 0; i < lessons.Count; i++)
                        {

                            if (lessons[i] == $"{firstOfLesson}-Exercise")
                            {
                                exerciseExist = true;

                            }
                        }
                        if (exerciseExist && indexOfFirst + 1 < lessons.Count)
                        {
                            lessons.RemoveAt(indexOfFirst + 1);
                            indexOfFirst = lessons.IndexOf(firstOfLesson);
                            lessons.Insert(indexOfFirst + 1, $"{firstOfLesson}-Exercise");
                        }

                    }
                    if (lessons.Contains($"{secondOfLesson}-Exercise"))
                    {
                        bool exerciseExist = false;
                        for (int i = 0; i < lessons.Count; i++)
                        {
                            if (lessons[i] == $"{secondOfLesson}-Exercise")
                            {
                                exerciseExist = true;

                            }
                        }
                        if (exerciseExist && indexOfSecond + 1 < lessons.Count)
                        {
                            lessons.RemoveAt(indexOfSecond + 1);
                            indexOfSecond = lessons.IndexOf(secondOfLesson);
                            lessons.Insert(indexOfSecond + 1, $"{secondOfLesson}-Exercise");
                        }
                    }



                }
            }
        }

        static void Exercise(List<string> lessons, string[] actions)
        {
            bool doesItExist = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == $"{actions[1]}-Exercise")
                {
                    doesItExist = true;
                }
            }
            if (doesItExist == false)
            {
                if (lessons.Contains(actions[1]))
                {
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == actions[1])
                        {
                            lessons.Insert(i + 1, $"{actions[1]}-Exercise");
                        }
                    }
                }
                else
                {
                    lessons.Add(actions[1]);
                    lessons.Add($"{actions[1]}-Exercise");
                }
            }


        }

        static void Remove(List<string> lessons, string[] actions)
        {
            bool doesItExist = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == actions[1])
                {
                    doesItExist = true;
                }
            }
            if (doesItExist)
            {
                lessons.Remove(actions[1]);
                if (lessons.Contains($"{actions[1]}-Exercise"))
                {
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == $"{actions[1]}-Exercise")
                        {
                            lessons.Remove(lessons[i]);
                        }
                    }
                }
            }

        }

        static void Insert(List<string> lessons, string[] actions)
        {
            bool doesItExist = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == actions[1])
                {
                    doesItExist = true;
                }
            }
            if (doesItExist == false)
            {
                if (int.Parse(actions[2]) < lessons.Count && int.Parse(actions[2]) >= 0)
                {
                    lessons.Insert(int.Parse(actions[2]), actions[1]);
                }
            }
        }

        static void Add(List<string> lessons, string[] actions)
        {
            bool doesItExist = false;
            for (int i = 0; i < lessons.Count; i++)
            {
                if (lessons[i] == actions[1])
                {
                    doesItExist = true;
                }
            }
            if (doesItExist == false)
            {
                lessons.Add(actions[1]);
            }


        }
    }
}
