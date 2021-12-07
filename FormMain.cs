using org.mariuszgromada.math.mxparser;

namespace WindowsFormsApplication1
{
    using System;
    using System.Windows.Forms;

    using OxyPlot;
    using OxyPlot.Series;

    public partial class FormMain : Form
    {
        private PlotModel model;

        private delegate double FUNC(double x);

        public FormMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Oblicza calke metoda Simpsona w przedziale od xp do xk z dokladnoscia n dla funkcji fun
        /// </summary>
        /// <param name="xp">poczatek przedzialu calkowania</param>
        /// <param name="xk">koniec przedzialu calkowania</param>
        /// <param name="n">dokladnosc calkowania</param>
        /// <param name="func">funkcja calkowana</param>
        /// <returns>przyblizona wartosc calki</returns>
        /// 
        private static double calculate(double xp, double xk, int n, FUNC func)
        {
            double dx, calka, s, x;

            dx = (xk - xp) / (double)n;

            calka = 0;
            s = 0;
            for (int i = 1; i < n; i++)
            {
                x = xp + i * dx;
                s += func(x - dx / 2);
                calka += func(x);
            }
            s += func(xk - dx / 2);
            calka = (dx / 6) * (func(xp) + func(xk) + 2 * calka + 4 * s);

            return calka;
        }

        private double func(double x)
        {
            Argument a = new Argument("x");
            a.setArgumentValue(x);
            Expression f = new Expression(textBoxFunctionCalc.Text,a);
            Console.WriteLine(f.calculate());
            return f.calculate();
        }

        public FunctionSeries GetFunction()
        {
            int n = 30;
            FunctionSeries series = new FunctionSeries();
            for (int x = -30; x < n; x++)
            {
                for (int y = -30; y < n; y++)
                {
                    DataPoint data = new DataPoint(x, func(x));
                    series.Points.Add(data);
                }
            }
            return series;
        }

        private void graph()
        {
            var function = "Funckja:" + textBoxFunctionCalc.Text;
            model = new PlotModel { Title = function };

            model.LegendPosition = LegendPosition.RightBottom;
            model.LegendPlacement = LegendPlacement.Outside;
            model.LegendOrientation = LegendOrientation.Horizontal;

            model.Series.Add(GetFunction());
            var Yaxis = new OxyPlot.Axes.LinearAxis();
            OxyPlot.Axes.LinearAxis XAxis = new OxyPlot.Axes.LinearAxis { Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -30, Maximum = 30 };
            XAxis.Title = "x";
            Yaxis.Title = "y=" + textBoxFunctionCalc.Text;
            model.Axes.Add(Yaxis);
            model.Axes.Add(XAxis);
            this.plot1.Model = model;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = calculate(double.Parse(textBoxBeginningCalc.Text), double.Parse(textBoxEndCalc.Text),
                int.Parse(textBoxAccuracyCalc.Text), new FUNC(func)).ToString();
            graph();
        }
    }
}