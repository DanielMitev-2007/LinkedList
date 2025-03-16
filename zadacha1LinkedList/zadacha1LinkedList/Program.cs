using System;
using System.Collections.Generic;

class Program
{
    static void Main()
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

        Console.WriteLine("\nОбърнат списък:");
        Console.WriteLine(string.Join(" -> ", reversedList) + " -> null");

        RemoveNumber(numbers, 42);
        Console.WriteLine("\nСписък след премахване на 42:");
        Console.WriteLine(string.Join(" -> ", numbers) + " -> null");

        LinkedList<int> list1 = new LinkedList<int>(new int[] { 1, 5, 10 });
        LinkedList<int> list2 = new LinkedList<int>(new int[] { 2, 6, 12 });
        LinkedList<int> mergedList = MergeSortedLists(list1, list2);

        Console.WriteLine("\nОбединен списък:");
        Console.WriteLine(string.Join(" -> ", mergedList) + " -> null");

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

    static void RemoveNumber(LinkedList<int> list, int num)
    {
        list.Remove(num);
    }

    static LinkedList<int> MergeSortedLists(LinkedList<int> list1, LinkedList<int> list2)
    {
        LinkedList<int> mergedList = new LinkedList<int>();
        LinkedListNode<int> node1 = list1.First;
        LinkedListNode<int> node2 = list2.First;

        while (node1 != null && node2 != null)
        {
            if (node1.Value < node2.Value)
            {
                mergedList.AddLast(node1.Value);
                node1 = node1.Next;
            }
            else
            {
                mergedList.AddLast(node2.Value);
                node2 = node2.Next;
            }
        }

        while (node1 != null)
        {
            mergedList.AddLast(node1.Value);
            node1 = node1.Next;
        }

        while (node2 != null)
        {
            mergedList.AddLast(node2.Value);
            node2 = node2.Next;
        }

        return mergedList;
    }
}
