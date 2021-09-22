
namespace T09_702b
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnOkN = new System.Windows.Forms.Button();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbINumbers = new System.Windows.Forms.TextBox();
            this.DGMatrix = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дана квадратная матрица порядка n. Получить вектор\r\nAb, где b-вектор, элементы ко" +
    "торого вычисляются по \r\nформуле ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::T09_702b.Properties.Resources._01;
            this.pictureBox1.Location = new System.Drawing.Point(517, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 92);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Controls.Add(this.btnWork);
            this.groupBox1.Controls.Add(this.btnOkN);
            this.groupBox1.Controls.Add(this.tbN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbINumbers);
            this.groupBox1.Controls.Add(this.DGMatrix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 319);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сама задача";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(10, 281);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(364, 26);
            this.tbResult.TabIndex = 8;
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(632, 280);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(127, 28);
            this.btnWork.TabIndex = 7;
            this.btnWork.TabStop = false;
            this.btnWork.Text = "Рассчитать";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnOkN
            // 
            this.btnOkN.Location = new System.Drawing.Point(499, 280);
            this.btnOkN.Name = "btnOkN";
            this.btnOkN.Size = new System.Drawing.Size(127, 28);
            this.btnOkN.TabIndex = 6;
            this.btnOkN.Text = "Принять N";
            this.btnOkN.UseVisualStyleBackColor = true;
            this.btnOkN.Click += new System.EventHandler(this.btnOkN_Click);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(455, 281);
            this.tbN.MaxLength = 1;
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(38, 26);
            this.tbN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Числа i:";
            // 
            // tbINumbers
            // 
            this.tbINumbers.Location = new System.Drawing.Point(74, 250);
            this.tbINumbers.Name = "tbINumbers";
            this.tbINumbers.ReadOnly = true;
            this.tbINumbers.Size = new System.Drawing.Size(685, 26);
            this.tbINumbers.TabIndex = 2;
            // 
            // DGMatrix
            // 
            this.DGMatrix.AllowUserToAddRows = false;
            this.DGMatrix.AllowUserToDeleteRows = false;
            this.DGMatrix.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGMatrix.ColumnHeadersVisible = false;
            this.DGMatrix.Location = new System.Drawing.Point(6, 25);
            this.DGMatrix.Name = "DGMatrix";
            this.DGMatrix.RowHeadersVisible = false;
            this.DGMatrix.RowHeadersWidth = 23;
            this.DGMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGMatrix.Size = new System.Drawing.Size(753, 216);
            this.DGMatrix.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Число N:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Задача 09 - 702(б)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnOkN;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbINumbers;
        private System.Windows.Forms.DataGridView DGMatrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
    }
}

