namespace sociology
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.label1title = new System.Windows.Forms.Label();
            this.panel1spend = new System.Windows.Forms.Panel();
            this.button5results = new System.Windows.Forms.Button();
            this.button4load = new System.Windows.Forms.Button();
            this.button3continue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1create = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2newOpros = new System.Windows.Forms.Button();
            this.button1newOprosnik = new System.Windows.Forms.Button();
            this.button6about = new System.Windows.Forms.Button();
            this.button7exit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2continue = new System.Windows.Forms.OpenFileDialog();
            this.panel1spend.SuspendLayout();
            this.panel1create.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1title
            // 
            this.label1title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1title.BackColor = System.Drawing.Color.Gainsboro;
            this.label1title.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1title.Location = new System.Drawing.Point(41, 9);
            this.label1title.Name = "label1title";
            this.label1title.Size = new System.Drawing.Size(374, 23);
            this.label1title.TabIndex = 2;
            this.label1title.Text = "Опросы";
            this.label1title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1spend
            // 
            this.panel1spend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1spend.BackColor = System.Drawing.Color.Linen;
            this.panel1spend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1spend.Controls.Add(this.button5results);
            this.panel1spend.Controls.Add(this.button4load);
            this.panel1spend.Controls.Add(this.button3continue);
            this.panel1spend.Controls.Add(this.label1);
            this.panel1spend.Location = new System.Drawing.Point(37, 38);
            this.panel1spend.Name = "panel1spend";
            this.panel1spend.Size = new System.Drawing.Size(178, 207);
            this.panel1spend.TabIndex = 3;
            // 
            // button5results
            // 
            this.button5results.BackColor = System.Drawing.Color.Linen;
            this.button5results.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5results.Location = new System.Drawing.Point(18, 99);
            this.button5results.Name = "button5results";
            this.button5results.Size = new System.Drawing.Size(140, 23);
            this.button5results.TabIndex = 5;
            this.button5results.TabStop = false;
            this.button5results.Text = "Результаты";
            this.button5results.UseVisualStyleBackColor = false;
            this.button5results.Click += new System.EventHandler(this.button5results_Click);
            // 
            // button4load
            // 
            this.button4load.BackColor = System.Drawing.Color.Linen;
            this.button4load.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4load.Location = new System.Drawing.Point(18, 70);
            this.button4load.Name = "button4load";
            this.button4load.Size = new System.Drawing.Size(140, 23);
            this.button4load.TabIndex = 3;
            this.button4load.TabStop = false;
            this.button4load.Text = "Догрузить данные";
            this.button4load.UseVisualStyleBackColor = false;
            this.button4load.Click += new System.EventHandler(this.button4load_Click);
            // 
            // button3continue
            // 
            this.button3continue.BackColor = System.Drawing.Color.Linen;
            this.button3continue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3continue.Location = new System.Drawing.Point(18, 41);
            this.button3continue.Name = "button3continue";
            this.button3continue.Size = new System.Drawing.Size(140, 23);
            this.button3continue.TabIndex = 2;
            this.button3continue.TabStop = false;
            this.button3continue.Text = "Продолжить опрос";
            this.button3continue.UseVisualStyleBackColor = false;
            this.button3continue.Click += new System.EventHandler(this.button3continue_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проведение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Создание";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1create
            // 
            this.panel1create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1create.BackColor = System.Drawing.Color.Linen;
            this.panel1create.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1create.Controls.Add(this.button1);
            this.panel1create.Controls.Add(this.button2newOpros);
            this.panel1create.Controls.Add(this.button1newOprosnik);
            this.panel1create.Controls.Add(this.label2);
            this.panel1create.Location = new System.Drawing.Point(237, 38);
            this.panel1create.Name = "panel1create";
            this.panel1create.Size = new System.Drawing.Size(178, 207);
            this.panel1create.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(20, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "Редактировать опросник";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2newOpros
            // 
            this.button2newOpros.BackColor = System.Drawing.Color.Linen;
            this.button2newOpros.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2newOpros.Location = new System.Drawing.Point(20, 99);
            this.button2newOpros.Name = "button2newOpros";
            this.button2newOpros.Size = new System.Drawing.Size(140, 23);
            this.button2newOpros.TabIndex = 2;
            this.button2newOpros.TabStop = false;
            this.button2newOpros.Text = "Новый опрос";
            this.button2newOpros.UseVisualStyleBackColor = false;
            this.button2newOpros.Click += new System.EventHandler(this.button2newOpros_Click);
            // 
            // button1newOprosnik
            // 
            this.button1newOprosnik.BackColor = System.Drawing.Color.Linen;
            this.button1newOprosnik.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1newOprosnik.Location = new System.Drawing.Point(20, 41);
            this.button1newOprosnik.Name = "button1newOprosnik";
            this.button1newOprosnik.Size = new System.Drawing.Size(140, 23);
            this.button1newOprosnik.TabIndex = 1;
            this.button1newOprosnik.TabStop = false;
            this.button1newOprosnik.Text = "Новый опросник";
            this.button1newOprosnik.UseVisualStyleBackColor = false;
            this.button1newOprosnik.Click += new System.EventHandler(this.button1newOprosnik_Click);
            // 
            // button6about
            // 
            this.button6about.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6about.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6about.Location = new System.Drawing.Point(80, 251);
            this.button6about.Name = "button6about";
            this.button6about.Size = new System.Drawing.Size(92, 23);
            this.button6about.TabIndex = 5;
            this.button6about.TabStop = false;
            this.button6about.Text = "О программе";
            this.button6about.UseVisualStyleBackColor = true;
            this.button6about.Click += new System.EventHandler(this.button6about_Click);
            // 
            // button7exit
            // 
            this.button7exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7exit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7exit.Location = new System.Drawing.Point(280, 251);
            this.button7exit.Name = "button7exit";
            this.button7exit.Size = new System.Drawing.Size(92, 23);
            this.button7exit.TabIndex = 6;
            this.button7exit.TabStop = false;
            this.button7exit.Text = "Выход";
            this.button7exit.UseVisualStyleBackColor = true;
            this.button7exit.Click += new System.EventHandler(this.button7exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AutoUpgradeEnabled = false;
            this.openFileDialog1.DefaultExt = "oprosnik";
            this.openFileDialog1.Filter = "*.oprosnik|";
            this.openFileDialog1.InitialDirectory = "save";
            this.openFileDialog1.Title = "Выберите файл опросника";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AutoUpgradeEnabled = false;
            this.saveFileDialog1.DefaultExt = "opros";
            this.saveFileDialog1.FileName = "new";
            this.saveFileDialog1.Filter = "*.opros|";
            this.saveFileDialog1.InitialDirectory = "save";
            this.saveFileDialog1.Title = "Сохраните результат";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog2continue
            // 
            this.openFileDialog2continue.AutoUpgradeEnabled = false;
            this.openFileDialog2continue.FileName = "файл опроса";
            this.openFileDialog2continue.Filter = "*.opros|";
            this.openFileDialog2continue.InitialDirectory = "save";
            this.openFileDialog2continue.Title = "Выберите файл опроса";
            this.openFileDialog2continue.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2continue_FileOk);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.button7exit);
            this.Controls.Add(this.button6about);
            this.Controls.Add(this.panel1create);
            this.Controls.Add(this.panel1spend);
            this.Controls.Add(this.label1title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа проведения опросов";
            this.panel1spend.ResumeLayout(false);
            this.panel1create.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1title;
        private System.Windows.Forms.Panel panel1spend;
        private System.Windows.Forms.Button button4load;
        private System.Windows.Forms.Button button3continue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1create;
        private System.Windows.Forms.Button button2newOpros;
        private System.Windows.Forms.Button button1newOprosnik;
        private System.Windows.Forms.Button button5results;
        private System.Windows.Forms.Button button6about;
        private System.Windows.Forms.Button button7exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2continue;
    }
}

