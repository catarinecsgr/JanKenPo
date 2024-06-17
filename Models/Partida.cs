namespace JanKenPo.Models
{
    public class Partida
    {
        public Jogador Jogador { get; set; }
        public Jogador Maquina { get; set; }

        public Partida(Jogador jogador, Jogador maquina)
        {
            Jogador = jogador;
            Maquina = maquina;
        }

        public string DarPontuacao()
        {
            if (Jogador.Escolha == Maquina.Escolha) {
                Jogador.Pontuacao += 1;
                Maquina.Pontuacao += 1;
                return "EMPATE";
            } else if((Jogador.Escolha == Escolha.PEDRA && Maquina.Escolha == Escolha.TESOURA)
                || (Jogador.Escolha == Escolha.PAPEL && Maquina.Escolha == Escolha.PEDRA)
                || (Jogador.Escolha == Escolha.TESOURA && Maquina.Escolha == Escolha.PAPEL)) {
                Jogador.Pontuacao += 3;
                return $"VENCEDOR: {Jogador.Nome}";
            } else {
                Maquina.Pontuacao += 3;
                return $"VENCEDOR: {Maquina.Nome}";
            }
        }
    }
}