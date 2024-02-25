using System.ComponentModel;
using System.Runtime.CompilerServices;
using TournamentAppHackathon.Tournaments;

namespace TournamentAppHackathon.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private List<Tournament> _tournaments;

    public List<Tournament> Tournaments
    {
        get => _tournaments;
        set
        {
            _tournaments = value;
            OnPropertyChanged(nameof(Tournaments));
        }
    }

    public MainViewModel()
    {
        _tournaments = TournamentsRepo.Get();
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}