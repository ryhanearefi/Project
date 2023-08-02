public class Scoped : IScoped
{
  private readonly Guid _guid;

  public Scoped ()
  {
    _guid = Guid.NewGuid();

  }



  public string GetGuid()
  {
    return _guid.ToString();
  }
}