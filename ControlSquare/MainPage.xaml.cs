using System.Diagnostics;

namespace ControlSquare;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Debug.WriteLine($"Height={BoxView.Height}, HeightRequest={BoxView.HeightRequest}");
    }
}

