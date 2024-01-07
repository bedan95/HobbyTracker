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
                PracticeInfo = "7x | 1d",
            },
            new HobbyViewModel()
            {
                Name = "Guitar",
                ColorHex = "00aa00",
                PracticeInfo = "3x | 2d",
            },
            new HobbyViewModel()
            {
                Name = "Programming",
                ColorHex = "0000aa",
                PracticeInfo = "1x | 0d",
            },
            new HobbyViewModel()
            {
                Name = "Workout",
                ColorHex = "ff55aa",
                PracticeInfo = "0x | 0d",
            },
        };

    private void AddButton_Clicked(object sender, EventArgs e)
    {

    }

    private void AnalyticsButton_Clicked(object sender, EventArgs e)
    {

    }

    private void OptionsButton_Clicked(object sender, EventArgs e)
    {

    }
}
