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

namespace Pysslaformer
{
    public partial class MainForm : Form
    {
        int MatrixWidth = 100;
        int MatrixHeight = 100;
        Color BackgroundColor = Color.Black;
        Color ForegroundColor = Color.White;
        List<GraphicsPath> Matrix = new List<GraphicsPath>();
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
            int CurrentCol = 1;
            int CurrentRow = 1;
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            for (int i = 0; i < Circles; i++)
            {
                if (i % CirclesX == 0 && i != 1) { CurrentCol++; CurrentRow = 1; }
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(CurrentRow * CircleSize, CurrentCol * CircleSize, CircleSize, CircleSize);
                g.FillPath(new SolidBrush(BackgroundColor), path);
                Matrix.Add(path);
                CurrentRow++;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < Matrix.Count; i++)
                {
                    if (Matrix[i].IsVisible(e.X, e.Y))
                    {
                        g.FillPath(new SolidBrush(ForegroundColor), Matrix[i]);
                        break;
                    }
                }
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
    }
}
