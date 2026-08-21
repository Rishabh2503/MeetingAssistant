using Microsoft.Extensions.DependencyInjection;
using MeetingAssistant.UI.ViewModels;

namespace MeetingAssistant.UI.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddSingleton<MainWindowViewModel>();

        services.AddSingleton<MainWindow>();

        return services;
    }
}