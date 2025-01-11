using NoteTaker.ViewModels;

namespace NoteTaker.Tests;

public class MainViewModelTests
{
    [Fact]
    public void SaveNoteCommand_AddsNoteToList()
    {
        // Arrange
        var viewModel = new MainViewModel();
        viewModel.NoteText = "Test Note";

        // Act
        viewModel.SaveNoteCommand.Execute(null);

        // Assert
        Assert.Contains("Test Note", viewModel.Notes);
    }
    [Fact]
    public void RemoveNoteCommand_RemovesNoteFromList()
    {
        // Arrange
        var viewModel = new MainViewModel();
        viewModel.NoteText = "Test Note";
        viewModel.SaveNoteCommand.Execute(null);
        viewModel.SelectedNote = viewModel.Notes[0];

        // Act
        viewModel.RemoveNoteCommand.Execute(null);

        // Assert
        Assert.DoesNotContain("Test Note", viewModel.Notes);
    }
}