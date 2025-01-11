# NoteTaker App

## Overview

The **NoteTaker App** is a simple WPF application built using the **MVVM (Model-View-ViewModel)** pattern in **C#**. It allows users to manage notes with functionalities to create and delete notes. 

The app demonstrates a clean separation of concerns and adheres to best practices in WPF development.

---

## Features

- **Add Notes**: Create a new note using the provided text box and save it.
- **Delete Notes**: Remove selected notes from the list.
- **View Notes**: Display all saved notes in a list.

---

## Showcase

![NoteTaker App Showcase](Images/NoteTakerShowcase.gif)

---

## MVVM Structure

The application is structured following the MVVM design pattern:

### **MainWindow (View)**
- The `MainWindow.xaml` contains the UI elements, such as:
  - A `TextBox` for note input.
  - A `ListBox` to display the list of notes.
  - Buttons for saving and removing notes.
- The `DataContext` is bound to the `MainViewModel`.

### **MainViewModel**
- Acts as the bridge between the `View` and the application logic.
- Contains:
  - A list of notes (`ObservableCollection<string>`).
  - The `NoteText` property for binding the user input from the `TextBox`.
  - The `SelectedNote` property for binding the user selected note from the `ListBox`.
  - Commands:
    - **`SaveNoteCommand`**: Adds a new note to the list.
    - **`RemoveNoteCommand`**: Removes the selected note.

### **Commands**
- **RelayCommand**: Implements `ICommand` to handle actions triggered by the UI.
- **SaveNoteCommand**: Adds the note in `NoteText` to the `Notes` collection.
- **RemoveNoteCommand**: Deletes the currently selected note.

---

## Installation and Usage with Release Binary File

### Prerequisites

- Windows operating system

### Installation Steps

1. Navigate to the **Releases** section of this project.
   - The latest release can be found [here](https://github.com/raken15/NoteTakerApp/releases/).
2. Download the `NoteTakerApp_v1.0.0.zip` file.
   - Or any other release version zip file.
4. Extract the contents of the zip file.
5. Run the `NoteTaker.exe` file.
6. Save notes or Remove Notes by using the textbox and the listbox and the buttons

---

## Building and Running the Project

### Build and Runtime Prerequisites

- Visual Studio Code (or any text editor/IDE with C# support)
- .NET 8.0 SDK
- Windows operating system

### Building the Project

1. Clone the repository:
    ```bash
    git clone https://github.com/raken15/NoteTakerApp.git
    ```
   - Alternatively, you can click the green **Code** button on the project’s GitHub page to download as a zip file and extract it.
   
2. Navigate to the solution directory:
    ```bash
    cd NoteTakerApp
    ```
   - You may also use your file explorer to navigate to the solution folder.

3. Open the solution (`.sln` file) in Visual Studio Code or another compatible text editor/IDE.

4. Build the solution to restore all dependencies.

### Executing the Project Post-Build

1. Build the solution.
2. Execute the application either from Visual Studio Code from the project `NoteTaker` or by running the executable (`.exe` file) located in the `bin` folder.
---

## How It Works

### Adding Notes
1. Type a note into the `TextBox`.
2. Click the "Save" button.
3. The note appears in the `ListBox`.

### Removing Notes
1. Select a note from the `ListBox`.
2. Click the "Remove" button.
3. The selected note is deleted from the list.

---

## Testing

This project includes unit tests for the `MainViewModel` class.

### Tests

- **MainViewModelTests**
  - `SaveNoteCommand_AddsNoteToList`: Verifies that when a note is saved, it is added to the `Notes` collection.
  - `RemoveNoteCommand_RemovesNoteFromList`: Verifies that when a note is removed, it is deleted from the `Notes` collection.

### Running Tests

To run the tests, open the tests in Visual Studio Code or your preferred IDE, and use the following command:
```bash
dotnet test
```
This will run all the tests in the solution and display the results in the terminal.

---

## Future Improvements
- Add persistent storage for notes (e.g., saving notes to a file or database).
- Enable editing of existing notes.
- Add categories or tags for notes.
- Improve UI design.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
