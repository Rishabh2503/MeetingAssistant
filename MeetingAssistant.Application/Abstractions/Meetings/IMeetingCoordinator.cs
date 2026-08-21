namespace MeetingAssistant.Application.Abstractions.Meetings;

/// <summary>
/// Controls the lifecycle of a meeting session.
/// </summary>
public interface IMeetingCoordinator
{
    bool IsMeetingRunning { get; }

    Task StartMeetingAsync(CancellationToken cancellationToken = default);

    Task StopMeetingAsync();
}