using System;
using System.Collections.Generic;
using System.Text;

namespace MarioLikeGame.Model
{
    public class Placar
    {
        private int idJogador;
        private string nomeJogador;
        private int scoreJogador;
        private DateTime dataScore;
        private string tempo;

        public Placar()
        {

        }

        public Placar(int idJogador, string nomeJogador, int scoreJogador, DateTime dataScore, string tempo)
        {
            this.IdJogador = idJogador;
            this.NomeJogador = nomeJogador;
            this.ScoreJogador = scoreJogador;
            this.DataScore = dataScore;
            this.Tempo = tempo;
        }

        //Getters and Setters
        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string NomeJogador { get => nomeJogador; set => nomeJogador = value; }
        public int ScoreJogador { get => scoreJogador; set => scoreJogador = value; }
        public DateTime DataScore { get => dataScore; set => dataScore = value; }
        public string Tempo { get => tempo; set => tempo = value; }
    }
}
