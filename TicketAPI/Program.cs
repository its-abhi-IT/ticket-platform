using TicketApi.Models;
using TicketApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TicketRepository>();

var app = builder.Build();

// ── GET /api/health ────────────────────────────────────────────────────────────
app.MapGet("/api/health", () =>
    Results.Ok(new
    {
        status    = "healthy",
        version   = "1.0.0",
        timestamp = DateTime.UtcNow
    }))
    .WithName("GetHealth");

// ── GET /api/tickets ───────────────────────────────────────────────────────────
app.MapGet("/api/tickets", (TicketRepository repo) =>
    Results.Ok(repo.GetAll()))
    .WithName("GetTickets");

// ── GET /api/tickets/{id} ──────────────────────────────────────────────────────
app.MapGet("/api/tickets/{id:int}", (int id, TicketRepository repo) =>
{
    var ticket = repo.GetById(id);
    return ticket is not null
        ? Results.Ok(ticket)
        : Results.NotFound(new { message = $"Ticket {id} not found." });
})
.WithName("GetTicketById");

app.Run();
