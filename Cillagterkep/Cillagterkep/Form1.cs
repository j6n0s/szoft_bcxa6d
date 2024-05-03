namespace Cillagterkep
{
    public partial class Form1 : Form
    {
        Models.HajosContext context = new Models.HajosContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var star = (from s in context.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            Color c = Color.White;
            Pen toll = new Pen(c, 1);
            Brush brush = new SolidBrush(c);

            double nagyítás = 250;
            int cx = ClientRectangle.Width / 2;
            int cy = ClientRectangle.Height / 2;
            foreach (var s in star)
            {
                if (s.Magnitude > 6) continue;
                if (Math.Sqrt(Math.Pow(s.X, 2) + Math.Pow(s.Y, 2)) > 2) continue;

                float x = (float)(s.X * nagyítás + cx);
                float y = (float)(s.Y * nagyítás + cy);
                float size = (float)(20 * Math.Pow(10, s.Magnitude / -2.5));

                g.FillEllipse(brush, x, y, size, size);
                //g.DrawLine(toll, 10, 10, 10, 10);
            }

            var limes = context.ConstellationLines.ToList();
            Color r = Color.Red;
            Pen pen = new Pen(r, 1);
            foreach (var l in limes)
            {
                var star1 = (from x in star
                            where x.Hip == l.Star1
                            select x).FirstOrDefault();
                var star2 = (from x in star
                             where x.Hip == l.Star2
                             select x).FirstOrDefault();

                if(star1 == null || star2 == null) continue;

                float x1 = (float)(star1.X * nagyítás + cx);
                float y1 = (float)(star1.Y * nagyítás + cy);

                float x2 = (float)(star2.X * nagyítás + cx);
                float y2 = (float)(star2.Y * nagyítás + cy);

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }
    }
}