using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pysslaformer
{
    public partial class MainForm : Form
    {
        Bitmap Current;
        Color CurrentColor;
        Color BackColor;
        int Last;
        List<int> Actions = new List<int>();
        int WidthOfImage;
        int HeightOfImage;
        bool First = true;
        List<GraphicsPath> Matrix = new List<GraphicsPath>();
        public MainForm()
        {
            InitializeComponent();
            var menu = new MenuStrip();
            var item = new ToolStripMenuItem();
            item.ShortcutKeys = Keys.Control | Keys.Z;
            item.Click += MainForm_KeyDown;
            menu.Items.Add(item);
            menu.Visible = false;
            Controls.Add(menu);
        }

        private void setsize_button_Click(object sender, EventArgs e)
        {
            SizeDialog dialog = new SizeDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                WidthOfImage = Info.Width;
                HeightOfImage = Info.Height;
                Current = new Bitmap(WidthOfImage, HeightOfImage);
                pictureBox1.Image = Current;
                GeneratePysslaMatrix();
            }
        }
        void GeneratePysslaMatrix()
        {
            Graphics graphics = Graphics.FromImage(Current);
            int PysslaSize = 10;
            int NumberOfPyssla_H = WidthOfImage / PysslaSize;
            int NumberOfPyssla_V = HeightOfImage / PysslaSize;
            int NumberOfPyssla = NumberOfPyssla_H * NumberOfPyssla_V;
            int WidthPosition = 0;
            int HeightPosition = 0;
            for (int i = 0; i < NumberOfPyssla; i++)
            {
                if (i % NumberOfPyssla_H == 0) {
                    WidthPosition += 1;
                    HeightPosition = 0; }
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();
                path.AddEllipse(WidthPosition * PysslaSize, HeightPosition * PysslaSize, PysslaSize, PysslaSize);
                path.CloseFigure();
                graphics.FillPath(new SolidBrush(CurrentColor), path);
                Matrix.Add(path);
                HeightPosition += 1;
                UpdatePB();
            }
        }
        void UpdatePB()
        {
            pictureBox1.Image = Current;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c_dialog.AnyColor = true;
            if (c_dialog.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = c_dialog.Color;
                if(First) BackColor = c_dialog.Color;
                First = false;
            }
            label1.BackColor = CurrentColor;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics graphics = Graphics.FromImage(Current);
                int x = e.X;
                int y = e.Y;
                for (int i = 0; i < Matrix.Count;i++)
                {
                    if (Matrix[i].IsVisible(x, y)) { graphics.FillPath(new SolidBrush(CurrentColor), Matrix[i]); Actions.Add(i);  Last = Actions.Count - 1; break; }
                }
                UpdatePB();
            }
        }

        private void MainForm_KeyDown(object sender,EventArgs e)
        {
            Graphics graphics = Graphics.FromImage(Current);
            graphics.FillPath(new SolidBrush(BackColor), Matrix[Actions[Last]]);
            Last--;
            UpdatePB();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog myPrinDialog1 = new PrintDialog();
            myPrinDialog1.Document = myPrintDocument2;
            if (myPrinDialog1.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument2.Print();
            }
        }

        private void myPrintDocument2_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }
    }
}
