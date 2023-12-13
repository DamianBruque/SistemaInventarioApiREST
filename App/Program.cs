using Configurations;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddProjectContextSqlServer();  // DBContext
builder.Services.AddRepositories();             // Repositories
builder.Services.AddServices();                 // Services


builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
