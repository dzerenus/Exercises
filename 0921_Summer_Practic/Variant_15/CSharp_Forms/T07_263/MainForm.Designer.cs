
namespace T07_263
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
            this.tbString = new System.Windows.Forms.TextBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Даны натуральное число n, символы s1,...,sn. Заменить в последовательности s1,..." +
    ",sn каждую группу \r\nбукв child группой букв children.";
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(16, 52);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(673, 20);
            this.tbString.TabIndex = 1;
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(695, 50);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(93, 23);
            this.btnWork.TabIndex = 2;
            this.btnWork.Text = "Обработать";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(16, 78);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(772, 20);
            this.tbResult.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 107);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Задача 7 - 263";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.TextBox tbResult;
    }
}

