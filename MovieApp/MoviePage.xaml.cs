using MovieApp.ViewModel;

namespace MovieApp;

public partial class MoviePage : ContentPage
{
	public MoviePage(MainViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;

    }
}