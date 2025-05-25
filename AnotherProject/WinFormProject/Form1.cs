using ClassLibrary1Test.Service;
using LibraryModel.Algorithm;
using LibraryModel.Interface;
using LibraryModel.Service;
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
namespace WinFormProject
{
    public partial class Form1 : Form
    {
        private List<SortResult> results;
        private FormService formService;
        public Form1()
        {
            InitializeComponent();
            results = new List<SortResult>();
            this.cb_styleChart.Items.Add("Лінійний");
            this.cb_styleChart.Items.Add("Стовпчиковий");
            this.cb_styleChart.Items.Add("Точковий");
            this.cb_styleChart.Items.Add("Гістограма");
        }
        private async void bt_start_Click(object sender, EventArgs e)
        {
            int userMaxNum;
            if (int.TryParse(mbt_inputUserMaxNum.Text, out userMaxNum) && userMaxNum >= 3 && userMaxNum <= 1000)
            {
                formService = new FormService();
                if (this.cb_BubbleSort.Checked)
                    formService.AddTypeSort(new Bubble_sort());
                if (this.cb_SelectionSort.Checked)
                    formService.AddTypeSort(new Selection_sort());
                if (this.cb_InsertionSort.Checked)
                    formService.AddTypeSort(new Insertion_sort());
                if (this.cb_QuickSort.Checked)
                    formService.AddTypeSort(new Quick_sort());
                if(this.cb_styleChart.SelectedItem == null)
                {
                    MessageBox.Show("Please select a chart style.", "No Chart Style Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                formService.GenerateRandomArray(userMaxNum, 1000);
                await formService.SortAsync();
                UpdateChart();
                this.dataGridView1.DataSource = formService.GetListSortResult();
            }
            else
            {
                MessageBox.Show("Please enter a number between 3 and 1000.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void UpdateChart()
        {
            results = formService.GetListSortResult();
            chart_result.Series.Clear();
            Series series = new Series("Операції");

            switch (this.cb_styleChart.SelectedItem?.ToString())
            {
                case "Лінійний":
                    series.ChartType = SeriesChartType.Line;
                    break;
                case "Стовпчиковий":
                    series.ChartType = SeriesChartType.Column;
                    break;
                case "Точковий":
                    series.ChartType = SeriesChartType.Point;
                    break;
                case "Гістограма":
                    series.ChartType = SeriesChartType.Bar;
                    break;
                default:
                    series.ChartType = SeriesChartType.Line;
                    break;
            }

            foreach (var result in results)
            {
                series.Points.AddXY(result.AlgorithmName, result.OperationCount);
            }
            chart_result.Series.Add(series);
            chart_result.ResetAutoValues();

        }
    }
}
