internal class Program
{
  private static void Main(string[] args)
  {

    int star = 10;
    for (int i = 1; i <= 10; i++)
    {
      for (int k = 1; k <= star; k = k + 1)
      {
        System.Console.Write(" ");
      }

      for (int j = 1; j <= i; j++)
      {
        System.Console.Write("* ");
      }
      System.Console.WriteLine();
      star--;
    }
    for (int i = 10; i >= 1; i--)
    {
      for (int k = 1; k <= star; k = k + 1)
      {

        System.Console.Write(" ");
      }

      for (int j = 1; j <= i; j++)
      {
        System.Console.Write("* ");
      }

      System.Console.WriteLine();
      star++;
    }

  }
}