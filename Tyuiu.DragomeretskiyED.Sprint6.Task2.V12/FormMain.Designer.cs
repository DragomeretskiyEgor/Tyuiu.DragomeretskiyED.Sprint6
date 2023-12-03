
namespace Tyuiu.DragomeretskiyED.Sprint6.Task2.V12
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFunction_DED = new System.Windows.Forms.DataGridView();
            this.chartFunction_DED = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxInputStopStep_DED = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInputStartStep_DED = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStartCode_DED = new System.Windows.Forms.Button();
            this.buttonSpravka_DED = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DED)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат вывести в DataGrindView и построить график функции.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Протабулировать функцию sin(x) на заданном диапазоне.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridViewFunction_DED);
            this.groupBox2.Controls.Add(this.chartFunction_DED);
            this.groupBox2.Location = new System.Drawing.Point(732, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Результат:";
            // 
            // dataGridViewFunction_DED
            // 
            this.dataGridViewFunction_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_DED.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_DED.Location = new System.Drawing.Point(6, 41);
            this.dataGridViewFunction_DED.Name = "dataGridViewFunction_DED";
            this.dataGridViewFunction_DED.RowHeadersVisible = false;
            this.dataGridViewFunction_DED.Size = new System.Drawing.Size(116, 417);
            this.dataGridViewFunction_DED.TabIndex = 5;
            this.dataGridViewFunction_DED.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chartFunction_DED
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_DED.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_DED.Legends.Add(legend2);
            this.chartFunction_DED.Location = new System.Drawing.Point(150, 77);
            this.chartFunction_DED.Name = "chartFunction_DED";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_DED.Series.Add(series2);
            this.chartFunction_DED.Size = new System.Drawing.Size(384, 328);
            this.chartFunction_DED.TabIndex = 5;
            this.chartFunction_DED.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxInputStopStep_DED);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxInputStartStep_DED);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных";
            // 
            // textBoxInputStopStep_DED
            // 
            this.textBoxInputStopStep_DED.Location = new System.Drawing.Point(192, 32);
            this.textBoxInputStopStep_DED.Name = "textBoxInputStopStep_DED";
            this.textBoxInputStopStep_DED.Size = new System.Drawing.Size(172, 20);
            this.textBoxInputStopStep_DED.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Конец шага:";
            // 
            // textBoxInputStartStep_DED
            // 
            this.textBoxInputStartStep_DED.Location = new System.Drawing.Point(9, 32);
            this.textBoxInputStartStep_DED.Name = "textBoxInputStartStep_DED";
            this.textBoxInputStartStep_DED.Size = new System.Drawing.Size(165, 20);
            this.textBoxInputStartStep_DED.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Старт шага:";
            // 
            // buttonStartCode_DED
            // 
            this.buttonStartCode_DED.Location = new System.Drawing.Point(621, 401);
            this.buttonStartCode_DED.Name = "buttonStartCode_DED";
            this.buttonStartCode_DED.Size = new System.Drawing.Size(105, 75);
            this.buttonStartCode_DED.TabIndex = 3;
            this.buttonStartCode_DED.Text = "Выполнить";
            this.buttonStartCode_DED.UseVisualStyleBackColor = true;
            this.buttonStartCode_DED.Click += new System.EventHandler(this.buttonStartCode_DED_Click);
            // 
            // buttonSpravka_DED
            // 
            this.buttonSpravka_DED.Location = new System.Drawing.Point(480, 401);
            this.buttonSpravka_DED.Name = "buttonSpravka_DED";
            this.buttonSpravka_DED.Size = new System.Drawing.Size(104, 75);
            this.buttonSpravka_DED.TabIndex = 4;
            this.buttonSpravka_DED.Text = "Справка";
            this.buttonSpravka_DED.UseVisualStyleBackColor = true;
            this.buttonSpravka_DED.Click += new System.EventHandler(this.buttonSpravka_DED_Click);
            this.buttonSpravka_DED.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSpravka_DED_MouseDown);
            this.buttonSpravka_DED.MouseEnter += new System.EventHandler(this.buttonSpravka_DED_MouseEnter);
            this.buttonSpravka_DED.MouseLeave += new System.EventHandler(this.buttonSpravka_DED_MouseLeave);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.Name = "F";
            this.F.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 488);
            this.Controls.Add(this.buttonSpravka_DED);
            this.Controls.Add(this.buttonStartCode_DED);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Драгомерецкий Е.Д. ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_DED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DED)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFunction_DED;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DED;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonStartCode_DED;
        private System.Windows.Forms.Button buttonSpravka_DED;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputStopStep_DED;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInputStartStep_DED;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
    }
}

