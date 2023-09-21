using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CampoTatico
{
    public class Bolinha : PictureBox
    {
        public Bolinha()
        {
            // Define as propriedades iniciais da bolinha
            Size = new Size(30, 30); // Define o tamanho da bolinha
            BackColor = Color.Black; // Define a cor de fundo da bolinha
            BorderStyle = BorderStyle.None; // Define o estilo da borda da bolinha
            SizeMode = PictureBoxSizeMode.StretchImage;

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(ClientRectangle); // Define a região elíptica com base no retângulo cliente do PictureBox
            Region = new Region(path);

            DoubleBuffered = true;
            // Outras propriedades e eventos podem ser adicionados de acordo com suas necessidades
        }
    }

}
