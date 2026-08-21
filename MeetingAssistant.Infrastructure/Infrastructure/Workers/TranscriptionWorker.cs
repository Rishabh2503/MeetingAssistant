using MeetingAssistant.Application.Common;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MeetingAssistant.Infrastructure.Workers;

/// <summary>
/// Background worker responsible for processing captured audio.
/// Whisper integration will be added later.
/// </summary>
public sealed class TranscriptionWorker(
	AudioChannel audioChannel,
	ILogger<TranscriptionWorker> logger)
	: BackgroundService
{
	protected override async Task ExecuteAsync(
	CancellationToken stoppingToken)
	{
		logger.LogInformation("Transcription worker started.");

		await foreach (var frame in audioChannel.Channel.Reader.ReadAllAsync(stoppingToken))
		{
			logger.LogDebug(
				"Received audio frame. Size={Size} Timestamp={Timestamp}",
				frame.Data.Length,
				frame.Timestamp);

			// Whisper transcription will be added here.
		}

		logger.LogInformation("Transcription worker stopped.");
	}
}