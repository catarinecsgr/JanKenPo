using CommunityToolkit.Mvvm.ComponentModel;
using JanKenPo.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace JanKenPo.ViewModels
{
	public partial class PlayViewModel : ObservableObject
    {
		public PlayViewModel()
		{
			PlayCommand = new Command(Jogar);
		}

		[ObservableProperty]
		public string _nome;

        [ObservableProperty]
        public Escolha _escolhaJogador;

        [ObservableProperty]
        public Escolha _escolhaMaquina;

		[ObservableProperty]
		public string _vencedor;

		public ICommand PlayCommand { get; }

		public void Jogar()
		{
            Jogador jogador = new Jogador(Nome);
			Jogador maquina = new Jogador("Maquina");
			maquina.Escolha = maquina.Jogar();
			EscolhaMaquina = maquina.Escolha;
			Vencedor = new Partida(jogador, maquina).DarPontuacao();
		}
	}	
}
