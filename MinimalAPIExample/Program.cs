using Microsoft.EntityFrameworkCore;
using MinimalAPIExample;
using MinimalAPIExample.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<InMemoryDbContext>(options =>
    options.UseInMemoryDatabase("Herois"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.MapGet("/herois", async (InMemoryDbContext dbContext, CancellationToken cancelToken) =>
    await dbContext.Herois.ToListAsync(cancellationToken: cancelToken));

app.MapGet("/herois/{id}", async (int id, InMemoryDbContext dbContext, CancellationToken cancelToken) =>
    await dbContext.Herois.FirstOrDefaultAsync(x => x.Id == id, cancellationToken: cancelToken));

app.MapPost("/herois", async (Heroi heroi, InMemoryDbContext dbContext, CancellationToken cancelToken) =>
{
    await dbContext.Herois.AddAsync(heroi, cancellationToken: cancelToken);
    await dbContext.SaveChangesAsync(cancellationToken: cancelToken);
    return heroi;
});

app.MapPut("/herois/{id}", async (int id, Heroi heroi, InMemoryDbContext dbContext, CancellationToken cancelToken) =>
{
    dbContext.Entry(heroi).State = EntityState.Modified;
    await dbContext.SaveChangesAsync(cancellationToken: cancelToken);
    return heroi;
});

app.MapDelete("/herois/{id}", async (int id, InMemoryDbContext dbContext, CancellationToken cancelToken) =>
{
    var cliente = await dbContext.Herois.FirstOrDefaultAsync(x => x.Id == id, cancellationToken: cancelToken);

    if (cliente != null)
    {
        dbContext.Herois.Remove(cliente);
        await dbContext.SaveChangesAsync(cancellationToken: cancelToken);
    }

    return;
});

app.UseSwaggerUI();

app.UseMockDados();

app.Run();
