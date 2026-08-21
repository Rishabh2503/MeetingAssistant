using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MeetingAssistant.Application.Abstractions.Meetings;

namespace MeetingAssistant.UI.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    private readonly IMeetingCoordinator _meetingCoordinator;

    public MainWindowViewModel(IMeetingCoordinator meetingCoordinator)
    {
        _meetingCoordinator = meetingCoordinator;
    }

    [ObservableProperty]
    private string status = "Ready";

    [RelayCommand]
    private async Task StartMeetingAsync()
    {
        await _meetingCoordinator.StartMeetingAsync();

        Status = "Recording...";
    }

    [RelayCommand]
    private async Task StopMeetingAsync()
    {
        await _meetingCoordinator.StopMeetingAsync();

        Status = "Stopped";
    }
}