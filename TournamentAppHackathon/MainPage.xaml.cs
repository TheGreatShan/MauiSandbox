using ABI.Microsoft.UI.Xaml.Controls.Primitives;
using CommunityToolkit.Maui.Views;
using TournamentAppHackathon.Tournaments;
using TournamentAppHackathon.ViewModels;

namespace TournamentAppHackathon;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        this.ShowPopup(new CreationPopup());
    }

    public List<Tournament> GetTournaments()
    {
        return TournamentsRepo.Get();
    }
}