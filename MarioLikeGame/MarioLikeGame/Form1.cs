using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarioLikeGame.DAL;
using MarioLikeGame.Model;

namespace MarioLikeGame
{
    public partial class frmTelaJogo : Form
    {
        //Declarando a DAL
        GamerDAL gamerDAL;

        //Criar um atributo para pegar o nome do jogador
        public string nomeGamer { get; set; }

        //Atributos para controle da movimentação do personagem
        private bool paraCima;
        private bool paraBaixo;
        private bool paraDireita;
        private bool paraEsquerda;

        //Variável para condições de vitoria/derrota
        private bool vitoria = false;

        //Variável para pontuação
        private int pontos = 0;

        //Variáveis para controlar o cronômetro do jogo
        int segundos = 0;
        int minutos = 0;

        //Atributo responsável pela velocidade de locomoção do personagem
        private int velocidade = 10;

        //Biblioteca do Windows Media Player
        //WMPLib.WindowsMediaPlayer Tocador = new WMPLib.WindowsMediaPlayer();

        //Criar uma lista de mídias
        List<System.Windows.Media.MediaPlayer> sounds = new List<System.Windows.Media.MediaPlayer>();

        public frmTelaJogo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frmTelaJogo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmTelaJogo_Load(object sender, EventArgs e)
        {
            //Audio("overworld.mp3", "Play");
            playSound("overworld.mp3");
        }

        //Movimentar o personagem quando pressiono a tecla
        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                paraEsquerda = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                paraDireita = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                paraCima = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                paraBaixo = true;
            }
        }

        //Parar o movimento do personagem quando soltar a tecla
        private void KeyisUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    paraEsquerda = false;
                    break;
                case Keys.Right:
                    paraDireita = false;
                    break;
                case Keys.Up:
                    paraCima = false;
                    break;
                case Keys.Down:
                    paraBaixo = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPontos.Text = "Pontos: " + pontos;
            if (paraEsquerda)
            {
                //Movimenta o personagem para esquerda
                personagem.Left -= velocidade;
            }

            if (paraDireita)
            {
                //Movimenta o personagem para Direita
                personagem.Left += velocidade;
            }

            //Movimenta o personagem para cinma
            if (paraCima)
            {
                personagem.Top -= velocidade;
            }

            //Movimenta o personagem para baixo
            if (paraBaixo)
            {
                personagem.Top += velocidade;
            }

            //Posicionamento do personagem dentro da área do formulário (tela)
            if (personagem.Left < 0)
            {
                personagem.Left = 0;
            }

            if (personagem.Left > 1090)
            {
                personagem.Left = 1090;
            }

            if (personagem.Top < 70)
            {
                personagem.Top = 70;
            }

            if (personagem.Top > 680)
            {
                personagem.Top = 680;
            }

            //Loop para checar todos os controles inseridos no form
            foreach (Control item in this.Controls)
            {
                //Verifica se o jogador colidiu com o inimigo, caso positivo GameOver
                if (item is PictureBox && (string)item.Tag == "inimigo")
                {
                    //Checa colisão com as PictureBox
                    if (((PictureBox)item).Bounds.IntersectsWith(personagem.Bounds))
                    {
                        GravaHiScore();
                        vitoria = false;
                        GameOver(vitoria);
                        RemovePictureBox();
                    }
                }

                //Verifica se o jogador colidiu com o item, caso positivo o destrua
                if (item is PictureBox && ((string)item.Tag == "moeda" || (string)item.Tag == "cogumelo"))
                {
                    
                    //Checa colisão com as PictureBox
                    if (((PictureBox)item).Bounds.IntersectsWith(personagem.Bounds))
                    {

                        if ((string)item.Tag == "moeda")
                        {
                            //Incrementar a variável pontos
                            pontos++;
                            //Toca o áudio
                            playSound("smb_coin.wav");
                        }
                        else
                        {
                            //Incrementar a variável pontos
                            pontos+=2;
                            //Toca o áudio
                            playSound("smb_powerup.wav");
                            //Aumentar o Mario
                            personagem.Width += 20;
                            personagem.Height += 20;
                        }
                        

                        //Remove o item coletável
                        this.Controls.Remove(item);

                        

                        //Condição de Vitória
                        if (pontos == 20)
                        {
                            GravaHiScore();
                            vitoria = true;
                            GameOver(vitoria);
                            RemovePictureBox();
                        }
                    }
                }
            }
        }

        private void GravaHiScore()
        {
            //Instanciar a DAL
            gamerDAL = new GamerDAL();

            Placar placar = new Placar();

            var frm = new frmTelaInicial();

            if (!this.nomeGamer.Equals(""))
            {
                placar.NomeJogador = this.nomeGamer;
            }
            else
            {
                placar.NomeJogador = "Player 1";
            }

            placar.Tempo = $"{ minutos.ToString("00")}:{ segundos.ToString("00")}";
            placar.ScoreJogador = pontos;
            placar.DataScore = DateTime.Now;

            //Chama a função Inserir da DAL passando o objeto populado como parâmetro
            if (!gamerDAL.Inserir(placar))
            {
                //Deu pau! Exibe Mensagem para o usuário... :(
                MessageBox.Show("Erro ao inserir os dados: \r\n\r\n" +
                    gamerDAL.MensagemErro, "Mario Like Game");
            }
        }

        private void RemovePictureBox()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && (string)item.Tag != "gameOver")
                {
                    ((PictureBox)item).Image = null;
                }
            }
        }

        private void GameOver(bool ganhou)
        {
            lblPontos.Text = "Pontos: " + pontos;
            personagem.Visible = false;
            btnRestart.Visible = true;
            btnRestart.Focus();

            //Parar o áudio
            stopSound();
            
            if (ganhou)
            {
                pbGameWin.Visible = true;
                playSound("smb_stage_clear.wav");
                lblMsgFinal.Visible = true;

                lblMsgFinal.Text = ($"Parabéns {nomeGamer}!!!");
            }
            else
            {
                pbGameOver.Visible = true;
                playSound("smb_gameover.wav");
                lblMsgFinal.Visible = true;
                lblMsgFinal.Text = ($"{nomeGamer}, vocé é muito noob!");
            }
            timer1.Stop();
            timer2.Stop();
        }

        private void lblPontos_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 60)
            {
                minutos++;
                //segundos = 0;
            }
            segundos = segundos % 60;
            lblTempo.Text = "Tempo: " + minutos.ToString("00") + ":" + segundos.ToString("00");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            this.Close();
        }

        //private void Audio(string caminho,string estadoMP)
        //{
        //    //Verfica se ocorreu erro ao instanciar o Windows media Player
        //    Tocador.MediaError += new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Tocador_MediaError);

        //    Tocador.URL = caminho;
        //    if (estadoMP.Equals("Play"))
        //    {
        //        Tocador.controls.play();
        //    }
        //    else if (estadoMP.Equals("Stop"))
        //    {
        //        Tocador.controls.stop();
        //    }
        //}

        //private void Tocador_MediaError(object pMediaObject)
        //{
        //    MessageBox.Show("Não é possível executar o arquivo de mídia.");
        //    this.Close();
        //}

        private void playSound(string nome)
        {
            string url = Application.StartupPath + @"\" + nome;
            var sound = new System.Windows.Media.MediaPlayer();
            sound.Open(new Uri(url));
            sound.Play();
            sounds.Add(sound);
        }

        private void stopSound()
        {
            for (int i = sounds.Count -1; i >= 0 ; i--)
            {
                sounds[i].Stop();
                sounds.RemoveAt(i);
            }
        }
    }
}
