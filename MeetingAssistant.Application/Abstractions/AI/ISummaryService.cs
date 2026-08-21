namespace MeetingAssistant.Application.Abstractions.AI;

public interface ISummaryService
{
    Task<string> GenerateSummaryAsync(
        string transcript,
        CancellationToken cancellationToken = default);
}