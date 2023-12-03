
namespace Tyuiu.DragomeretskiyED.Sprint6.Task3.V22
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_DED = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonHelp_DED = new System.Windows.Forms.Button();
            this.buttonDone_DED = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewResult_DED = new System.Windows.Forms.DataGridView();
            this.textBoxData_DED = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_DED)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_DED)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxData_DED);
            this.groupBox1.Controls.Add(this.dataGridViewMatrix_DED);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // dataGridViewMatrix_DED
            // 
            this.dataGridViewMatrix_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_DED.Location = new System.Drawing.Point(315, 19);
            this.dataGridViewMatrix_DED.Name = "dataGridViewMatrix_DED";
            this.dataGridViewMatrix_DED.Size = new System.Drawing.Size(311, 308);
            this.dataGridViewMatrix_DED.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewResult_DED);
            this.groupBox2.Controls.Add(this.buttonHelp_DED);
            this.groupBox2.Controls.Add(this.buttonDone_DED);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(650, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // buttonHelp_DED
            // 
            this.buttonHelp_DED.Location = new System.Drawing.Point(203, 299);
            this.buttonHelp_DED.Name = "buttonHelp_DED";
            this.buttonHelp_DED.Size = new System.Drawing.Size(34, 28);
            this.buttonHelp_DED.TabIndex = 3;
            this.buttonHelp_DED.Text = "?";
            this.buttonHelp_DED.UseVisualStyleBackColor = true;
            this.buttonHelp_DED.Click += new System.EventHandler(this.buttonHelp_DED_Click);
            // 
            // buttonDone_DED
            // 
            this.buttonDone_DED.Location = new System.Drawing.Point(243, 299);
            this.buttonDone_DED.Name = "buttonDone_DED";
            this.buttonDone_DED.Size = new System.Drawing.Size(75, 28);
            this.buttonDone_DED.TabIndex = 2;
            this.buttonDone_DED.Text = "Выполнить";
            this.buttonDone_DED.UseVisualStyleBackColor = true;
            this.buttonDone_DED.Click += new System.EventHandler(this.buttonDone_DED_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Результат:";
            // 
            // dataGridViewResult_DED
            // 
            this.dataGridViewResult_DED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_DED.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewResult_DED.Name = "dataGridViewResult_DED";
            this.dataGridViewResult_DED.Size = new System.Drawing.Size(312, 261);
            this.dataGridViewResult_DED.TabIndex = 4;
            // 
            // textBoxData_DED
            // 
            this.textBoxData_DED.Location = new System.Drawing.Point(6, 19);
            this.textBoxData_DED.Multiline = true;
            this.textBoxData_DED.Name = "textBoxData_DED";
            this.textBoxData_DED.Size = new System.Drawing.Size(291, 308);
            this.textBoxData_DED.TabIndex = 2;
            this.textBoxData_DED.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n17" +
    "   0  19  -8  -1\r\n\r\n 9   4  -5   7  15\r\n\r\n11  13   4  -4 -14\r\n\r\n11  14   5 -15  " +
    "16\r\n\r\n2 -14  -2  11  11";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 362);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 22 | Драгомерецкий Е. Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_DED)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_DED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_DED;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonHelp_DED;
        private System.Windows.Forms.Button buttonDone_DED;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewResult_DED;
        private System.Windows.Forms.TextBox textBoxData_DED;
    }
}

