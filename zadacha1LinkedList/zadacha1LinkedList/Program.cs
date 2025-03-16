using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            int[] values = { 42, 7, 19, 3, 88, 56 };
            Array.Sort(values);
            foreach (int num in values)
            {
                numbers.AddLast(num);
            }

            Console.WriteLine("Оригинален списък:");
            Console.WriteLine(string.Join(" -> ", numbers) + " -> null");

            SearchNumber(numbers, 19);
            SearchNumber(numbers, 100);

            LinkedList<int> reversedList = ReverseLinkedList(numbers);
            Console.WriteLine("Обърнат списък.");
            Console.WriteLine(string.Join(" -> ", reversedList) + " -> null");

            Console.ReadKey();
        }

        static void SearchNumber(LinkedList<int> list, int num)
        {
            if (list.Contains(num))
            {
                Console.WriteLine($"Числото {num} е в списъка.");
            }
            else
            {
                Console.WriteLine($"Числото {num} не е в списъка.");
            }
        }

        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> reversedList = new LinkedList<int>();
            foreach (int num in list)
            {
                reversedList.AddFirst(num);
            }
            return reversedList;
        }
    }
}
