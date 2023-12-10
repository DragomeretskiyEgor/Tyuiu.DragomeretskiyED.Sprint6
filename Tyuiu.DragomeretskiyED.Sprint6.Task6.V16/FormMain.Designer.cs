
namespace Tyuiu.DragomeretskiyED.Sprint6.Task6.V16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialogTask_DED = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxInPut_DED = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_DED = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_DED = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFile_DED = new System.Windows.Forms.Button();
            this.buttonDone_DED = new System.Windows.Forms.Button();
            this.buttonHelp_DED = new System.Windows.Forms.Button();
            this.groupBoxInPut_DED.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTask_DED
            // 
            this.openFileDialogTask_DED.FileName = "openFileDialog1";
            this.openFileDialogTask_DED.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogTask_DED_FileOk);
            // 
            // groupBoxInPut_DED
            // 
            this.groupBoxInPut_DED.Controls.Add(this.textBoxInPut_DED);
            this.groupBoxInPut_DED.Controls.Add(this.groupBox2);
            this.groupBoxInPut_DED.Location = new System.Drawing.Point(0, 134);
            this.groupBoxInPut_DED.Name = "groupBoxInPut_DED";
            this.groupBoxInPut_DED.Size = new System.Drawing.Size(392, 317);
            this.groupBoxInPut_DED.TabIndex = 0;
            this.groupBoxInPut_DED.TabStop = false;
            this.groupBoxInPut_DED.Text = "Ввод:";
            // 
            // textBoxInPut_DED
            // 
            this.textBoxInPut_DED.Location = new System.Drawing.Point(0, 16);
            this.textBoxInPut_DED.Multiline = true;
            this.textBoxInPut_DED.Name = "textBoxInPut_DED";
            this.textBoxInPut_DED.Size = new System.Drawing.Size(392, 301);
            this.textBoxInPut_DED.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(396, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOutPut_DED);
            this.groupBox3.Location = new System.Drawing.Point(396, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 317);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод:";
            // 
            // textBoxOutPut_DED
            // 
            this.textBoxOutPut_DED.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_DED.Multiline = true;
            this.textBoxOutPut_DED.Name = "textBoxOutPut_DED";
            this.textBoxOutPut_DED.Size = new System.Drawing.Size(401, 301);
            this.textBoxOutPut_DED.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(0, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(800, 70);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Условие:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(800, 45);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_DED
            // 
            this.buttonOpenFile_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_DED.Image")));
            this.buttonOpenFile_DED.Location = new System.Drawing.Point(12, 4);
            this.buttonOpenFile_DED.Name = "buttonOpenFile_DED";
            this.buttonOpenFile_DED.Size = new System.Drawing.Size(75, 48);
            this.buttonOpenFile_DED.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonOpenFile_DED, "Открыть файл \r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_DED.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DED.Click += new System.EventHandler(this.buttonOpenFile_DED_Click);
            // 
            // buttonDone_DED
            // 
            this.buttonDone_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_DED.Image")));
            this.buttonDone_DED.Location = new System.Drawing.Point(106, 4);
            this.buttonDone_DED.Name = "buttonDone_DED";
            this.buttonDone_DED.Size = new System.Drawing.Size(75, 48);
            this.buttonDone_DED.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonDone_DED, "Производит в файле поиск слов с буквой \"b\" и выводит их.\r\n");
            this.buttonDone_DED.UseVisualStyleBackColor = true;
            this.buttonDone_DED.Click += new System.EventHandler(this.buttonDone_DED_Click);
            // 
            // buttonHelp_DED
            // 
            this.buttonHelp_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_DED.Image")));
            this.buttonHelp_DED.Location = new System.Drawing.Point(713, 4);
            this.buttonHelp_DED.Name = "buttonHelp_DED";
            this.buttonHelp_DED.Size = new System.Drawing.Size(75, 48);
            this.buttonHelp_DED.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonHelp_DED, "Сведения о программе\r\n");
            this.buttonHelp_DED.UseVisualStyleBackColor = true;
            this.buttonHelp_DED.Click += new System.EventHandler(this.buttonHelp_DED_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_DED);
            this.Controls.Add(this.buttonDone_DED);
            this.Controls.Add(this.buttonOpenFile_DED);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxInPut_DED);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 16 | Драгомерецкий Е. Д,";
            this.groupBoxInPut_DED.ResumeLayout(false);
            this.groupBoxInPut_DED.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DED;
        private System.Windows.Forms.GroupBox groupBoxInPut_DED;
        private System.Windows.Forms.TextBox textBoxInPut_DED;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxOutPut_DED;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonOpenFile_DED;
        private System.Windows.Forms.Button buttonDone_DED;
        private System.Windows.Forms.Button buttonHelp_DED;
    }
}

