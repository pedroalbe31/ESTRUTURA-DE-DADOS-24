using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        Page firstPage = new Page() { Content = "bacalhau" };
        Page secondPage = new Page() { Content = "abacaxi" };
        Page thirdPage = new Page() { Content = "relógio" };
        Page fourthPage = new Page() { Content = "chuveiro" };
        Page fifthPage = new Page() { Content = "mesa" };
        Page sixthPage = new Page() { Content = "notebook" };

        LinkedList<Page> pageList = new LinkedList<Page>();
        pageList.AddLast(secondPage);
        LinkedListNode<Page> nodeAtFourth = pageList.AddLast(fourthPage);
        pageList.AddLast(sixthPage);
        pageList.AddFirst(firstPage);
        pageList.AddBefore(nodeAtFourth, thirdPage);
        pageList.AddAfter(nodeAtFourth, fifthPage);

        LinkedListNode<Page> currentPage = pageList.First;
        int pageNumber = 1;

        while (currentPage != null)
        {
            Console.Clear();
            string pageNumberString = $"- {pageNumber} -";
            int leadingSpaces = (90 - pageNumberString.Length) / 2;

            Console.WriteLine(pageNumberString.PadLeft(leadingSpaces + pageNumberString.Length));
            Console.WriteLine();

            string content = currentPage.Value.Content;
            for (int i = 0; i < content.Length; i += 90)
            {
                string line = content.Substring(i);
                line = line.Length > 90 ? line.Substring(0, 90) : line;
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("Testando");

            Console.WriteLine();
            Console.Write(currentPage.Previous != null
                ? "< PREVIOUS [P]" : GetSpaces(14));
            Console.Write(currentPage.Next != null
                ? "[N] NEXT >".PadLeft(76) : string.Empty);
            Console.WriteLine();

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.N:
                    if (currentPage.Next != null)
                    {
                        currentPage = currentPage.Next;
                        pageNumber++;
                    }
                    break;
                case ConsoleKey.P:
                    if (currentPage.Previous != null)
                    {
                        currentPage = currentPage.Previous;
                        pageNumber--;
                    }
                    break;
                default:
                    return;
            }
        }
    }

    static string GetSpaces(int number)
    {
        string result = string.Empty;
        for (int i = 0; i < number; i++)
        {
            result += " ";
        }
        return result;
    }
}

class Page
{
    public string Content { get; set; }
}