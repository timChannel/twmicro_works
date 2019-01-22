using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Pysslaformer
{
    public partial class MainForm : Form
    {
        int MatrixWidth = 100;
        int MatrixHeight = 100;
        bool redrawSystem = false;
        Color BackgroundColor = Color.Black;
        Color ForegroundColor = Color.White;
        List<GraphicsPath> First;
        List<GraphicsPath> Matrix = new List<GraphicsPath>();
        Image Current;
        bool Square = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SwitchSize_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? WindowState = FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void ToTray_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SetColors_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = colorDialog.Color;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    ForegroundColor = colorDialog.Color;
                }
            }
        }

        private void SetSize_Click(object sender, EventArgs e)
        {
            Current = pictureBox1.Image;
            MatrixWidth = (int)xDelta.Value * 10;
            MatrixHeight = (int)yDelta.Value * 10;
            GenerateMatrix();
        }

        private void GenerateMatrix()
        {
            int CircleSize = 10;
            int Circles = (MatrixWidth / CircleSize) * (MatrixHeight / CircleSize);
            int CirclesX = MatrixWidth / CircleSize;
            int CirclesY = MatrixHeight / CircleSize;
            int CurrentCol = 0;
            int CurrentRow = 0;
            Graphics g = Graphics.FromImage(Current);
            g.Clear(Color.White);
            if(Matrix.Count != 0)
                Matrix.RemoveRange(0, Matrix.Count - 1);
            for (int i = 0; i < Circles; i++)
            {
                if (i % CirclesX == 0 && i != 0) { CurrentCol++; CurrentRow = 0; }
                GraphicsPath path = new GraphicsPath();
                if(!Square)
                    path.AddEllipse(CurrentRow * CircleSize, CurrentCol * CircleSize, CircleSize, CircleSize);
                else
                    path.AddRectangle(new Rectangle(CurrentRow * CircleSize, CurrentCol * CircleSize, CircleSize, CircleSize));
                g.FillPath(new SolidBrush(BackgroundColor), path);
                Matrix.Add(path);
                CurrentRow++;
            }
            pictureBox1.Image = Current;
            First = Matrix;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Graphics g = Graphics.FromImage(Current);
                for (int i = 0; i < Matrix.Count; i++)
                {
                    if (Matrix[i].IsVisible(e.X, e.Y))
                    {
                        g.FillPath(new SolidBrush(ForegroundColor), Matrix[i]);
                        break;
                    }
                }
                pictureBox1.Image = Current;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ForegroundColor = dialog.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sd.Filter = "Images JPG (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                SaveImage(Path.GetFullPath(sd.FileName));
            }
        }
        private void SaveImage(string path)
        {
            pictureBox1.Image.Save(path);
        }

        private void square_Click(object sender, EventArgs e)
        {
            Square = true;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            Square = false;
        }

        private void max7219_Click(object sender, EventArgs e)
        {
            Current = pictureBox1.Image;
            BackgroundColor = Color.Black;
            ForegroundColor = Color.Red;
            MatrixWidth = 80;
            MatrixHeight = 80;
            GenerateMatrix();
        }

        private void codeto_Click(object sender, EventArgs e)
        {
            string code = "";
            for (int i = 0; i < Matrix.Count; i++)
            {
                int deltaY = i * 10 / MatrixWidth;
                int x = i * 10 - (deltaY * 80) + 5;
                int y = deltaY * 10 + 5;
                int col = (x - 5) / 10;
                int row = (y - 5) / 10;
                bool ControlValue = ((Bitmap)Current).GetPixel(x, y).ToArgb() == Color.Red.ToArgb();
                if (ControlValue) code += $"lc.setLed(0,{row},{col},true);\n";
            }
            Clipboard.SetText(code);
        }
    }
}
