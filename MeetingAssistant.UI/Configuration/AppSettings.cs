namespace MeetingAssistant.UI.Configuration;

public sealed class AppSettings
{
	public const string SectionName = "Application";

	public string Name { get; init; } = string.Empty;

	public string Version { get; init; } = string.Empty;
}