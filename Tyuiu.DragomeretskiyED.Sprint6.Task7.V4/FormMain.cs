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
using Tyuiu.DragomeretskiyED.Sprint6.Task7.V4.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_DED.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix_DED.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        static string openFile;
        static int rows;
        static int columns;

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_DED.RowCount = 50;
            dataGridViewOutput_DED.RowCount = 50;

            dataGridViewInput_DED.ColumnCount = 50;
            dataGridViewOutput_DED.ColumnCount = 50;



            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_DED.Columns[i].Width = 25;
                dataGridViewOutput_DED.Columns[i].Width = 25;
            }
        }

        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonInfo_DED_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_DED_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DED.ShowDialog();
            openFile = openFileDialogTask_DED.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInput_DED.RowCount = rows;
            dataGridViewInput_DED.ColumnCount = columns;
            dataGridViewOutput_DED.RowCount = rows;
            dataGridViewOutput_DED.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_DED.Columns[i].Width = 50;
                dataGridViewOutput_DED.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_DED.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_DED.Enabled = true;
        }

        private void buttonDone_DED_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput_DED.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_DED.Enabled = true;
        }

        private void buttonSave_DED_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_DED.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_DED.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_DED.ShowDialog();

            string path = saveFileDialogMatrix_DED.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_DED.RowCount;
            int columns = dataGridViewOutput_DED.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutput_DED.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput_DED.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_DED_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DED.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_DED_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DED.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_DED_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DED.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_DED_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DED.ToolTipTitle = "Справка";
        }
    }
}
