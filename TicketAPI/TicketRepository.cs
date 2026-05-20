using TicketApi.Models;

namespace TicketApi.Data;

public class TicketRepository
{
    private readonly List<Ticket> _tickets = new()
    {
        new Ticket
        {
            Id          = 1,
            Title       = "Login page crashes on Safari",
            Description = "Users on Safari 17+ report a blank screen after submitting credentials. Affects ~12% of users.",
            Status      = "In Progress",
            Priority    = "Critical",
            AssignedTo  = "alice@example.com",
            CreatedBy   = "bob@example.com",
            CreatedAt   = new DateTime(2025, 5, 1, 9, 0, 0, DateTimeKind.Utc),
            UpdatedAt   = new DateTime(2025, 5, 10, 14, 30, 0, DateTimeKind.Utc)
        },
        new Ticket
        {
            Id          = 2,
            Title       = "Add dark mode support",
            Description = "Multiple customers have requested a dark theme. Should follow system preference by default.",
            Status      = "Open",
            Priority    = "Medium",
            AssignedTo  = "Unassigned",
            CreatedBy   = "carol@example.com",
            CreatedAt   = new DateTime(2025, 5, 3, 11, 15, 0, DateTimeKind.Utc)
        },
        new Ticket
        {
            Id          = 3,
            Title       = "CSV export includes duplicate rows",
            Description = "Exporting filtered results from the reports page produces duplicate rows for entries with multiple tags.",
            Status      = "Open",
            Priority    = "High",
            AssignedTo  = "dave@example.com",
            CreatedBy   = "eve@example.com",
            CreatedAt   = new DateTime(2025, 5, 5, 8, 45, 0, DateTimeKind.Utc)
        },
        new Ticket
        {
            Id          = 4,
            Title       = "Upgrade .NET runtime to 9.0",
            Description = "Planned upgrade to take advantage of performance improvements and new language features.",
            Status      = "Open",
            Priority    = "Low",
            AssignedTo  = "alice@example.com",
            CreatedBy   = "alice@example.com",
            CreatedAt   = new DateTime(2025, 5, 6, 16, 0, 0, DateTimeKind.Utc)
        },
        new Ticket
        {
            Id          = 5,
            Title       = "Password reset email not delivered",
            Description = "SMTP relay config changed after infra migration; reset emails are silently dropped.",
            Status      = "Resolved",
            Priority    = "Critical",
            AssignedTo  = "dave@example.com",
            CreatedBy   = "frank@example.com",
            CreatedAt   = new DateTime(2025, 4, 28, 7, 30, 0, DateTimeKind.Utc),
            UpdatedAt   = new DateTime(2025, 5, 2, 10, 0, 0, DateTimeKind.Utc)
        },
        new Ticket
        {
            Id          = 6,
            Title       = "Pagination breaks at exactly 100 items",
            Description = "When a page contains exactly 100 records the 'Next' button is hidden even though more records exist.",
            Status      = "Open",
            Priority    = "High",
            AssignedTo  = "carol@example.com",
            CreatedBy   = "bob@example.com",
            CreatedAt   = new DateTime(2025, 5, 8, 13, 0, 0, DateTimeKind.Utc)
        },
        new Ticket
        {
            Id          = 7,
            Title       = "Improve onboarding tooltip copy",
            Description = "First-time users find the current tooltips confusing. UX team has submitted revised copy.",
            Status      = "Closed",
            Priority    = "Low",
            AssignedTo  = "eve@example.com",
            CreatedBy   = "carol@example.com",
            CreatedAt   = new DateTime(2025, 4, 20, 9, 0, 0, DateTimeKind.Utc),
            UpdatedAt   = new DateTime(2025, 4, 30, 17, 0, 0, DateTimeKind.Utc)
        }
    };

    public IReadOnlyList<Ticket> GetAll() => _tickets.AsReadOnly();

    public Ticket? GetById(int id) => _tickets.FirstOrDefault(t => t.Id == id);
}
