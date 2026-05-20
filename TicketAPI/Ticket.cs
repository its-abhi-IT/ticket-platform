namespace TicketApi.Models;

public class Ticket
{
    public int    Id          { get; init; }
    public string Title       { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string Status      { get; init; } = "Open";      // Open | In Progress | Resolved | Closed
    public string Priority    { get; init; } = "Medium";    // Low | Medium | High | Critical
    public string AssignedTo  { get; init; } = "Unassigned";
    public string CreatedBy   { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; init; }
}
