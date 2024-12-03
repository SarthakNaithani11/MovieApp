using MovieApp.ViewModel;
using System.Collections.ObjectModel;

namespace MovieApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        public class movieInfo
        {
            public int id { get; set; }
            public string title { get; set; }
            public string poster_path { get; set; }
            public string release_date { get; set; }
        }
        


    } 

}
