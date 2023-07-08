internal class Program
{
  private static void Main(string[] args)
  {
    string[] Student = new string[3];
    int[] Nomre_Student = new int[3];


    for (int i = 0; i < Student.Length; i++)
    {
      Console.Write("Plz.Enter A Fname  Student : ");
      Student[i] = System.Console.ReadLine();

    }



    for (int j = 0; j < Nomre_Student.Length; j++)
    {
      Console.Write("Plz.Enter A Fname  Student : ");
      Nomre_Student[j] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine(" ** Show Fname & Mark Student ***");
    for (int i = 0; i < Nomre_Student.Length; i++)
    {
      Console.WriteLine("Fname: " + Nomre_Student[i] + " -----> " + " Mark : " + Nomre_Student[i]);
    }
  }
}