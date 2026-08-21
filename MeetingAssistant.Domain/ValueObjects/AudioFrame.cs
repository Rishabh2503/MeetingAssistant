namespace MeetingAssistant.Domain.ValueObjects;

/// <summary>
/// Represents one chunk of captured audio.
/// </summary>
public sealed record AudioFrame(
	ReadOnlyMemory<byte> Data,
	DateTime Timestamp);