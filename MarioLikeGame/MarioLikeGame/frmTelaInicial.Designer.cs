namespace MarioLikeGame
{
    partial class frmTelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbMario1 = new System.Windows.Forms.PictureBox();
            this.pbMario2 = new System.Windows.Forms.PictureBox();
            this.lblNomeJogo = new System.Windows.Forms.Label();
            this.pnlTelaInicialSup = new System.Windows.Forms.Panel();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.pnlEmresa = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListaRecorde = new System.Windows.Forms.DataGridView();
            this.lblMsgNomeJogador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).BeginInit();
            this.pnlTelaInicialSup.SuspendLayout();
            this.pnlEmresa.SuspendLayout();
            this.gbOpcoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMario1
            // 
            this.pbMario1.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW;
            this.pbMario1.Location = new System.Drawing.Point(70, 8);
            this.pbMario1.Name = "pbMario1";
            this.pbMario1.Size = new System.Drawing.Size(77, 108);
            this.pbMario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMario1.TabIndex = 2;
            this.pbMario1.TabStop = false;
            // 
            // pbMario2
            // 
            this.pbMario2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMario2.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW;
            this.pbMario2.Location = new System.Drawing.Point(982, 8);
            this.pbMario2.Name = "pbMario2";
            this.pbMario2.Size = new System.Drawing.Size(77, 108);
            this.pbMario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMario2.TabIndex = 2;
            this.pbMario2.TabStop = false;
            // 
            // lblNomeJogo
            // 
            this.lblNomeJogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNomeJogo.AutoSize = true;
            this.lblNomeJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNomeJogo.Location = new System.Drawing.Point(405, 18);
            this.lblNomeJogo.Name = "lblNomeJogo";
            this.lblNomeJogo.Size = new System.Drawing.Size(349, 76);
            this.lblNomeJogo.TabIndex = 2;
            this.lblNomeJogo.Text = "Mario Like";
            // 
            // pnlTelaInicialSup
            // 
            this.pnlTelaInicialSup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTelaInicialSup.BackColor = System.Drawing.Color.Coral;
            this.pnlTelaInicialSup.Controls.Add(this.lblNomeJogo);
            this.pnlTelaInicialSup.Controls.Add(this.pbMario2);
            this.pnlTelaInicialSup.Controls.Add(this.pbMario1);
            this.pnlTelaInicialSup.Location = new System.Drawing.Point(1, 1);
            this.pnlTelaInicialSup.Name = "pnlTelaInicialSup";
            this.pnlTelaInicialSup.Size = new System.Drawing.Size(1166, 122);
            this.pnlTelaInicialSup.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmpresa.Location = new System.Drawing.Point(416, 12);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(349, 20);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEmresa
            // 
            this.pnlEmresa.BackColor = System.Drawing.Color.Coral;
            this.pnlEmresa.Controls.Add(this.lblEmpresa);
            this.pnlEmresa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEmresa.Location = new System.Drawing.Point(0, 620);
            this.pnlEmresa.Name = "pnlEmresa";
            this.pnlEmresa.Size = new System.Drawing.Size(1167, 145);
            this.pnlEmresa.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSair.Location = new System.Drawing.Point(58, 300);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(185, 115);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnIniciar.Location = new System.Drawing.Point(58, 69);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(185, 115);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOpcoes.Controls.Add(this.btnIniciar);
            this.gbOpcoes.Controls.Add(this.btnSair);
            this.gbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.ForeColor = System.Drawing.Color.Blue;
            this.gbOpcoes.Location = new System.Drawing.Point(804, 179);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(287, 435);
            this.gbOpcoes.TabIndex = 5;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Blue;
            this.txtNome.Location = new System.Drawing.Point(65, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 53);
            this.txtNome.TabIndex = 3;
            this.txtNome.Text = "Player 1";
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(250, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogador";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvListaRecorde
            // 
            this.dgvListaRecorde.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaRecorde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaRecorde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRecorde.Location = new System.Drawing.Point(6, 128);
            this.dgvListaRecorde.Name = "dgvListaRecorde";
            this.dgvListaRecorde.Size = new System.Drawing.Size(821, 590);
            this.dgvListaRecorde.TabIndex = 0;
            // 
            // lblMsgNomeJogador
            // 
            this.lblMsgNomeJogador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsgNomeJogador.AutoSize = true;
            this.lblMsgNomeJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgNomeJogador.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblMsgNomeJogador.Location = new System.Drawing.Point(237, 328);
            this.lblMsgNomeJogador.Name = "lblMsgNomeJogador";
            this.lblMsgNomeJogador.Size = new System.Drawing.Size(593, 76);
            this.lblMsgNomeJogador.TabIndex = 2;
            this.lblMsgNomeJogador.Text = "MsgNomeJogador";
            this.lblMsgNomeJogador.Visible = false;
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 765);
            this.Controls.Add(this.lblMsgNomeJogador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.pnlEmresa);
            this.Controls.Add(this.pnlTelaInicialSup);
            this.Controls.Add(this.dgvListaRecorde);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaInicial";
            this.Text = "Mario Like";
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).EndInit();
            this.pnlTelaInicialSup.ResumeLayout(false);
            this.pnlTelaInicialSup.PerformLayout();
            this.pnlEmresa.ResumeLayout(false);
            this.gbOpcoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMario1;
        private System.Windows.Forms.PictureBox pbMario2;
        private System.Windows.Forms.Label lblNomeJogo;
        private System.Windows.Forms.Panel pnlTelaInicialSup;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Panel pnlEmresa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListaRecorde;
        private System.Windows.Forms.Label lblMsgNomeJogador;
    }
}