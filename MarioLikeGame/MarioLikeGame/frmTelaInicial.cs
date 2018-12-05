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

namespace MarioLikeGame
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void PreencheGrid()
        {
            //Declarando a DAL
            GamerDAL gamerDAL;

            //Instanciando a DAL na construção do formulário
            gamerDAL = new GamerDAL();

            //Limpando o DataSource
            dgvListaRecorde.DataSource = null;

            //Listando a DAL
            dgvListaRecorde.DataSource = gamerDAL.Listar();

            //Removendo a coluna id_Jogador
            dgvListaRecorde.Columns.Remove("IdJogador");


            //Alterar a fonte, o tamanho e o estilo do cabeçalho
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans",30,FontStyle.Regular);
            //Alterar a fonte, o tamanho e o estilo das células da Grid
            dgvListaRecorde.DefaultCellStyle.Font = new Font("Open Sans",30,FontStyle.Regular);
            //Alterar o alinhamento das grids para centralizado
            dgvListaRecorde.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            //Alterar automaticamente o tamanho das colunas na Grid
            dgvListaRecorde.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //Alterar automaticamente o tamanho das linhas na Grid
            dgvListaRecorde.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            //Remover a coluna do cursor
            dgvListaRecorde.RowHeadersVisible = false;

            //Alterar o título das colunas
            dgvListaRecorde.Columns[0].HeaderText = "Nome";
            dgvListaRecorde.Columns[1].HeaderText = "Score";
            dgvListaRecorde.Columns[2].HeaderText = "Data/Hora";
            dgvListaRecorde.Columns[3].HeaderText = "Tempo";

            //Alterar a fonte do título da coluna
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans",30,FontStyle.Regular);
            //Alterar a cor do título da coluna
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            //Alterar o alinhamento do título das colunas
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Desabilitar o estilo do header para que as alteraçõe surtam efeito
            dgvListaRecorde.EnableHeadersVisualStyles = false;

            if (dgvListaRecorde.RowCount > 0)
            {
                //Alterar a fonte da primeira linha, apontando o campeão
                dgvListaRecorde.CurrentRow.DefaultCellStyle.BackColor = Color.OrangeRed;
            }

            //Alterar a fonte da grid
            dgvListaRecorde.DefaultCellStyle.Font = new Font("Open Sans", 30, FontStyle.Regular);
            //Alterar a cor da célula selecionada
            dgvListaRecorde.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;

            //Alterar a cor de fundo da grid
            dgvListaRecorde.DefaultCellStyle.BackColor = Color.Blue;

            //Alterar a cor da fonte da grid
            dgvListaRecorde.DefaultCellStyle.ForeColor = Color.White;

            //DataGrid somente leitura
            dgvListaRecorde.ReadOnly = true;
        }

        private void lblJogador_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                lblMsgNomeJogador.Visible = true;
                lblMsgNomeJogador.Text = "Digite seu nome";
            }
            else if (txtNome.TextLength > 20)
            {
                lblMsgNomeJogador.Visible = true;
                lblMsgNomeJogador.Text = "Máximo 20 letras";
            }
            else
            {   //Não exibir a instância atual da classe
                this.Visible = false;
                //Criar uma nova instãncia do frmTelaJogo()
                var frm = new frmTelaJogo();
                //Pega o nome do jogador e envia para o Form1
                frm.nomeGamer = txtNome.Text;
                //Exibir o formulário
                frm.ShowDialog();
                //Exibir a nova instãncia da classe
                this.Visible = true;
                //Lista o dataGrid
                PreencheGrid();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            //Preencher o Grid
            PreencheGrid();

            //Setar o foco para o TextBox: nome do jogador
            txtNome.Focus();
            txtNome.Select();

            //Nome da empresa e direitos reservados
            lblEmpresa.Text = "© 2018 Numintendo Games of America Inc. Headquarters are in Redmond, Washington";
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblMsgNomeJogador.Visible = false;
        }
    }
}
