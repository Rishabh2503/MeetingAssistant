namespace MeetingAssistant.Application.Abstractions.Audio;

public interface IAudioCaptureService
{
    bool IsRecording { get; }

    event EventHandler<byte[]>? AudioChunkCaptured;

    Task StartAsync(CancellationToken cancellationToken = default);

    Task StopAsync();
}