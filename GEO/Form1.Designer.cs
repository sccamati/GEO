﻿
namespace GEO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.dBox = new System.Windows.Forms.TextBox();
            this.tauBox = new System.Windows.Forms.TextBox();
            this.Tbox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xbitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTest = new System.Windows.Forms.Panel();
            this.testStabilityButton = new System.Windows.Forms.Button();
            this.testChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.testTauBox = new System.Windows.Forms.TextBox();
            this.testTB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.testTBox = new System.Windows.Forms.TextBox();
            this.testTable = new System.Windows.Forms.DataGridView();
            this.tauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad1Button = new System.Windows.Forms.Button();
            this.startTestB = new System.Windows.Forms.Button();
            this.testB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.panelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(59, 21);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(23, 20);
            this.aBox.TabIndex = 0;
            this.aBox.Text = "-4";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(107, 22);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(21, 20);
            this.bBox.TabIndex = 1;
            this.bBox.Text = "12";
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(167, 22);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(72, 20);
            this.dBox.TabIndex = 2;
            this.dBox.Text = "0,001";
            this.dBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dBox_KeyPress);
            // 
            // tauBox
            // 
            this.tauBox.Location = new System.Drawing.Point(284, 22);
            this.tauBox.Name = "tauBox";
            this.tauBox.Size = new System.Drawing.Size(100, 20);
            this.tauBox.TabIndex = 3;
            this.tauBox.Text = "2,2";
            this.tauBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tauBox_KeyPress);
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(425, 22);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(100, 20);
            this.Tbox.TabIndex = 4;
            this.Tbox.Text = "3800";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(568, 15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "d";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tau";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "T";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoGenerateColumns = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.xrealDataGridViewTextBoxColumn,
            this.xintDataGridViewTextBoxColumn,
            this.xbitDataGridViewTextBoxColumn,
            this.fxDataGridViewTextBoxColumn});
            this.table.DataSource = this.individualBindingSource;
            this.table.Location = new System.Drawing.Point(28, 65);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(563, 52);
            this.table.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xrealDataGridViewTextBoxColumn
            // 
            this.xrealDataGridViewTextBoxColumn.DataPropertyName = "Xreal";
            this.xrealDataGridViewTextBoxColumn.HeaderText = "Xreal";
            this.xrealDataGridViewTextBoxColumn.Name = "xrealDataGridViewTextBoxColumn";
            this.xrealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xintDataGridViewTextBoxColumn
            // 
            this.xintDataGridViewTextBoxColumn.DataPropertyName = "Xint";
            this.xintDataGridViewTextBoxColumn.HeaderText = "Xint";
            this.xintDataGridViewTextBoxColumn.Name = "xintDataGridViewTextBoxColumn";
            this.xintDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xbitDataGridViewTextBoxColumn
            // 
            this.xbitDataGridViewTextBoxColumn.DataPropertyName = "Xbit";
            this.xbitDataGridViewTextBoxColumn.HeaderText = "Xbit";
            this.xbitDataGridViewTextBoxColumn.Name = "xbitDataGridViewTextBoxColumn";
            this.xbitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fxDataGridViewTextBoxColumn
            // 
            this.fxDataGridViewTextBoxColumn.DataPropertyName = "Fx";
            this.fxDataGridViewTextBoxColumn.HeaderText = "Fx";
            this.fxDataGridViewTextBoxColumn.Name = "fxDataGridViewTextBoxColumn";
            this.fxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // individualBindingSource
            // 
            this.individualBindingSource.DataSource = typeof(GEO.classes.Individual);
            // 
            // chart
            // 
            this.chart.CausesValidation = false;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(28, 130);
            this.chart.Margin = new System.Windows.Forms.Padding(1);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1186, 528);
            this.chart.SuppressExceptions = true;
            this.chart.TabIndex = 12;
            this.chart.Text = "chart1";
            // 
            // panelTest
            // 
            this.panelTest.Controls.Add(this.testStabilityButton);
            this.panelTest.Controls.Add(this.testChart);
            this.panelTest.Controls.Add(this.label7);
            this.panelTest.Controls.Add(this.testTauBox);
            this.panelTest.Controls.Add(this.testTB);
            this.panelTest.Controls.Add(this.label6);
            this.panelTest.Controls.Add(this.testTBox);
            this.panelTest.Controls.Add(this.testTable);
            this.panelTest.Controls.Add(this.zad1Button);
            this.panelTest.Controls.Add(this.startTestB);
            this.panelTest.Location = new System.Drawing.Point(3, 3);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(1211, 664);
            this.panelTest.TabIndex = 13;
            // 
            // testStabilityButton
            // 
            this.testStabilityButton.Location = new System.Drawing.Point(782, 12);
            this.testStabilityButton.Name = "testStabilityButton";
            this.testStabilityButton.Size = new System.Drawing.Size(184, 20);
            this.testStabilityButton.TabIndex = 9;
            this.testStabilityButton.Text = "sprawdz stabilnosc";
            this.testStabilityButton.UseVisualStyleBackColor = true;
            this.testStabilityButton.Click += new System.EventHandler(this.testStabilityButton_Click);
            // 
            // testChart
            // 
            chartArea2.Name = "ChartArea1";
            this.testChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.testChart.Legends.Add(legend2);
            this.testChart.Location = new System.Drawing.Point(413, 56);
            this.testChart.Name = "testChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.testChart.Series.Add(series2);
            this.testChart.Size = new System.Drawing.Size(789, 599);
            this.testChart.TabIndex = 8;
            this.testChart.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "test tau";
            // 
            // testTauBox
            // 
            this.testTauBox.Location = new System.Drawing.Point(60, 35);
            this.testTauBox.Name = "testTauBox";
            this.testTauBox.Size = new System.Drawing.Size(100, 20);
            this.testTauBox.TabIndex = 6;
            // 
            // testTB
            // 
            this.testTB.Location = new System.Drawing.Point(360, 8);
            this.testTB.Name = "testTB";
            this.testTB.Size = new System.Drawing.Size(143, 23);
            this.testTB.TabIndex = 5;
            this.testTB.Text = "szukanie najlepszego T";
            this.testTB.UseVisualStyleBackColor = true;
            this.testTB.Click += new System.EventHandler(this.testTB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "testT";
            // 
            // testTBox
            // 
            this.testTBox.Location = new System.Drawing.Point(60, 7);
            this.testTBox.Name = "testTBox";
            this.testTBox.Size = new System.Drawing.Size(100, 20);
            this.testTBox.TabIndex = 3;
            // 
            // testTable
            // 
            this.testTable.AllowUserToAddRows = false;
            this.testTable.AllowUserToDeleteRows = false;
            this.testTable.AutoGenerateColumns = false;
            this.testTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tauDataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.fxDataGridViewTextBoxColumn1});
            this.testTable.DataSource = this.generationBindingSource;
            this.testTable.Location = new System.Drawing.Point(30, 65);
            this.testTable.Name = "testTable";
            this.testTable.ReadOnly = true;
            this.testTable.Size = new System.Drawing.Size(377, 557);
            this.testTable.TabIndex = 2;
            // 
            // tauDataGridViewTextBoxColumn
            // 
            this.tauDataGridViewTextBoxColumn.DataPropertyName = "Tau";
            this.tauDataGridViewTextBoxColumn.HeaderText = "Tau";
            this.tauDataGridViewTextBoxColumn.Name = "tauDataGridViewTextBoxColumn";
            this.tauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "T";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fxDataGridViewTextBoxColumn1
            // 
            this.fxDataGridViewTextBoxColumn1.DataPropertyName = "Fx";
            this.fxDataGridViewTextBoxColumn1.HeaderText = "f(Vbest) avg";
            this.fxDataGridViewTextBoxColumn1.Name = "fxDataGridViewTextBoxColumn1";
            this.fxDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // generationBindingSource
            // 
            this.generationBindingSource.DataSource = typeof(GEO.classes.Generation);
            // 
            // zad1Button
            // 
            this.zad1Button.Location = new System.Drawing.Point(556, 8);
            this.zad1Button.Name = "zad1Button";
            this.zad1Button.Size = new System.Drawing.Size(75, 23);
            this.zad1Button.TabIndex = 1;
            this.zad1Button.Text = "zad1";
            this.zad1Button.UseVisualStyleBackColor = true;
            this.zad1Button.Click += new System.EventHandler(this.zad1Button_Click);
            // 
            // startTestB
            // 
            this.startTestB.Location = new System.Drawing.Point(176, 8);
            this.startTestB.Name = "startTestB";
            this.startTestB.Size = new System.Drawing.Size(162, 27);
            this.startTestB.TabIndex = 0;
            this.startTestB.Text = "szukanie najlepszego tau";
            this.startTestB.UseVisualStyleBackColor = true;
            this.startTestB.Click += new System.EventHandler(this.startTestB_Click);
            // 
            // testB
            // 
            this.testB.Location = new System.Drawing.Point(662, 12);
            this.testB.Name = "testB";
            this.testB.Size = new System.Drawing.Size(75, 23);
            this.testB.TabIndex = 14;
            this.testB.Text = "testy";
            this.testB.UseVisualStyleBackColor = true;
            this.testB.Click += new System.EventHandler(this.testB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 679);
            this.Controls.Add(this.testB);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Tbox);
            this.Controls.Add(this.tauBox);
            this.Controls.Add(this.dBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.individualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.TextBox tauBox;
        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource individualBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Button zad1Button;
        private System.Windows.Forms.Button startTestB;
        private System.Windows.Forms.BindingSource generationBindingSource;
        private System.Windows.Forms.Button testB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox testTBox;
        private System.Windows.Forms.DataGridView testTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn tauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox testTauBox;
        private System.Windows.Forms.Button testTB;
        private System.Windows.Forms.DataVisualization.Charting.Chart testChart;
        private System.Windows.Forms.Button testStabilityButton;
    }
}

