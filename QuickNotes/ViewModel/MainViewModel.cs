using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace QuickNotes.ViewModel
{
    public partial class MainViewModel: ObservableObject
    {
        public MainViewModel()
        {
            Notes = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> notes;

        [ObservableProperty]
        string newNote;

        [RelayCommand]
        void AddNewNote()
        {
            if (string.IsNullOrWhiteSpace(NewNote))
                return;
            else
                Notes.Add(NewNote);
            NewNote = string.Empty;
        }
    }
}
