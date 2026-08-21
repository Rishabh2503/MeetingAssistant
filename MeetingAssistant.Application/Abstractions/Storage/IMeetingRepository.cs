namespace MeetingAssistant.Application.Abstractions.Storage;

public interface IMeetingRepository
{
    Task SaveTranscriptAsync(string transcript);

    Task<string?> GetLatestTranscriptAsync();
}