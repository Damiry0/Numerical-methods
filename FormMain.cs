using System;
using System.Globalization;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using OxyPlot;
using OxyPlot.Series;

namespace Simpson_Rule
{
    public partial class FormMain : Form
    {
        private PlotModel _model;

        private delegate double Func(double x);

        public FormMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Oblicza calke metoda Simpsona w przedziale od xp do xk z dokladnoscia n dla funkcji func
        /// </summary>
        /// <param name="xp">poczatek przedzialu calkowania</param>
        /// <param name="xk">koniec przedzialu calkowania</param>
        /// <param name="n">dokladnosc calkowania</param>
        /// <param name="func">funkcja calkowana</param>
        /// <returns>przyblizona wartosc calki</returns>
        /// 
        private static double Calculate(double xp, double xk, int n, Func func)
        {
            double dx, calka, s, x;

            dx = (xk - xp) / (double)n;

            calka = 0;
            s = 0;
            for (var i = 1; i < n; i++)
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
            var n = 30;
            FunctionSeries series = new FunctionSeries();
            for (var x = -30; x < n; x++)
            {
                for (var y = -30; y < n; y++)
                {
                    DataPoint data = new DataPoint(x, func(x));
                    series.Points.Add(data);
                }
            }
            return series;
        }

        private void graph()
        {
            var function = "Funkcja:" + textBoxFunctionCalc.Text;
            _model = new PlotModel
            {
                Title = function,
                LegendPosition = LegendPosition.RightBottom,
                LegendPlacement = LegendPlacement.Outside,
                LegendOrientation = LegendOrientation.Horizontal
            };


            _model.Series.Add(GetFunction());
            var yAxis = new OxyPlot.Axes.LinearAxis();
            OxyPlot.Axes.LinearAxis xAxis = new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom, Minimum = -30, Maximum = 30, Title = "x"
            };
            yAxis.Title = "y=" + textBoxFunctionCalc.Text;
            _model.Axes.Add(yAxis);
            _model.Axes.Add(xAxis);
            this.plot1.Model = _model;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Calculate(double.Parse(textBoxBeginningCalc.Text), double.Parse(textBoxEndCalc.Text),
                int.Parse(textBoxAccuracyCalc.Text), new Func(func)).ToString(CultureInfo.CurrentCulture);
            graph();
        }
    }
}