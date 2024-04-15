using VetApp.Model;

namespace VetApp;

public partial class EditarVet : ContentPage
{
    Model.Vet antigo;
	public EditarVet()
	{
		InitializeComponent();
	}
    public EditarVet(Model.Vet v) : this()
    {
        antigo = v;
        BindingContext = new Model.Vet() { Nome = v.Nome, Especialidade = v.Especialidade }; ;

    }

    private void Salvar_Clicked(object sender, EventArgs e)
    {
        var aux = (Model.Vet)BindingContext;
        antigo.Nome = aux.Nome;
        antigo.Especialidade = aux.Especialidade;
        Navigation.PopAsync();
    }

    private void Cancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}