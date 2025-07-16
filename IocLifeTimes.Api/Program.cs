using IocLifeTimes.Api.Interfaces;
using IocLifeTimes.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Registro para injetar Guid no construtor
builder.Services.AddSingleton<ISingletonGuidService, SingletonService>(provider =>
{
    return new SingletonService(Guid.NewGuid());
});

builder.Services.AddScoped<IScopedGuidService, ScopedService>(provider =>
{
    return new ScopedService(Guid.NewGuid());
});

builder.Services.AddTransient<ITransientGuidService, TransientService>(provider =>
{
    return new TransientService(Guid.NewGuid());
});

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
