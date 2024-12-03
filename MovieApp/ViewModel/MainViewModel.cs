using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MovieApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() 
        {
            movielist = new ObservableCollection<MovieInfo>() ; 
            movieInfo = new MovieInfo() ;   
        }
        [ObservableProperty]
        ObservableCollection<MovieInfo> movielist ;

        MovieInfo movieInfo ;   
        [ObservableProperty]
        result movies;
        
        [ObservableProperty]
        String text;

        [ObservableProperty]
        String text2 ;

        [ObservableProperty]
        String name1 ;
        [ObservableProperty]
        String name2;
        [ObservableProperty]
        String name3;
        [ObservableProperty]
        String name4;
        [ObservableProperty]
        String name5;
        [ObservableProperty]
        String name6;
        [ObservableProperty]
        String name7;
        [ObservableProperty]
        String name8;

        [ObservableProperty]
        String movieUrl;

        
        [RelayCommand]
        async void Search()
        {
            text = text.Replace("     ", "%20");
            text = text.Replace("    ", "%20");
            text = text.Replace("   ", "%20");
            text = text.Replace("  ", "%20");
            text = text.Replace(" ", "%20");

            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.themoviedb.org/3/search/movie?query={text}&include_adult=false&language=en-US&page=1"),
                Headers =
                {
                { "accept", "application/json" },
                { "Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJiNGU2YzY2N2U5ZWE3MGNhN2E0N2MzOTNhODQ4NjU0MyIsIm5iZiI6MTcyNTU4MDIxOC40Nzk2NTcsInN1YiI6IjY2ZGE0MDY2ZjVjNTBkY2RhMzlkMTI0ZiIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.QQ0EaUH6IURehTbIxBPSNNr9jlb_fkGik3El4Zd6jSQ" }
                }
            };
            var client = new HttpClient();

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                movies = System.Text.Json.JsonSerializer.Deserialize<result>(body);
                movielist = movies.results;
                name1 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[0].poster_path}";
            }
            if (movielist.Count == 1)
            {
                await Shell.Current.GoToAsync(nameof(DetailPage));
            }
            if (movielist.Count == 2)
            {
                name2 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[1].poster_path}";
                await Shell.Current.GoToAsync(nameof(DetailPage2));
            }
            if (movielist.Count == 3)
            {
                name2 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[1].poster_path}";
                name3 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[2].poster_path}";
                await Shell.Current.GoToAsync(nameof(DetailPage3));
            }
            if (movielist.Count == 4)
            {
                name2 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[1].poster_path}";
                name3 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[2].poster_path}";
                name4 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[3].poster_path}";
                await Shell.Current.GoToAsync(nameof(DetailPage4));
            }
            if (movielist.Count == 5)
            {
                name2 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[1].poster_path}";
                name3 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[2].poster_path}";
                name4 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[3].poster_path}";
                name5 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[4].poster_path}";
                await Shell.Current.GoToAsync(nameof(DetailPage5));
            }
            if (movielist.Count == 6)
            {
                name2 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[1].poster_path}";
                name3 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[2].poster_path}";
                name4 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[3].poster_path}";
                name5 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[4].poster_path}";
                name6 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[5].poster_path}";
                await Shell.Current.GoToAsync(nameof(DetailPage6));
            }
            if (movielist.Count == 7)
            {
                name2 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[1].poster_path}";
                name3 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[2].poster_path}";
                name4 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[3].poster_path}";
                name5 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[4].poster_path}";
                name6 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[5].poster_path}";
                name7 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[6].poster_path}";
                await Shell.Current.GoToAsync(nameof(DetailPage7));
            }
            if (movielist.Count >= 8)
            {
                name2 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[1].poster_path}";
                name3 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[2].poster_path}";
                name4 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[3].poster_path}";
                name5 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[4].poster_path}";
                name6 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[5].poster_path}";
                name7 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[6].poster_path}";
                name8 = $"https://media.themoviedb.org/t/p/w300_and_h450_bestv2{movies.results[7].poster_path}";
                await Shell.Current.GoToAsync(nameof(DetailPage8));
            }
            
        }
        
        
        [RelayCommand]
        async void Movie()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[0].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }
        [RelayCommand]
        async void Movie2()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[1].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }
        [RelayCommand]
        async void Movie3()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[2].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }
        [RelayCommand]
        async void Movie4()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[3].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }
        [RelayCommand]
        async void Movie5()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[4].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }
        [RelayCommand]
        async void Movie6()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[5].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }
        [RelayCommand]
        async void Movie7()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[6].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }
        [RelayCommand]
        async void Movie8()
        {
            movieUrl = $"https://vidsrc.net/embed/movie?tmdb={movies.results[7].id}";
            await Shell.Current.GoToAsync(nameof(MoviePage));
        }



        public class result
        {
            public ObservableCollection<MovieInfo> results { get; set; }
        }

        
        public class MovieInfo
        {
            
            public int id { get; set; }
            public string title { get; set; }
            public string poster_path { get; set; }
            public string release_date { get; set; }
        }


    }
}
