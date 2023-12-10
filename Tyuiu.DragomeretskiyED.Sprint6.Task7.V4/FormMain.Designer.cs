
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
            this.buttonExploreData_DED = new System.Windows.Forms.Button();
            this.buttonDone_DED = new System.Windows.Forms.Button();
            this.buttonSave_DED = new System.Windows.Forms.Button();
            this.openFileDialogTask_DED = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_DED = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutput_DED = new System.Windows.Forms.DataGridView();
            this.buttonHelp_DED = new System.Windows.Forms.Button();
            this.saveFileDialogMatrix_DED = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_DED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_DED)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExploreData_DED
            // 
            this.buttonExploreData_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExploreData_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonExploreData_DED.Image")));
            this.buttonExploreData_DED.Location = new System.Drawing.Point(3, 3);
            this.buttonExploreData_DED.Name = "buttonExploreData_DED";
            this.buttonExploreData_DED.Size = new System.Drawing.Size(64, 47);
            this.buttonExploreData_DED.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonExploreData_DED, "Открыть файл для обработки данных в формате CSV");
            this.buttonExploreData_DED.UseVisualStyleBackColor = true;
            this.buttonExploreData_DED.Click += new System.EventHandler(this.buttonExploreData_DED_Click);
            this.buttonExploreData_DED.MouseEnter += new System.EventHandler(this.buttonExploreData_DED_MouseEnter);
            // 
            // buttonDone_DED
            // 
            this.buttonDone_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_DED.Image")));
            this.buttonDone_DED.Location = new System.Drawing.Point(73, 3);
            this.buttonDone_DED.Name = "buttonDone_DED";
            this.buttonDone_DED.Size = new System.Drawing.Size(64, 47);
            this.buttonDone_DED.TabIndex = 1;
            this.buttonDone_DED.UseVisualStyleBackColor = true;
            this.buttonDone_DED.Click += new System.EventHandler(this.buttonDone_DED_Click);
            this.buttonDone_DED.MouseEnter += new System.EventHandler(this.buttonDone_DED_MouseEnter);
            // 
            // buttonSave_DED
            // 
            this.buttonSave_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_DED.Image")));
            this.buttonSave_DED.Location = new System.Drawing.Point(143, 3);
            this.buttonSave_DED.Name = "buttonSave_DED";
            this.buttonSave_DED.Size = new System.Drawing.Size(64, 47);
            this.buttonSave_DED.TabIndex = 2;
            this.buttonSave_DED.UseVisualStyleBackColor = true;
            this.buttonSave_DED.Click += new System.EventHandler(this.buttonSave_DED_Click);
            this.buttonSave_DED.MouseEnter += new System.EventHandler(this.buttonSave_DED_MouseEnter);
            // 
            // openFileDialogTask_DED
            // 
            this.openFileDialogTask_DED.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            this.toolTipButton.IsBalloon = true;
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(788, 51);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewInput_DED);
            this.groupBox2.Location = new System.Drawing.Point(7, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 427);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewOutput_DED);
            this.groupBox3.Location = new System.Drawing.Point(391, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 427);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод:";
            // 
            // dataGridViewInput_DED
            // 
            this.dataGridViewInput_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_DED.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_DED.Name = "dataGridViewInput_DED";
            this.dataGridViewInput_DED.Size = new System.Drawing.Size(375, 411);
            this.dataGridViewInput_DED.TabIndex = 0;
            // 
            // dataGridViewOutput_DED
            // 
            this.dataGridViewOutput_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_DED.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput_DED.Name = "dataGridViewOutput_DED";
            this.dataGridViewOutput_DED.Size = new System.Drawing.Size(403, 411);
            this.dataGridViewOutput_DED.TabIndex = 0;
            // 
            // buttonHelp_DED
            // 
            this.buttonHelp_DED.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_DED.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_DED.Image")));
            this.buttonHelp_DED.Location = new System.Drawing.Point(733, 3);
            this.buttonHelp_DED.Name = "buttonHelp_DED";
            this.buttonHelp_DED.Size = new System.Drawing.Size(64, 47);
            this.buttonHelp_DED.TabIndex = 5;
            this.buttonHelp_DED.UseVisualStyleBackColor = true;
            this.buttonHelp_DED.Click += new System.EventHandler(this.buttonHelp_DED_Click);
            this.buttonHelp_DED.MouseEnter += new System.EventHandler(this.buttonHelp_DED_MouseEnter);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.buttonHelp_DED);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave_DED);
            this.Controls.Add(this.buttonDone_DED);
            this.Controls.Add(this.buttonExploreData_DED);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_DED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_DED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExploreData_DED;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.Button buttonDone_DED;
        private System.Windows.Forms.Button buttonSave_DED;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_DED;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewInput_DED;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewOutput_DED;
        private System.Windows.Forms.Button buttonHelp_DED;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_DED;
    }
}

