public class Singletone : ISingletone
{
  private readonly Guid _guid;

  public Singletone ()
  {
    _guid = Guid.NewGuid();
  }





  public string GetGuid()
  {
    return _guid.ToString();
  }
}