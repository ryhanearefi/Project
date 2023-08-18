using MediatR;

//class input
public class SaveProductCommand:IRequest<SaveProductResponse>
{
  public string Name { get; set; }
  public string Description { get; set; }
  public decimal Price { get; set; }
  public string Color { get; set; }
}



public class SaveProductResponse:IRequest
{
  public bool IsSuccess { get; set; }
  
  
}

public class SaveProductHandler : IRequestHandler<SaveProductCommand, SaveProductResponse>
{
    public SaveProductResponse Handle(SaveProductCommand request, CancellationToken cancellationToken)
    {
        return new SaveProductResponse { IsSuccess = true };
    }
}