using MeetingAssistant.Application.Abstractions.Audio;
using MeetingAssistant.Infrastructure.Audio;
using MeetingAssistant.Infrastructure.Workers;
using Microsoft.Extensions.DependencyInjection;
using MeetingAssistant.Application.Common;
using MeetingAssistant.Application.Abstractions.Meetings;
using MeetingAssistant.Infrastructure.Services;

namespace MeetingAssistant.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddSingleton<AudioChannel>();
        // Services
        services.AddSingleton<IAudioCaptureService, WasapiAudioCaptureService>();
        services.AddSingleton<IMeetingCoordinator, MeetingCoordinator>();

        // Background Workers
        services.AddHostedService<TranscriptionWorker>();

        return services;
    }
}