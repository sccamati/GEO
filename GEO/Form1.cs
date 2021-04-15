using GEO.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GEO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart.MouseWheel += chart_MouseWheel;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            double tau = Convert.ToDouble(tauBox.Text);
            double T = Convert.ToDouble(Tbox.Text);
            Random generator = new Random();
            int round = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));

            double pom = d;
            while (pom < 1)
            {
                round++;
                pom *= 10;
            }

            List<Individual> individuals = null;
            List<double> ListVb = new List<double>();
            Individual Vbest;

            Individual individual = Geo.MakeFirstInd(a, b, d, l, generator);
            Vbest = individual.Clone();
            ListVb.Add(individual.Fx);

            for (int i = 0; i < T; i++)
            {
                individuals = Geo.MakePopulation(individual, a, b, l, round);

                Geo.CountProbability(individuals, tau);

                Geo.MutateInd(individual, individuals, a, b, l, round, generator);

                if(Vbest.Fx < individual.Fx)
                {
                    Vbest = individual.Clone();
                }

                ListVb.Add(individual.Fx);
                individuals.Clear();
            }

            individuals.Add(Vbest);
            var bindingList = new BindingList<Individual>(individuals);
            var source = new BindingSource(bindingList, null);
            table.DataSource = source;

            MakeChart(ListVb, Vbest);
        }

        private void MakeChart(List<double> genList, Individual Vbest)
        {
            var chartMaker = chart.ChartAreas[0];
            ChartArea CA = chart.ChartAreas[0];


            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = genList.Count;
            chartMaker.AxisY.Interval = 0.1;
            if (genList.Count > 1999)
            {
                chartMaker.AxisX.Interval = 200;
            }
            if (genList.Count > 999)
            {
                chartMaker.AxisX.Interval = 100;
            }
            else if (genList.Count > 500)
            {
                chartMaker.AxisX.Interval = 50;
            }
            else if (genList.Count > 100)
            {
                chartMaker.AxisX.Interval = 10;
            }
            else if (genList.Count > 99)
            {
                chartMaker.AxisX.Interval = 4;
            }
            else if (genList.Count > 40)
            {
                chartMaker.AxisX.Interval = 2;
            }

            chart.Series[0].IsVisibleInLegend = false;

            if (chart.Series.Count == 1)
            {
                chart.Series.Add("Vb");
                chart.Series.Add("Best");
            }
            else
            {
                chart.Series["Vb"].Points.Clear();
                chart.Series["Best"].Points.Clear();
            }

            chart.Series["Vb"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series["Vb"].Color = Color.Green;
            chart.Series["Vb"].BorderWidth = 1;

            chart.Series["Best"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart.Series["Best"].Color = Color.Red;
            chart.Series["Best"].BorderWidth = 3;

            for (int i = 0; i < genList.Count; i++)
            {
                chart.Series["Vb"].Points.AddXY(i, genList[i]);
                if(genList[i] == Vbest.Fx)
                {
                    chart.Series["Best"].Points.AddXY(i, Vbest.Fx);
                }
            }


        }

        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();

                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;


                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;


                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                }
            }
            catch { }
        }
    }
}
