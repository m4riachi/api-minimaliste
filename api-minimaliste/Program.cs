var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/customers", () =>
{
    var customers = new[]
    {
        new Customer { Id = 1, Name = "John Doe", Email = "john.doe@gmail.com", PhoneNumber = "1234567890" },
        new Customer { Id = 2, Name = "Jane Doe", Email = "jane.doe@gmail.com", PhoneNumber = "1234567890" }
    };
    
    return Results.Ok(customers);
});

app.Run();

// create class client with properties id , name, email and phoneNumber
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
}