namespace Test_Modelacion_1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int x, y;
        private const int ancho = 50;
        private const int alto = 50;
        private int stepX = 5;
        private int stepY = 5;
        public Form1()
        {
            InitializeComponent();
            x = 10;
            y = 10;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50;
            timer.Tick += timer_Tick;
            Start.Text = "Start test";
            Start.Click += Start_Click;

            Stop.Text = "Stop test";
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            x += stepX;
            y += stepY;
            if (x + ancho > this.ClientSize.Width || x < 0)
            {
                stepX = -stepX;
            }
            else if (y + alto > this.ClientSize.Height || y < 0)
            {
                stepY = -stepY;
            }
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.LimeGreen, x, y, ancho, alto);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
