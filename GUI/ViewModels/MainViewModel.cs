public class MainViewModel : INotifyPropertyChanged
{

    public string SteamId {get;set;}

    public string Username {get;set;}

    public ObservableCollection<Game> Games {get;}
        = new();


    public ICommand LoadCommand =>
        new RelayCommand(async () =>
        {

            var api = new SteamInfoPuller();

            var data = await api.GetInfo(SteamId);


            Username = data.Name;

            Games.Clear();

            foreach(var game in data.Games)
                Games.Add(game);

            OnPropertyChanged("");

        });

}