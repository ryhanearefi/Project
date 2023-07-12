internal class Program
{
  private static void Main(string[] args)
  {
    string[] students = new string[3];
    int[] studentScores = new int[3];

    for (int i = 0; i < students.Length; i++)
    {
      Console.Write("Please enter the first name of the student: ");
      students[i] = Console.ReadLine();
    }

    for (int j = 0; j < studentScores.Length; j++)
    {
      Console.Write("Please enter the score of student: ");
      studentScores[j] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("***** Showing Student First Names & Scores *****");
    for (int i = 0; i < studentScores.Length; i++)
    {
      Console.WriteLine("First Name: " + students[i] + " -----> Score: " + studentScores[i]);
    }
  }
}
