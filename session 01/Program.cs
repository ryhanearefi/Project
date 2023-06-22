internal class program
{
  private static void Main(string[] args)
  {
    // Read five nouns from the input
    Console.WriteLine("Please enter 5 names:");
    string[] names = new string[5];
    for (int i = 0; i < 5; i++)
    {
      Console.Write("{0}: ", i + 1);
      names[i] = Console.ReadLine();
    }

    Array.Sort(names);
    Console.WriteLine("name moratab shode:");
    foreach (string name in names)
    {
      Console.WriteLine(name);
    }
  }
}
