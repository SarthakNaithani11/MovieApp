using MovieApp.ViewModel;

namespace MovieApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(MainViewModel vm)
	{
		InitializeComponent(); 
		BindingContext = vm;

	}

    
    public class MovieInfo
    {
        public int id { get; set; }
        public string title { get; set; }
        public string poster_path { get; set; }
        public string release_date { get; set; }
    }
}