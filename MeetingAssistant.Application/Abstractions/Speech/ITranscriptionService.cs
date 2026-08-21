namespace MeetingAssistant.Application.Abstractions.Speech;

public interface ITranscriptionService
{
	Task<string> TranscribeAsync(
		byte[] audio,
		CancellationToken cancellationToken = default);
}