
namespace Tyuiu.DragomeretskiyED.Sprint6.Task5.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_DED = new System.Windows.Forms.DataGridView();
            this.buttonSpravka_DED = new System.Windows.Forms.Button();
            this.buttonOpen_DED = new System.Windows.Forms.Button();
            this.buttonDone_DED = new System.Windows.Forms.Button();
            this.chartResult_DED = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_DED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_DED)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V17.txt. Вывести в DataGridView все отриц" +
    "ательные значения и построить диаграмму по этим значениям.  ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewResult_DED);
            this.groupBox2.Location = new System.Drawing.Point(0, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 370);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных:";
            // 
            // dataGridViewResult_DED
            // 
            this.dataGridViewResult_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_DED.Location = new System.Drawing.Point(0, 19);
            this.dataGridViewResult_DED.Name = "dataGridViewResult_DED";
            this.dataGridViewResult_DED.Size = new System.Drawing.Size(142, 351);
            this.dataGridViewResult_DED.TabIndex = 6;
            // 
            // buttonSpravka_DED
            // 
            this.buttonSpravka_DED.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSpravka_DED.Location = new System.Drawing.Point(713, 12);
            this.buttonSpravka_DED.Name = "buttonSpravka_DED";
            this.buttonSpravka_DED.Size = new System.Drawing.Size(75, 54);
            this.buttonSpravka_DED.TabIndex = 3;
            this.buttonSpravka_DED.Text = "Справка";
            this.buttonSpravka_DED.UseVisualStyleBackColor = false;
            this.buttonSpravka_DED.Click += new System.EventHandler(this.buttonSpravka_DED_Click);
            // 
            // buttonOpen_DED
            // 
            this.buttonOpen_DED.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpen_DED.Location = new System.Drawing.Point(632, 12);
            this.buttonOpen_DED.Name = "buttonOpen_DED";
            this.buttonOpen_DED.Size = new System.Drawing.Size(75, 54);
            this.buttonOpen_DED.TabIndex = 4;
            this.buttonOpen_DED.Text = "Открыть файл";
            this.buttonOpen_DED.UseVisualStyleBackColor = false;
            this.buttonOpen_DED.Click += new System.EventHandler(this.buttonOpen_DED_Click);
            // 
            // buttonDone_DED
            // 
            this.buttonDone_DED.BackColor = System.Drawing.Color.Green;
            this.buttonDone_DED.Location = new System.Drawing.Point(551, 12);
            this.buttonDone_DED.Name = "buttonDone_DED";
            this.buttonDone_DED.Size = new System.Drawing.Size(75, 54);
            this.buttonDone_DED.TabIndex = 5;
            this.buttonDone_DED.Text = "Выполнить";
            this.buttonDone_DED.UseVisualStyleBackColor = false;
            this.buttonDone_DED.Click += new System.EventHandler(this.buttonDone_DED_Click);
            // 
            // chartResult_DED
            // 
            chartArea4.Name = "ChartArea1";
            this.chartResult_DED.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartResult_DED.Legends.Add(legend4);
            this.chartResult_DED.Location = new System.Drawing.Point(148, 79);
            this.chartResult_DED.Name = "chartResult_DED";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartResult_DED.Series.Add(series4);
            this.chartResult_DED.Size = new System.Drawing.Size(652, 370);
            this.chartResult_DED.TabIndex = 6;
            this.chartResult_DED.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartResult_DED);
            this.Controls.Add(this.buttonDone_DED);
            this.Controls.Add(this.buttonOpen_DED);
            this.Controls.Add(this.buttonSpravka_DED);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 17 | Драгомерецкий Е. Д. ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_DED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_DED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewResult_DED;
        private System.Windows.Forms.Button buttonSpravka_DED;
        private System.Windows.Forms.Button buttonOpen_DED;
        private System.Windows.Forms.Button buttonDone_DED;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DED;
    }
}

