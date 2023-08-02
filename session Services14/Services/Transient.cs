public class Transient : ITransient
{
  private readonly Guid _guid;

  public Transient ()
  {
    _guid = Guid.NewGuid();
  }





  public string GetGuid()
  {
    return _guid.ToString();
  }
}