namespace VetApp;

public partial class App : Application
{
	public static List<Model.Vet> vets;
	public static List<Pet> pets;
	public static List<Agenda> agenda;
	public App()
	{
		InitializeComponent();
		vets = new List<Model.Vet>();
		pets = new List<Pet>();
		agenda = new List<Agenda>();

		MainPage = new AppShell();
	}
}
