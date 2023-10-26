using LinkedLists;

Page pageFirst = new Page() {Content = "Atualmente...", PageNumber = 1};
Page pageSecond = new Page() {Content = "Aplicação...", PageNumber = 2};
Page pageThird  = new Page() {Content = "Muito de...", PageNumber = 3};
Page pageFourth = new Page() {Content = "Você sabia...", PageNumber = 4};
Page pageFifth = new Page() {Content = "Enquanto...", PageNumber = 5};
Page pageSixth = new Page() {Content = "Você poderia..." , PageNumber = 6};
Page pageSeventh = new Page() {Content = "Era uma vez...", PageNumber = 7};

LinkedList<Page> pages = new LinkedList<Page>();
pages.AddLast(pageSecond);
LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
pages.AddLast(pageSixth);
pages.AddFirst(pageFirst);

pages.AddBefore(nodePageFourth, pageThird);
pages.AddAfter(nodePageFourth, pageFifth);

LinkedListNode<Page> current = pages.First;
int number = 1;
while (current != null)
{
    Console.Clear();
    string numberString = $"- {number} -";
    int leadingSpaces = (90 - numberString.Length) / 2;
    Console.WriteLine(numberString.PadLeft(leadingSpaces
        + numberString.Length));
    Console.WriteLine();

    string content = current.Value.Content;
    for (int i = 0; i < content.Length; i += 90)
    {
        string line = content.Substring(i);
        line = line.Length > 90 ? line.Substring(0, 90) : line;
        Console.WriteLine(line);
    }

    Console.WriteLine();
    Console.WriteLine($"Quote from Windows Application Development Cookbook by MarcinJamro,"{Environment.NewLine}"published by Packt Publishingin 2016.");

    Console.WriteLine();
    Console.WriteLine(current.Previous != null
        ? "< PREVIUS [P]" : GetSpaces (14));
    Console.WriteLine(current.Next != null
        ? "[N] NEXT >".PadLeft(76) : string.Empty);
    Console.WriteLine();

    switch ConsoleKey.N:
        if (current.Next != null)
        {
            current = current.Next;
            number++;
        }
        break;
    case ConsoleKey.P:
        if (current.Previous != null)
        {
            current = current.Previous;
            number--;
        }
        break;
    default:
        return;

    
}