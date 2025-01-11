using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using NoteTaker.Helpers;

namespace NoteTaker.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public ObservableCollection<string> Notes { get; set; } = new ObservableCollection<string>();
    private string _noteText = string.Empty;
    public string NoteText
    {
        get { return _noteText; }
        set {
            _noteText = value;
            OnPropertyChanged(nameof(NoteText));
            if(SaveNoteCommand is RelayCommand relayCommand)
            {
                relayCommand.RaiseCanExecuteChanged();
            }
        }
    }
    public ICommand SaveNoteCommand { get; }
    public MainViewModel()
    {
        SaveNoteCommand = new RelayCommand(SaveNote, CanSaveNote);
    }
    public void SaveNote()
    {
        if(!string.IsNullOrEmpty(NoteText))
        {
            Notes.Add(NoteText);
            NoteText = string.Empty;
        }
    }
    public bool CanSaveNote() => !string.IsNullOrEmpty(NoteText);
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
