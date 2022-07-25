using QATask.Services.Services;
using QATask.Services.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(
    options => options.AddPolicy("AllowCors",
         builder =>
         {
             builder.AllowAnyOrigin()
                     .WithMethods("GET", "PUT", "POST", "DELETE")
                     .AllowAnyHeader();
         })
 );
builder.Services.AddScoped<IInfoService, InfoService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllowCors");
app.MapControllers();

app.Run();
