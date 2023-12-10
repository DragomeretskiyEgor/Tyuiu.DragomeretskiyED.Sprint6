using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.DragomeretskiyED.Sprint6.Task5.V17.Lib;


namespace Tyuiu.DragomeretskiyED.Sprint6.Task5.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Gogr-PC\source\repos\Tyuiu.DragomeretskiyED.Sprint6\Tyuiu.DragomeretskiyED.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";

        private void buttonDone_DED_Click(object sender, EventArgs e)
        {
            dataGridViewResult_DED.ColumnCount = 2;
            dataGridViewResult_DED.Columns[0].Width = 30;
            dataGridViewResult_DED.Columns[1].Width = 50;
            this.chartResult_DED.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_DED.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_DED.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_DED.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_DED.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpen_DED_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonSpravka_DED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-23-1 Драгомерецкий Егор Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
