using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MeetingAssistant.UI.Configuration;
using MeetingAssistant.UI.ViewModels;

namespace MeetingAssistant.UI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentation(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<AppSettings>(
            configuration.GetSection(AppSettings.SectionName));

        services.AddSingleton(sp =>
            sp.GetRequiredService<IOptions<AppSettings>>().Value);

        services.AddSingleton<MainWindowViewModel>();

        services.AddSingleton<MainWindow>();

        return services;
    }
}