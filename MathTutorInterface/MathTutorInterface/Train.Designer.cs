﻿namespace MathTutorInterface
{
    partial class Train
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
            this.Enter = new System.Windows.Forms.Label();
            this.PartName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.AutoSize = true;
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(957, 9);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(31, 29);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "X";
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
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
            this.PartName.TabIndex = 4;
            this.PartName.Text = "Зазубривание формул";
            this.PartName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(198, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(604, 113);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(168, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Я написал формулу правильно!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(510, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(322, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Я написал формулу неправильно :(";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PartName);
            this.Controls.Add(this.Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Train";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Train";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter;
        private System.Windows.Forms.Label PartName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}