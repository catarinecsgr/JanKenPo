using JanKenPo.ViewModels;

namespace JanKenPo.Views;

public partial class PlayView : ContentPage
{
	public PlayView()
	{
		InitializeComponent();
        EscolhaPicker.SelectedIndex = 0;
		BindingContext = new PlayViewModel();
    }
}