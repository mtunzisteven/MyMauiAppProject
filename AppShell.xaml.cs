using MyMauiAppProject.Pages;
using MyMauiAppProject.Pages.Forms;

namespace MyMauiAppProject;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        // Make Astronomical Body page available by registering its route
        Routing.RegisterRoute("newNote", typeof(NewNotePage));
        Routing.RegisterRoute("newTodoItem", typeof(NewToDoItemPage));
    }
}
