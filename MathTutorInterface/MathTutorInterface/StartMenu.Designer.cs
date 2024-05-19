namespace MathTutorInterface
{
    partial class StartMenu
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
            this.PartName = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PartName
            // 
            this.PartName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartName.AutoSize = true;
            this.PartName.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartName.Location = new System.Drawing.Point(311, 32);
            this.PartName.Name = "PartName";
            this.PartName.Size = new System.Drawing.Size(363, 45);
            this.PartName.TabIndex = 0;
            this.PartName.Text = "Зазубривание формул";
            this.PartName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Enter
            // 
            this.Enter.AutoSize = true;
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(957, 9);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(31, 29);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "X";
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(400, 195);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(0, 16);
            this.Text.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(253, 330);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(495, 68);
            this.Start.TabIndex = 3;
            this.Start.Text = "Начать тренировку!";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(746, 162);
            this.label1.TabIndex = 4;
            this.label1.Text = "Здесь вы можете подтянуть свои знания формул по нескольким темам: \r\n1. Тригономет" +
    "рия;\r\n2. Интегралы;\r\n3. Производные\r\n\r\nА также узнать статистику неправильных от" +
    "ветов (только после тренировки).";
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.PartName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartName;
        private System.Windows.Forms.Label Enter;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
    }
}

