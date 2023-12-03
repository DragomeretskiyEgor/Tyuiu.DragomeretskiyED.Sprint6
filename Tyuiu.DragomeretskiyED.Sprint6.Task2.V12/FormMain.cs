using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.DragomeretskiyED.Sprint6.Task2.V12.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonStartCode_DED_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxInputStartStep_DED.Text);
                int stopValue = Convert.ToInt32(textBoxInputStopStep_DED.Text);


                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                this.chartFunction_DED.Titles.Add("График функции");

                this.chartFunction_DED.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_DED.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_DED.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_DED.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSpravka_DED_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-23-1 Драгомерецкий Егор Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSpravka_DED_MouseEnter(object sender, EventArgs e)
        {
            buttonStartCode_DED.BackColor = Color.Red;
        }

        private void buttonSpravka_DED_MouseLeave(object sender, EventArgs e)
        {
            buttonStartCode_DED.BackColor = Color.Green;
        }

        private void buttonSpravka_DED_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStartCode_DED.BackColor = Color.Blue;
        }
    }
}
