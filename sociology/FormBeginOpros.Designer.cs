namespace sociology
{
    partial class FormBeginOpros
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3ostalos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Описание опроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Осталось опросить: ";
            // 
            // label3ostalos
            // 
            this.label3ostalos.AutoSize = true;
            this.label3ostalos.Location = new System.Drawing.Point(162, 145);
            this.label3ostalos.Name = "label3ostalos";
            this.label3ostalos.Size = new System.Drawing.Size(108, 17);
            this.label3ostalos.TabIndex = 3;
            this.label3ostalos.Text = "не определено";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Пройти опрос";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormBeginOpros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3ostalos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBeginOpros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3ostalos;
        private System.Windows.Forms.Button button1;
    }
}