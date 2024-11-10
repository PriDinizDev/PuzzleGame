using System;
using System.Windows.Forms;
using System.Drawing;  // Necess�rio para usar System.Drawing.Point

public partial class Form1 : Form
{
    public partial class PuzzleForm : Form
    {
        private Timer timer;
        private Label lblTempo;
        private Button btnIniciar, btnReiniciar, btnFacil, btnMedio, btnDificil;
        private Panel panel1;
        private PictureBox picFundo;
        private PictureBox[] pecas;  // Array para as PictureBox das pe�as

        public PuzzleForm()
        {
            InitializeComponent();  // Inicializa todos os componentes do formul�rio automaticamente
            CriarControles();       // Configura eventos e outras l�gicas
        }

        // M�todo para configurar eventos e l�gica extra
        private void CriarControles()
        {
            // Ajuste do painel onde as PictureBoxes v�o estar
            panel1 = new Panel();
            panel1.Size = new Size(500, 500);  // Ajuste o tamanho do painel
            panel1.Location = new Point(10, 10);
            this.Controls.Add(panel1);

            // Adiciona a imagem de fundo no painel
            picFundo = new PictureBox();
            picFundo.Size = new Size(500, 500);  // Ajuste o tamanho da imagem
            picFundo.Location = new Point(0, 0);
            picFundo.Image = Image.FromFile("caminho_da_imagem");  // Substitua pelo caminho da sua imagem
            picFundo.SizeMode = PictureBoxSizeMode.StretchImage;
            panel1.Controls.Add(picFundo);

            // Inicializa e configura as PictureBox para as pe�as
            pecas = new PictureBox[24];  // 24 pe�as
            for (int i = 0; i < pecas.Length; i++)
            {
                pecas[i] = new PictureBox();
                pecas[i].Size = new Size(100, 100);  // Ajuste o tamanho das pe�as
                pecas[i].Location = new Point((i % 5) * 100, (i / 5) * 100);  // Disposi��o em grade 5x5
                pecas[i].BorderStyle = BorderStyle.FixedSingle;  // Apenas para visualiza��o, pode remover depois
                pecas[i].Name = "peca" + i.ToString();
                panel1.Controls.Add(pecas[i]);
            }

            // Configura��o dos bot�es
            btnIniciar = new Button();
            btnIniciar.Text = "Iniciar";
            btnIniciar.Location = new Point(520, 50);
            btnIniciar.Click += BtnIniciar_Click;  // Evento para iniciar o jogo
            this.Controls.Add(btnIniciar);

            btnReiniciar = new Button();
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.Location = new Point(520, 100);
            btnReiniciar.Click += BtnReiniciar_Click;  // Evento para reiniciar o jogo
            this.Controls.Add(btnReiniciar);

            btnFacil = new Button();
            btnFacil.Text = "F�cil";
            btnFacil.Location = new Point(520, 150);
            btnFacil.Click += BtnFacil_Click;  // Evento para dificuldade f�cil
            this.Controls.Add(btnFacil);

            btnMedio = new Button();
            btnMedio.Text = "M�dio";
            btnMedio.Location = new Point(520, 200);
            btnMedio.Click += BtnMedio_Click;  // Evento para dificuldade m�dia
            this.Controls.Add(btnMedio);

            btnDificil = new Button();
            btnDificil.Text = "Dif�cil";
            btnDificil.Location = new Point(520, 250);
            btnDificil.Click += BtnDificil_Click;  // Evento para dificuldade dif�cil
            this.Controls.Add(btnDificil);

            // Label para mostrar o tempo
            lblTempo = new Label();
            lblTempo.Text = "Tempo: 00:00";
            lblTempo.Location = new Point(520, 300);
            this.Controls.Add(lblTempo);

            // Timer para o tempo
            timer = new Timer();
            timer.Interval = 1000;  // Intervalo de 1 segundo
            timer.Tick += Timer_Tick;
        }

        // Eventos para os bot�es 
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            // L�gica para iniciar o jogo
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            // L�gica para reiniciar o jogo
        }

        private void BtnFacil_Click(object sender, EventArgs e)
        {
            // L�gica para dificuldade f�cil
        }

        private void BtnMedio_Click(object sender, EventArgs e)
        {
            // L�gica para dificuldade m�dia
        }

        private void BtnDificil_Click(object sender, EventArgs e)
        {
            // L�gica para dificuldade dif�cil
        }

        // Evento de tick do timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            // L�gica para contagem do tempo
        }
    }
}
