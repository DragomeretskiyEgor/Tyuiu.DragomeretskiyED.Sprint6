
namespace Tyuiu.DragomeretskiyED.Sprint6.Task7.V4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_DED = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_DED = new System.Windows.Forms.DataGridView();
            this.buttonDone_DED = new System.Windows.Forms.Button();
            this.buttonSave_DED = new System.Windows.Forms.Button();
            this.buttonInfo_DED = new System.Windows.Forms.Button();
            this.buttonOpenFile_DED = new System.Windows.Forms.Button();
            this.openFileDialogTask_DED = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_DED = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_DED = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_DED)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_DED)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewInput_DED);
            this.groupBox2.Location = new System.Drawing.Point(3, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод:";
            // 
            // dataGridViewInput_DED
            // 
            this.dataGridViewInput_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_DED.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_DED.Name = "dataGridViewInput_DED";
            this.dataGridViewInput_DED.Size = new System.Drawing.Size(348, 305);
            this.dataGridViewInput_DED.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewOutput_DED);
            this.groupBox3.Location = new System.Drawing.Point(360, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 321);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод:";
            // 
            // dataGridViewOutput_DED
            // 
            this.dataGridViewOutput_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_DED.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput_DED.Name = "dataGridViewOutput_DED";
            this.dataGridViewOutput_DED.Size = new System.Drawing.Size(343, 305);
            this.dataGridViewOutput_DED.TabIndex = 0;
            // 
            // buttonDone_DED
            // 
            this.buttonDone_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_DED.Image")));
            this.buttonDone_DED.Location = new System.Drawing.Point(84, 13);
            this.buttonDone_DED.Name = "buttonDone_DED";
            this.buttonDone_DED.Size = new System.Drawing.Size(75, 50);
            this.buttonDone_DED.TabIndex = 4;
            this.buttonDone_DED.UseVisualStyleBackColor = true;
            this.buttonDone_DED.Click += new System.EventHandler(this.buttonDone_DED_Click);
            this.buttonDone_DED.MouseEnter += new System.EventHandler(this.buttonDone_DED_MouseEnter);
            // 
            // buttonSave_DED
            // 
            this.buttonSave_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_DED.Image")));
            this.buttonSave_DED.Location = new System.Drawing.Point(165, 12);
            this.buttonSave_DED.Name = "buttonSave_DED";
            this.buttonSave_DED.Size = new System.Drawing.Size(75, 50);
            this.buttonSave_DED.TabIndex = 5;
            this.buttonSave_DED.UseVisualStyleBackColor = true;
            this.buttonSave_DED.Click += new System.EventHandler(this.buttonSave_DED_Click);
            this.buttonSave_DED.MouseEnter += new System.EventHandler(this.buttonSave_DED_MouseEnter);
            // 
            // buttonInfo_DED
            // 
            this.buttonInfo_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_DED.Image")));
            this.buttonInfo_DED.Location = new System.Drawing.Point(631, 12);
            this.buttonInfo_DED.Name = "buttonInfo_DED";
            this.buttonInfo_DED.Size = new System.Drawing.Size(75, 49);
            this.buttonInfo_DED.TabIndex = 6;
            this.buttonInfo_DED.UseVisualStyleBackColor = true;
            this.buttonInfo_DED.Click += new System.EventHandler(this.buttonInfo_DED_Click);
            this.buttonInfo_DED.MouseEnter += new System.EventHandler(this.buttonInfo_DED_MouseEnter);
            // 
            // buttonOpenFile_DED
            // 
            this.buttonOpenFile_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_DED.Image")));
            this.buttonOpenFile_DED.Location = new System.Drawing.Point(3, 13);
            this.buttonOpenFile_DED.Name = "buttonOpenFile_DED";
            this.buttonOpenFile_DED.Size = new System.Drawing.Size(75, 49);
            this.buttonOpenFile_DED.TabIndex = 7;
            this.buttonOpenFile_DED.UseVisualStyleBackColor = true;
            this.buttonOpenFile_DED.Click += new System.EventHandler(this.buttonOpenFile_DED_Click);
            this.buttonOpenFile_DED.MouseEnter += new System.EventHandler(this.buttonOpenFile_DED_MouseEnter);
            // 
            // openFileDialogTask_DED
            // 
            this.openFileDialogTask_DED.FileName = "openFileDialog1";
            // 
            // toolTipButton_DED
            // 
            this.toolTipButton_DED.IsBalloon = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 496);
            this.Controls.Add(this.buttonOpenFile_DED);
            this.Controls.Add(this.buttonInfo_DED);
            this.Controls.Add(this.buttonSave_DED);
            this.Controls.Add(this.buttonDone_DED);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 4 | Драгомерецкий Е. Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_DED)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_DED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDone_DED;
        private System.Windows.Forms.Button buttonSave_DED;
        private System.Windows.Forms.Button buttonInfo_DED;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInput_DED;
        private System.Windows.Forms.Button buttonOpenFile_DED;
        private System.Windows.Forms.DataGridView dataGridViewOutput_DED;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DED;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_DED;
        private System.Windows.Forms.ToolTip toolTipButton_DED;
    }
}

