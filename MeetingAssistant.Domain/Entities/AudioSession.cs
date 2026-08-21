namespace MeetingAssistant.Domain.Entities;

public sealed class AudioSession
{
    public Guid Id { get; } = Guid.NewGuid();

    public DateTime StartedAt { get; } = DateTime.UtcNow;

    public DateTime? EndedAt { get; private set; }

    public void Stop()
    {
        EndedAt = DateTime.UtcNow;
    }
}