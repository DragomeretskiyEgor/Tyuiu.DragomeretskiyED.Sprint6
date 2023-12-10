
namespace Tyuiu.DragomeretskiyED.Sprint6.Task4.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartFunction_DED = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxStart_DED = new System.Windows.Forms.TextBox();
            this.textBoxStop_DED = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSpravka_DED = new System.Windows.Forms.Button();
            this.buttonSave_DED = new System.Windows.Forms.Button();
            this.buttonToDo_DED = new System.Windows.Forms.Button();
            this.textBoxResult_DED = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DED)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // chartFunction_DED
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_DED.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_DED.Legends.Add(legend1);
            this.chartFunction_DED.Location = new System.Drawing.Point(224, 76);
            this.chartFunction_DED.Name = "chartFunction_DED";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_DED.Series.Add(series1);
            this.chartFunction_DED.Size = new System.Drawing.Size(711, 409);
            this.chartFunction_DED.TabIndex = 2;
            this.chartFunction_DED.Text = "chartFunction";
            title1.Name = "TitleSin";
            title1.Text = "График функции sin(x)";
            this.chartFunction_DED.Titles.Add(title1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5. Результат вывест" +
    "и в textBox, построить график функции и сохранить в файл OutPutFileTask.txt по н" +
    "ажатию кнопки. ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonToDo_DED);
            this.groupBox3.Controls.Add(this.buttonSave_DED);
            this.groupBox3.Controls.Add(this.buttonSpravka_DED);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxStop_DED);
            this.groupBox3.Controls.Add(this.textBoxStart_DED);
            this.groupBox3.Location = new System.Drawing.Point(430, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 68);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ввод данных:";
            // 
            // textBoxStart_DED
            // 
            this.textBoxStart_DED.Location = new System.Drawing.Point(6, 33);
            this.textBoxStart_DED.Name = "textBoxStart_DED";
            this.textBoxStart_DED.Size = new System.Drawing.Size(118, 20);
            this.textBoxStart_DED.TabIndex = 0;
            // 
            // textBoxStop_DED
            // 
            this.textBoxStop_DED.Location = new System.Drawing.Point(130, 33);
            this.textBoxStop_DED.Name = "textBoxStop_DED";
            this.textBoxStop_DED.Size = new System.Drawing.Size(115, 20);
            this.textBoxStop_DED.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Старт шага:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конец шага:";
            // 
            // buttonSpravka_DED
            // 
            this.buttonSpravka_DED.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSpravka_DED.Location = new System.Drawing.Point(414, 19);
            this.buttonSpravka_DED.Name = "buttonSpravka_DED";
            this.buttonSpravka_DED.Size = new System.Drawing.Size(75, 34);
            this.buttonSpravka_DED.TabIndex = 4;
            this.buttonSpravka_DED.Text = "Справка";
            this.buttonSpravka_DED.UseVisualStyleBackColor = false;
            this.buttonSpravka_DED.Click += new System.EventHandler(this.buttonSpravka_DED_Click);
            // 
            // buttonSave_DED
            // 
            this.buttonSave_DED.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_DED.Location = new System.Drawing.Point(333, 19);
            this.buttonSave_DED.Name = "buttonSave_DED";
            this.buttonSave_DED.Size = new System.Drawing.Size(75, 34);
            this.buttonSave_DED.TabIndex = 5;
            this.buttonSave_DED.Text = "Сохранить";
            this.buttonSave_DED.UseVisualStyleBackColor = false;
            this.buttonSave_DED.Click += new System.EventHandler(this.buttonSave_DED_Click);
            // 
            // buttonToDo_DED
            // 
            this.buttonToDo_DED.BackColor = System.Drawing.Color.Green;
            this.buttonToDo_DED.Location = new System.Drawing.Point(252, 19);
            this.buttonToDo_DED.Name = "buttonToDo_DED";
            this.buttonToDo_DED.Size = new System.Drawing.Size(75, 34);
            this.buttonToDo_DED.TabIndex = 6;
            this.buttonToDo_DED.Text = "Выполнить";
            this.buttonToDo_DED.UseVisualStyleBackColor = false;
            this.buttonToDo_DED.Click += new System.EventHandler(this.buttonToDo_DED_Click);
            // 
            // textBoxResult_DED
            // 
            this.textBoxResult_DED.Location = new System.Drawing.Point(1, 90);
            this.textBoxResult_DED.Multiline = true;
            this.textBoxResult_DED.Name = "textBoxResult_DED";
            this.textBoxResult_DED.Size = new System.Drawing.Size(217, 395);
            this.textBoxResult_DED.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вывод:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult_DED);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chartFunction_DED);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(953, 525);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 5 | Драгомерецкий Е. Д.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_DED)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DED;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonToDo_DED;
        private System.Windows.Forms.Button buttonSave_DED;
        private System.Windows.Forms.Button buttonSpravka_DED;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStop_DED;
        private System.Windows.Forms.TextBox textBoxStart_DED;
        private System.Windows.Forms.TextBox textBoxResult_DED;
        private System.Windows.Forms.Label label3;
    }
}

