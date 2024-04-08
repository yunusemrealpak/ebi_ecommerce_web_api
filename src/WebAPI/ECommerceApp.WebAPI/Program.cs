using ECommerceApp.Persistance;
using ECommerceApp.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationRegistration();
builder.Services.AddPersistanceRegistration(builder.Configuration);
builder.Services.AddControllers();
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
