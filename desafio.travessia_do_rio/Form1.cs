using System;
using System.Drawing;
using System.Windows.Forms;

namespace desafio.travessia_do_rio
{
    public partial class Form1 : Form
    {
        private readonly int SIDE_LEFT = 79;
        private readonly int SIDE_RIGHT = 239;
        private bool PosicaoHomem = false;
        private bool PosicaoLobo = false;
        private bool PosicaoGalinha = false;
        private bool PosicaoMilho = false;


        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Evento de click do botão "Mover"
        /// </summary>
        /// <param name="sender">Objeto que disparou o evento</param>
        /// <param name="e">o Evento em si</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if ((
                    Convert.ToInt32(cbHomem.Checked) +
                    Convert.ToInt32(cbLobo.Checked) +
                    Convert.ToInt32(cbGalinha.Checked) +
                    Convert.ToInt32(cbMilho.Checked)) > 2
            )
            {
                MessageBox.Show("Só cabem dois no barco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCheboxes();
                return;
            }

            if (!cbHomem.Checked)
            {
                MessageBox.Show("Os Animais não andam de barco sózinhos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCheboxes();
                return;
            }


            if (cbHomem.Checked)
            {
                PosicaoHomem = !PosicaoHomem;
                MudarPosicao(imgHomem);
            }

            if (cbLobo.Checked)
            {
                PosicaoLobo = !PosicaoLobo;
                MudarPosicao(imgLobo);
            }
            if (cbGalinha.Checked)
            {
                PosicaoGalinha = !PosicaoGalinha;
                MudarPosicao(imgGalinha);
            }
            if (cbMilho.Checked)
            {
                PosicaoMilho = !PosicaoMilho;
                MudarPosicao(imgMilho);
            }

            var resultado = ChecarMovimento(PosicaoHomem, PosicaoLobo, PosicaoGalinha, PosicaoMilho);

            if (resultado.Terminou)
            {
                MessageBox.Show(resultado.Mensagem, "", MessageBoxButtons.OK);
                Reset();
            }
        }

        /// <summary>
        /// Muda a posição da imagem na tela, ou seja, atravessa o personagem no rio
        /// </summary>
        /// <param name="pb"></param>
        private void MudarPosicao(PictureBox pb)
        {
            if (pb.Location.Y == SIDE_LEFT)
            {
                pb.Location = new Point(pb.Location.X, SIDE_RIGHT);
            }
            else
            {
                pb.Location = new Point(pb.Location.X, SIDE_LEFT);
            }
        }

        /// <summary>
        /// Volta os componentes da tela ao seu estado original
        /// </summary>
        private void Reset()
        {
            PosicaoHomem = false;
            PosicaoLobo = false;
            PosicaoGalinha = false;
            PosicaoMilho = false;

            imgHomem.Location = new Point(imgHomem.Location.X, SIDE_LEFT);
            imgLobo.Location = new Point(imgLobo.Location.X, SIDE_LEFT);
            imgGalinha.Location = new Point(imgGalinha.Location.X, SIDE_LEFT);
            imgMilho.Location = new Point(imgMilho.Location.X, SIDE_LEFT);

            cbHomem.Checked = false;
            cbLobo.Checked = false;
            cbGalinha.Checked = false;
            cbMilho.Checked = false;
        }

        /// <summary>
        /// Desmarca todas as checkboxes dos personagens
        /// </summary>
        private void LimparCheboxes()
        {
            cbHomem.Checked = false;
            cbLobo.Checked = false;
            cbGalinha.Checked = false;
            cbMilho.Checked = false;
        }

        /// <summary>
        /// Valida uma joga
        /// </summary>
        /// <param name="homem">Representa qual lado do rio o Homem está, sendo "false" para o lado esquerdo e "true" para o lado direito</param>
        /// <param name="lobo">Representa qual lado do rio o Lobo está, sendo "false" para o lado esquerdo e "true" para o lado direito</param>
        /// <param name="galinha">Representa qual lado do rio a Galinha está, sendo "false" para o lado esquerdo e "true" para o lado direito</param>
        /// <param name="milho">Representa qual lado do rio o Milho está, sendo "false" para o lado esquerdo e "true" para o lado direito</param>
        /// <returns></returns>
        private MoveResult ChecarMovimento(bool homem, bool lobo, bool galinha, bool milho)
        {
            return
                new MoveResult()
                {
                    Terminou = true,
                    Mensagem = "Implemente esse Método"
                };
        }

        /// <summary>
        /// Classe que representa o resultado de uma ação.
        /// </summary>
        private class MoveResult
        {
            /// <summary>
            /// Indica se o jogo terminou
            /// </summary>
            public bool Terminou { get; set; }

            /// <summary>
            /// Mensagem que será exibida ao usuário.
            /// </summary>
            public String Mensagem { get; set; }
        }
    }
}
