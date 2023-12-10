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

using Tyuiu.DragomeretskiyED.Sprint6.Task6.V16.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {

        DataService ds = new DataService();
        string openFilePath;

        public FormMain()
        {
            InitializeComponent();
        }


        private void openFileDialogTask_DED_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonOpenFile_DED_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DED.ShowDialog();
            openFilePath = openFileDialogTask_DED.FileName;
            textBoxInPut_DED.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_DED.Text = groupBoxInPut_DED.Text + " " + openFileDialogTask_DED.FileName;
            buttonDone_DED.Enabled = true;
        }

        private void buttonDone_DED_Click(object sender, EventArgs e)
        {
            textBoxOutPut_DED.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_DED_Click(object sender, EventArgs e)
        {
            FormAbout formHelp = new FormAbout();
            formHelp.ShowDialog();
        }
    }
}
