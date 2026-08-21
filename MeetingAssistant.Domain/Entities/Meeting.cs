namespace MeetingAssistant.Domain.Entities;

public sealed class Meeting
{
    public Guid Id { get; init; }

    public string Title { get; set; } = string.Empty;

    public DateTime StartedAt { get; init; }

    public DateTime? EndedAt { get; set; }

    public string Transcript { get; set; } = string.Empty;

    public string Summary { get; set; } = string.Empty;
}