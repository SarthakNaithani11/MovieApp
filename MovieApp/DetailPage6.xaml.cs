using MovieApp.ViewModel;

namespace MovieApp;

public partial class DetailPage6 : ContentPage
{
    public DetailPage6(MainViewModel vm)
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