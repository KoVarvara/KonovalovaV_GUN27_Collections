using System;
using System.Collections.Generic;

namespace HomeWork
{
    internal class Program
    {

        private class ListTask
        {
            private readonly List<string> _listOfStrings = new List<string>() { "First string", "Second string", "Third string", "Fourth string" };

            public void TaskLoop()
            {
                var exitWord = "-exit";
                Console.WriteLine("Чтобы остановить программу, введите " + exitWord);

                while (true)
                {
                    Console.WriteLine("Введите строку");

                    var input = Console.ReadLine();
                    if (input == exitWord)
                    {
                        break;
                    }
                    _listOfStrings.Add(input);
                    foreach (var line in _listOfStrings)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Введите еще одну строку");
                    var input2 = Console.ReadLine();
                    if (input2 == exitWord)
                    {
                        break;
                    }
                    var middleList = _listOfStrings.Count / 2;
                    _listOfStrings.Insert(middleList, input2);


                    foreach (var line in _listOfStrings)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }

        private class DictionaryTask
        {
            private Dictionary<string, int> _dictionaryOfStudents = new Dictionary<string, int>();
            public void TaskLoop()
            {
                var exitWord = "-exit";
                Console.WriteLine("Чтобы остановить программу, введите " + exitWord);
                while (true)
                {
                    Console.WriteLine("Введите имя студента");
                    var studentName = Console.ReadLine();
                    if (studentName == exitWord)
                    {
                        break;
                    } 
                    Console.WriteLine("Введите оценку студента");
                    var studentMark = Console.ReadLine();
                    if (studentMark == exitWord)
                    {
                        break;
                    }
                    if (int.TryParse(studentMark, out int numberMark) && numberMark > 1 && numberMark < 6)
                    {
                        _dictionaryOfStudents.Add(studentName, numberMark);
                    }
                    else
                    {
                        Console.WriteLine("Некорректно введена оценка");
                    }
                    Console.WriteLine("Введите имя студента из списка");
                    var inputName = Console.ReadLine();
                    if (inputName == exitWord)
                    {
                        break;
                    }
                    if (_dictionaryOfStudents.TryGetValue(inputName, out int mark))
                    {
                        Console.Write("Оценка: " + mark);
                        Console.ReadLine();
                    }
                
                    else
                    {
                        Console.WriteLine("Студента с таким именем не существует");
                    }
                }
            }
        }

        private class LinkedListTask
        { 
            public void TaskLoop()
            {
                var exitWord = "-exit";
                Console.WriteLine("Чтобы остановить программу, введите " + exitWord);
                var nodeList = new List<string>();

                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Введите элемент ");
                    var input = Console.ReadLine();
                    if (input == exitWord)
                    {
                        break;
                    }
                    nodeList.Add(input);          
                }
                var linkedList = new LinkedList<string>(nodeList);

                foreach (var node in linkedList)
                {
                    Console.WriteLine(node);
                }

                var node1 = linkedList.Last;

                for (int i = linkedList.Count; i > 0; i--)
                {
                    Console.WriteLine(node1.Value);
                    node1 = node1.Previous;
                }
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1,2 or 3 to check task 1,2 or 3");
            int.TryParse(Console.ReadLine(), out int task);

            switch (task)
            {
                case 1:
                    CheckTaskFirst(); 
                    break;

                case 2:
                    CheckTaskSecond();
                    break;

                case 3:
                    CheckTaskThird();
                    break;

                default:
                    Console.WriteLine("Input is wrong");
                    break;
            }
        }

        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }

        private static void CheckTaskSecond()
        {
            var dictionaryTask = new DictionaryTask();
            dictionaryTask.TaskLoop();
        }

        private static void CheckTaskThird()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}
