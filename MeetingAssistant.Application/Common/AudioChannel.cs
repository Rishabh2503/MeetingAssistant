using System.Threading.Channels;
using MeetingAssistant.Domain.ValueObjects;

namespace MeetingAssistant.Application.Common;

/// <summary>
/// Shared audio queue between capture service and transcription worker.
/// </summary>
public sealed class AudioChannel
{
    public Channel<AudioFrame> Channel { get; }
        = System.Threading.Channels.Channel.CreateUnbounded<AudioFrame>();
}