using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Wpf_tutorial_06_DBinding_INotifyPropertyChanged
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        // need a full property for our binding
        // propfull
        private string boundText;

        // ? : Jelzi a fordítónak, hogy előfordulhat, hogy senki sem iratkozott fel az eseményre.
        // Ha senki nem figyeli, akkor a PropertyChanged értéke nem egy létező eseménykezelőre mutat, hanem null lesz.

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }
            set {
                boundText = value;
                // valahányszor ez a setter beállításra kerül, invoke-olja az event-et azzal,
                // hogy ez a property megváltozott, és így a GUI ennek megfelelően tud reagálni.
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
                //OnPropertyChanged("BoundText");
                OnPropertyChanged();

            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "kódból állítjuk be a szöveget";
        }

        // private void OnPropertyChanged(string propertyName)
        // CallerMemberName a hívó alapján automatikusan feltölti ezt az argument-et nekünk.
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            // propertyName-t fogad és közvetlenül átadhatjuk az event invoke-nak
            // invoking event
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}