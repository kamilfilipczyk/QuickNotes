using CommunityToolkit.Mvvm.ComponentModel;

namespace QuickNotes.ViewModel
{
    public partial class MainViewModel: ObservableObject
    {
        [ObservableProperty]
        string newNote;
    }
}
