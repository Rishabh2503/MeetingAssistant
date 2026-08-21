using MeetingAssistant.Application.Abstractions.Audio;
using MeetingAssistant.Application.Abstractions.Meetings;

namespace MeetingAssistant.Infrastructure.Services;

public sealed class MeetingCoordinator(
    IAudioCaptureService audioCaptureService)
    : IMeetingCoordinator
{
    public bool IsMeetingRunning => audioCaptureService.IsRecording;

    public async Task StartMeetingAsync(
        CancellationToken cancellationToken = default)
    {
        if (IsMeetingRunning)
            return;

        await audioCaptureService.StartAsync(cancellationToken);
    }

    public async Task StopMeetingAsync()
    {
        if (!IsMeetingRunning)
            return;

        await audioCaptureService.StopAsync();
    }
}