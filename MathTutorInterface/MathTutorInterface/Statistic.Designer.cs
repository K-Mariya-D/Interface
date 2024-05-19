namespace MathTutorInterface
{
    partial class Statistic
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
            this.OnMainScreen = new System.Windows.Forms.Label();
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
            this.Enter.TabIndex = 4;
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
            this.PartName.TabIndex = 5;
            this.PartName.Text = "Зазубривание формул";
            this.PartName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OnMainScreen
            // 
            this.OnMainScreen.AutoSize = true;
            this.OnMainScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnMainScreen.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OnMainScreen.Location = new System.Drawing.Point(12, 9);
            this.OnMainScreen.Name = "OnMainScreen";
            this.OnMainScreen.Size = new System.Drawing.Size(126, 23);
            this.OnMainScreen.TabIndex = 6;
            this.OnMainScreen.Text = "<<На главную";
            this.OnMainScreen.Click += new System.EventHandler(this.OnMainScreen_Click);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.OnMainScreen);
            this.Controls.Add(this.PartName);
            this.Controls.Add(this.Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter;
        private System.Windows.Forms.Label PartName;
        private System.Windows.Forms.Label OnMainScreen;
    }
}