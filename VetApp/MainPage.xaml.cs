namespace VetApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Pet_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pet());
    }

    private void Agenda_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Agenda());
    }

    private void Vet_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vet());
    }
}

