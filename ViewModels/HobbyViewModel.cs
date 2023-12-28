namespace HobbyTracker.ViewModels;

public class HobbyViewModel
{
    public string Name { get; set; }
    public string ColorHex { get; set; }
    public int RecentSessionsCount { get; set; }
    public int DaysSinceLastSession { get; set; }
}