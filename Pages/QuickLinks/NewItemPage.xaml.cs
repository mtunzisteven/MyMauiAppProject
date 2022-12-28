namespace MyMauiAppProject.Pages.QuickLinks;

public partial class NewItemPage : ContentPage
{
	public NewItemPage()
	{
		InitializeComponent();

        // Add navigation to all child pages by registering their routes and send data using query string
        note.Clicked += async (s, e) => await Shell.Current.GoToAsync("newNote");
        todo.Clicked += async (s, e) => await Shell.Current.GoToAsync("newTodoItem");

    }
}