using VetApp.Model;

namespace VetApp;

public partial class Vet : ContentPage
{
	public Vet()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        vets.ItemsSource = null;
        vets.ItemsSource = App.vets;
    }
    
    private void Novo_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NovoVet());
    }

    private void Editar_Clicked(object sender, EventArgs e)
    {
        var aux = (Model.Vet)((sender as MenuItem).BindingContext);

        Navigation.PushAsync(new EditarVet(aux));
    }

    private async void Excluir_Clicked(object sender, EventArgs e)
    {
        var aux = (Model.Vet)((sender as MenuItem).BindingContext);

        var resultado = await DisplayAlert("Alerta!",
          "Este processo n�o poder� ser desfeito.\n Deseja continuar?",
          "Sim", "N�o");
        if (resultado == true) {App.vets.Remove(aux);
            _ = DisplayAlert("Aten��o", "Opera��o realizada", "ok");
            OnAppearing();
        } else { _ = DisplayAlert("Aten��o", "Opera��o cancelada", "ok");}
    }
}