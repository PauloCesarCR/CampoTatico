namespace CampoTatico
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

            for (int i = 0; i < 22; i++)
            {
                Bolinha bolinha = new Bolinha();
                if (i >= 11)
                {
                    bolinha.Location = new Point(315 + i * 40, 10); 
                    bolinha.BackColor = Color.White;
                } else { 
                    bolinha.Location = new Point(90 + i * 40, 10);
                }
                
                this.Controls.Add(bolinha); 
                bolinha.MouseDown += bolinha_MouseDown;
                bolinha.MouseMove += bolinha_MouseMove;
                bolinha.MouseUp += bolinha_MouseUp;
            }

        }

        private void bolinha_MouseDown(object sender, MouseEventArgs e)
        {
            Bolinha bolinha = (Bolinha)sender;
            bolinha.Capture = true;
            bolinha.BringToFront();
     
            bolinha.Tag = new Point(e.X, e.Y);
        }

        private void bolinha_MouseMove(object sender, MouseEventArgs e)
        {
            Bolinha bolinha = (Bolinha)sender;
            if (bolinha.Capture)
            {
                Point novaPosicao = new Point(bolinha.Left + e.X - ((Point)bolinha.Tag).X, bolinha.Top + e.Y - ((Point)bolinha.Tag).Y);
                bolinha.Location = novaPosicao;
            }
        }

        private void bolinha_MouseUp(object sender, MouseEventArgs e)
        {
            Bolinha bolinha = (Bolinha)sender;
            bolinha.Capture = false;
        }
    }
}