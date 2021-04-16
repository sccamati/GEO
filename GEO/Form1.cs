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
            testChart.MouseWheel += chart_MouseWheel;
            panelTest.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            double tau = Convert.ToDouble(tauBox.Text);
            int T = Convert.ToInt32(Tbox.Text);
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
            List<Individual> ListVb = new List<Individual>();
            Individual Vbest;

            Individual individual = Geo.MakeFirstInd(a, b, d, l, generator);
            Vbest = individual.Clone();
            ListVb.Add(individual.Clone());

            for (int i = 1; i < T; i++)
            {
                individuals = Geo.MakePopulation(individual, a, b, l, round);

                Geo.CountProbability(individuals, tau);

                Geo.MutateInd(individual, individuals, a, b, l, round, generator);

                if (Vbest.Fx < individual.Fx)
                {
                    Vbest = individual.Clone();
                }

                ListVb.Add(individual.Clone());
                individuals.Clear();
            }

            individuals.Add(Vbest);
            var bindingList = new BindingList<Individual>(individuals);
            var source = new BindingSource(bindingList, null);
            table.DataSource = source;

            ToTxt.WriteToFile(ListVb, T, tau, d);
            MakeChart(ListVb, Vbest);
        }

        private void MakeChart(List<Individual> genList, Individual Vbest)
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
                chart.Series["Vb"].Points.AddXY(i, genList[i].Fx);
                if (genList[i].Fx == Vbest.Fx)
                {
                    chart.Series["Best"].Points.AddXY(i, Vbest.Fx);
                }
            }


        }

        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;

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

        private void startTestB_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            double T = Convert.ToDouble(testTBox.Text);

            Random generator = new Random();
            int round = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));


            List<Individual> VbestList = new List<Individual>();
            List<Generation> genList = new List<Generation>();
            List<Individual> individuals = null;
            Individual Vbest;
            double pom = d;

            while (pom < 1)
            {
                round++;
                pom *= 10;
            }

            double tau = 0;

            for (int k = 0; k < 50; k++)
            {
                tau += 0.1;
                tau = Math.Round(tau, 2);

                for (int j = 0; j < 100; j++)
                {

                    Individual individual = Geo.MakeFirstInd(a, b, d, l, generator);
                    Vbest = individual.Clone();

                    for (int i = 0; i < T; i++)
                    {
                        individuals = Geo.MakePopulation(individual, a, b, l, round);

                        Geo.CountProbability(individuals, tau);

                        Geo.MutateInd(individual, individuals, a, b, l, round, generator);

                        if (Vbest.Fx < individual.Fx)
                        {
                            Vbest = individual.Clone();
                        }

                        individuals.Clear();
                    }

                    VbestList.Add(Vbest.Clone());
                }

                Generation gen = new Generation
                {
                    T = T,
                    Tau = tau,
                    Fx = VbestList.Average(ind => ind.Fx)
                };

                genList.Add(gen);
                VbestList.Clear();
            }

            genList.Sort(delegate (Generation x, Generation y)
            {
                return y.Fx.CompareTo(x.Fx);
            });
            var bindingList = new BindingList<Generation>(genList);
            var source = new BindingSource(bindingList, null);
            testTable.DataSource = source;
        }

        private void zad1Button_Click(object sender, EventArgs e)
        {
            panelTest.Visible = false;
            testB.Visible = true;
        }

        private void testB_Click(object sender, EventArgs e)
        {
            panelTest.Visible = true;
            testB.Visible = false;
        }

        private void dBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void tauBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void testTB_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            double tau = Convert.ToDouble(testTauBox.Text);
            Random generator = new Random();
            int round = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));


            List<Individual> VbestList = new List<Individual>();
            List<Generation> genList = new List<Generation>();
            List<Individual> individuals = null;
            Individual Vbest;
            double pom = d;

            while (pom < 1)
            {
                round++;
                pom *= 10;
            }

            int T = 5100;

            for (int k = 0; k < 50; k++)
            {
                T -= 100;

                for (int j = 0; j < 100; j++)
                {

                    Individual individual = Geo.MakeFirstInd(a, b, d, l, generator);
                    Vbest = individual.Clone();

                    for (int i = 0; i < T; i++)
                    {
                        individuals = Geo.MakePopulation(individual, a, b, l, round);

                        Geo.CountProbability(individuals, tau);

                        Geo.MutateInd(individual, individuals, a, b, l, round, generator);

                        if (Vbest.Fx < individual.Fx)
                        {
                            Vbest = individual.Clone();
                        }

                        individuals.Clear();
                    }

                    VbestList.Add(Vbest.Clone());
                }

                Generation gen = new Generation
                {
                    T = T,
                    Tau = tau,
                    Fx = VbestList.Average(ind => ind.Fx)
                };

                genList.Add(gen);
                VbestList.Clear();
            }

            genList.Sort(delegate (Generation x, Generation y)
            {
                return y.Fx.CompareTo(x.Fx);
            });
            var bindingList = new BindingList<Generation>(genList);
            var source = new BindingSource(bindingList, null);
            testTable.DataSource = source;
        }

        private void testStabilityButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aBox.Text);
            double b = Convert.ToDouble(bBox.Text);
            double d = Convert.ToDouble(dBox.Text);
            double T = Convert.ToDouble(testTBox.Text);
            double tau = Convert.ToDouble(testTauBox.Text);
            Random generator = new Random();
            int round = 0;
            int l = (int)Math.Ceiling(Math.Log(((b - a) * (1 / d)) + 1, 2));


            List<Individual> VbestList = new List<Individual>();
            List<Generation> genList = new List<Generation>();
            List<Individual> individuals = null;
            Individual Vbest;
            double pom = d;

            while (pom < 1)
            {
                round++;
                pom *= 10;
            }

            for (int j = 0; j < 100; j++)
            {

                Individual individual = Geo.MakeFirstInd(a, b, d, l, generator);
                Vbest = individual.Clone();

                for (int i = 0; i < T; i++)
                {
                    individuals = Geo.MakePopulation(individual, a, b, l, round);

                    Geo.CountProbability(individuals, tau);

                    Geo.MutateInd(individual, individuals, a, b, l, round, generator);

                    if (Vbest.Fx < individual.Fx)
                    {
                        Vbest = individual.Clone();
                    }

                    individuals.Clear();
                }

                VbestList.Add(Vbest.Clone());
            }


            var chartMaker = testChart.ChartAreas[0];
            ChartArea CA = testChart.ChartAreas[0];
            CA.AxisX.ScaleView.Zoomable = true;
            chartMaker.AxisX.LabelStyle.Format = "";
            chartMaker.AxisY.LabelStyle.Format = "";
            chartMaker.AxisX.LabelStyle.IsEndLabelVisible = true;
            chartMaker.AxisY.Minimum = 1.5;
            chartMaker.AxisX.Minimum = 0;
            chartMaker.AxisX.Maximum = VbestList.Count;
            chartMaker.AxisY.Interval = 0.1;
            chartMaker.AxisX.Interval = 2;

            testChart.Series[0].IsVisibleInLegend = false;

            if (testChart.Series.Count == 1)
            {
                testChart.Series.Add("Vb");
            }
            else
            {
                testChart.Series["Vb"].Points.Clear();
            }

            testChart.Series["Vb"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            testChart.Series["Vb"].Color = Color.Green;
            testChart.Series["Vb"].BorderWidth = 1;

            for (int i = 0; i < VbestList.Count; i++)
            {
                testChart.Series["Vb"].Points.AddXY(i, VbestList[i].Fx);
            }


        }

    }
}

