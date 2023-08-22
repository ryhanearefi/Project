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

public class SaveProductHandler:IRequestHandler<SaveProductCommand,SaveProductResponse>
{

 private readonly Context _db;
public SaveProductHandler(Context db)
{
  _db = db;
}

    public async Task<SaveProductResponse> Handle(SaveProductCommand request, CancellationToken cancellationToken)
    {
      
       var product =  new Tbl_Product()
       {
          Name = request.Name,
          Description = request.Description,
          Price = request.Price,
          Color = request.Color
       };
       await _db.Tbl_Products.AddAsync(product, cancellationToken);
       await _db.SaveChangesAsync(cancellationToken);
         return new SaveProductResponse { IsSuccess = true };
    }
    
}