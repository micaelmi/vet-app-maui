using VetApp.Model;

namespace VetApp;

public partial class NovoVet : ContentPage
{
    private Model.Vet newVet;
    public NovoVet()
	{
		InitializeComponent();
        newVet = new Model.Vet();
        BindingContext = newVet;
    }

    private void Cadastrar_Clicked(object sender, EventArgs e)
    {
        App.vets.Add(newVet);
        Navigation.PopAsync();
    }
}