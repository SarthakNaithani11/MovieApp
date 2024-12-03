namespace MovieApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DetailPage),typeof(DetailPage));
            Routing.RegisterRoute(nameof(DetailPage2), typeof(DetailPage2));
            Routing.RegisterRoute(nameof(DetailPage3), typeof(DetailPage3));
            Routing.RegisterRoute(nameof(DetailPage4), typeof(DetailPage4));
            Routing.RegisterRoute(nameof(DetailPage5), typeof(DetailPage5));
            Routing.RegisterRoute(nameof(DetailPage6), typeof(DetailPage6));
            Routing.RegisterRoute(nameof(DetailPage7), typeof(DetailPage7));
            Routing.RegisterRoute(nameof(DetailPage8), typeof(DetailPage8));
            Routing.RegisterRoute(nameof(MoviePage),typeof(MoviePage));
        }
    }
}
