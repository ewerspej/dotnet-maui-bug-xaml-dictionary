namespace XamlOnlyResourceBug;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        //uncomment this and it won't make a difference, either, the styles are not properly applied when x:Class is specified on Styles.xaml and Colors.xaml
        //UpdateTheme();

        MainPage = new AppShell();
    }

    private void UpdateTheme()
    {
        if (Current?.Resources.MergedDictionaries is not { } dictionaries)
        {
            return;
        }

        dictionaries.Clear();
        dictionaries.Add(new Resources.Styles.Colors());
        dictionaries.Add(new Resources.Styles.Styles());
    }
}
