# Changelog

All notable changes to this project will be documented in this file.

## [1.0.0] - 11-01-2025
### Added
- Initial project setup with WPF and MVVM architecture.
- MainWindow with TextBox for note input, ListBox for displaying notes.
- `SaveNoteCommand` and associated button to add notes to the ListBox.
- `RemoveNoteCommand` and associated button to delete selected notes.
- Basic ViewModel (`MainViewModel`) for managing notes and commands.
- `MainWindow.xaml` for the view display.
- Integrated `ObservableCollection` to manage dynamic updates to notes list.
- Test file created: `MainViewModelTests` with tests for `SaveNoteCommand` and `RemoveNoteCommand`.
- Created `README.md` with basic project details and instructions.
- Added `LICENSE` file with MIT License.
- Added an `Images` folder with gif for showcase of the project.

### Fixed
- Corrected initial ViewModel binding to ensure the UI responds to changes in the ViewModel.

## [unreleased] - 10-01-2025
### Added
- Project created with basic structure for NoteTaker app.
- Initial setup for `RelayCommand` for command functionality.
- Set up `ICommand` bindings for save and remove note actions.

