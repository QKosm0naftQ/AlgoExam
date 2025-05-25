namespace WinFormProject
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lb_inputUserMaxNum = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.cb_BubbleSort = new System.Windows.Forms.CheckBox();
            this.cb_InsertionSort = new System.Windows.Forms.CheckBox();
            this.cb_QuickSort = new System.Windows.Forms.CheckBox();
            this.cb_SelectionSort = new System.Windows.Forms.CheckBox();
            this.chart_result = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mbt_inputUserMaxNum = new System.Windows.Forms.MaskedTextBox();
            this.cb_styleChart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_inputUserMaxNum
            // 
            this.lb_inputUserMaxNum.AutoSize = true;
            this.lb_inputUserMaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_inputUserMaxNum.Location = new System.Drawing.Point(12, 9);
            this.lb_inputUserMaxNum.Name = "lb_inputUserMaxNum";
            this.lb_inputUserMaxNum.Size = new System.Drawing.Size(171, 25);
            this.lb_inputUserMaxNum.TabIndex = 1;
            this.lb_inputUserMaxNum.Text = "Enter max number";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_start.Location = new System.Drawing.Point(17, 126);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(704, 40);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // cb_BubbleSort
            // 
            this.cb_BubbleSort.AutoSize = true;
            this.cb_BubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_BubbleSort.Location = new System.Drawing.Point(152, 50);
            this.cb_BubbleSort.Name = "cb_BubbleSort";
            this.cb_BubbleSort.Size = new System.Drawing.Size(132, 29);
            this.cb_BubbleSort.TabIndex = 3;
            this.cb_BubbleSort.Text = "Bubble sort";
            this.cb_BubbleSort.UseVisualStyleBackColor = true;
            // 
            // cb_InsertionSort
            // 
            this.cb_InsertionSort.AutoSize = true;
            this.cb_InsertionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_InsertionSort.Location = new System.Drawing.Point(290, 50);
            this.cb_InsertionSort.Name = "cb_InsertionSort";
            this.cb_InsertionSort.Size = new System.Drawing.Size(145, 29);
            this.cb_InsertionSort.TabIndex = 4;
            this.cb_InsertionSort.Text = "Insertion sort";
            this.cb_InsertionSort.UseVisualStyleBackColor = true;
            // 
            // cb_QuickSort
            // 
            this.cb_QuickSort.AutoSize = true;
            this.cb_QuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_QuickSort.Location = new System.Drawing.Point(441, 51);
            this.cb_QuickSort.Name = "cb_QuickSort";
            this.cb_QuickSort.Size = new System.Drawing.Size(122, 29);
            this.cb_QuickSort.TabIndex = 5;
            this.cb_QuickSort.Text = "Quick sort";
            this.cb_QuickSort.UseVisualStyleBackColor = true;
            // 
            // cb_SelectionSort
            // 
            this.cb_SelectionSort.AutoSize = true;
            this.cb_SelectionSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_SelectionSort.Location = new System.Drawing.Point(569, 51);
            this.cb_SelectionSort.Name = "cb_SelectionSort";
            this.cb_SelectionSort.Size = new System.Drawing.Size(152, 29);
            this.cb_SelectionSort.TabIndex = 6;
            this.cb_SelectionSort.Text = "Selection sort";
            this.cb_SelectionSort.UseVisualStyleBackColor = true;
            // 
            // chart_result
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_result.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_result.Legends.Add(legend2);
            this.chart_result.Location = new System.Drawing.Point(12, 172);
            this.chart_result.Name = "chart_result";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_result.Series.Add(series2);
            this.chart_result.Size = new System.Drawing.Size(739, 396);
            this.chart_result.TabIndex = 7;
            this.chart_result.Text = "Chart";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(757, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 396);
            this.dataGridView1.TabIndex = 8;
            // 
            // mbt_inputUserMaxNum
            // 
            this.mbt_inputUserMaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mbt_inputUserMaxNum.Location = new System.Drawing.Point(17, 51);
            this.mbt_inputUserMaxNum.Mask = "000000";
            this.mbt_inputUserMaxNum.Name = "mbt_inputUserMaxNum";
            this.mbt_inputUserMaxNum.Size = new System.Drawing.Size(118, 30);
            this.mbt_inputUserMaxNum.TabIndex = 9;
            this.mbt_inputUserMaxNum.ValidatingType = typeof(int);
            // 
            // cb_styleChart
            // 
            this.cb_styleChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_styleChart.FormattingEnabled = true;
            this.cb_styleChart.Location = new System.Drawing.Point(17, 87);
            this.cb_styleChart.Name = "cb_styleChart";
            this.cb_styleChart.Size = new System.Drawing.Size(169, 33);
            this.cb_styleChart.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 580);
            this.Controls.Add(this.cb_styleChart);
            this.Controls.Add(this.mbt_inputUserMaxNum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart_result);
            this.Controls.Add(this.cb_SelectionSort);
            this.Controls.Add(this.cb_QuickSort);
            this.Controls.Add(this.cb_InsertionSort);
            this.Controls.Add(this.cb_BubbleSort);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.lb_inputUserMaxNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_inputUserMaxNum;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.CheckBox cb_BubbleSort;
        private System.Windows.Forms.CheckBox cb_InsertionSort;
        private System.Windows.Forms.CheckBox cb_QuickSort;
        private System.Windows.Forms.CheckBox cb_SelectionSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_result;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mbt_inputUserMaxNum;
        private System.Windows.Forms.ComboBox cb_styleChart;
    }
}

