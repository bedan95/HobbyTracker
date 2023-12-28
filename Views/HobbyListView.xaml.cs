using HobbyTracker.Entities;
using HobbyTracker.ViewModels;
using System.Xml.Linq;

namespace HobbyTracker.Views;

public partial class HobbyListView : ContentPage
{
    public HobbyListView()
    {
        InitializeComponent();
        listView.ItemsSource = FakeHobbyViewModel;
    }

    public List<HobbyViewModel> FakeHobbyViewModel
        => new List<HobbyViewModel>()
        {
            new HobbyViewModel()
            {
                Name = "Drawing",
                ColorHex = "aa0000",
                RecentSessionsCount = 7,
                DaysSinceLastSession = 1,
            },
            new HobbyViewModel()
            {
                Name = "Guitar",
                ColorHex = "00aa00",
                RecentSessionsCount = 3,
                DaysSinceLastSession = 2,
            },
            new HobbyViewModel()
            {
                Name = "Programming",
                ColorHex = "0000aa",
                RecentSessionsCount = 1,
                DaysSinceLastSession = 0,
            },
        };
}
