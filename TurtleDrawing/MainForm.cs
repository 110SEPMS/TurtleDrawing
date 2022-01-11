using System;
using System.Drawing;
using System.Windows.Forms;
using TurtleDrawing.DataStructures;

namespace TurtleDrawing
{
    public partial class MainForm : Form
    {
        private Graphics _graphics;
        private Turtle _turtle;

        public MainForm()
        {
            InitializeComponent();
            _graphics = CreateGraphics();
            _turtle = new Turtle
            {
                Position = new PointF(500, 700),
                Angle = 0,
                Graphics = _graphics,
                Pen = new Pen(Color.Black, 2)
            };
        }

        private void DrawTree_Btn_Click(object sender, EventArgs e)
        {
            _graphics.Clear(BackColor);
            _turtle.Angle = 0;
            _turtle.Position = new Point(500, 750);
            _turtle.DrawTree(90, 250, 25, 8);
        }

        private void DrawFern_Btn_Click(object sender, EventArgs e)
        {
            _graphics.Clear(BackColor);
            _turtle.Angle = 90;
            _turtle.Position = new Point(500, 750);
        }

        private void DrawKochIsland_Btn_Click(object sender, EventArgs e)
        {
            _graphics.Clear(BackColor);
            _turtle.Angle = 0;
            _turtle.Position = new PointF(300.0f, 200.0f);
            int n = 4;

            _turtle.DrawKoch(360, n);
            _turtle.Turn(-120); _turtle.DrawKoch(360, n);
            _turtle.Turn(-120); _turtle.DrawKoch(360, n);
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            _graphics.Clear(BackColor);
        }
    }
}
