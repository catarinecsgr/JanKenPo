namespace JanKenPo.Models
{
	public class Jogador
    {
        public string Nome { get; set; } = string.Empty;
        public Escolha Escolha { get; set; }
        public int Pontuacao { get; set; }

        public Jogador(string nome) {
            Nome = nome;
        }
        
        public Escolha Jogar()
        {
            int escolha = new Random().Next(3);
            switch (escolha)
            {
                default:
                case 0:
                    return Escolha.PEDRA;
                case 1:
                    return Escolha.PAPEL;
                case 2:
                    return Escolha.TESOURA;
            }
        }
    }
}