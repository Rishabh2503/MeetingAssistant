using MeetingAssistant.Application.Abstractions.Audio;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Runtime.Versioning;

namespace MeetingAssistant.Infrastructure.Audio;

[SupportedOSPlatform("windows")]
public sealed class WasapiAudioCaptureService : IAudioCaptureService
{
    private WasapiLoopbackCapture? _capture;

    public bool IsRecording => _capture is not null;

    public event EventHandler<byte[]>? AudioChunkCaptured;

    public Task StartAsync(CancellationToken cancellationToken = default)
    {
        if (_capture is not null)
            return Task.CompletedTask;

        _capture = new WasapiLoopbackCapture();

        _capture.DataAvailable += (_, e) =>
        {
            var buffer = new byte[e.BytesRecorded];
            Array.Copy(e.Buffer, buffer, e.BytesRecorded);

            AudioChunkCaptured?.Invoke(this, buffer);
        };

        _capture.RecordingStopped += (_, _) =>
        {
            _capture?.Dispose();
            _capture = null;
        };

        _capture.StartRecording();

        return Task.CompletedTask;
    }

    public Task StopAsync()
    {
        _capture?.StopRecording();

        return Task.CompletedTask;
    }
}