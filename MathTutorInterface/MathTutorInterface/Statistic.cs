using MathTutor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTutorInterface
{
    public partial class Statistic : Form
    {
        public Statistic(TheoryTrainer train)
        {
            InitializeComponent();
            Work(train);
        }
        public void Work(TheoryTrainer train)
        {
            Label label = new Label();
            label.Text = "Поздравляю вы закончили эту тренировку!\nХотите начать новую или увидеть статистику?";
            label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
            label.Location = new Point((Width - label.Width) / 2, 90);
            Controls.Add(label);

            Button button1 = new Button()
            {
                Text = "Хочу пройти ещё одну тренировку!",
                Font = new Font("Palatino Linotype", 11, FontStyle.Regular),
                Size = new Size(300, 64),
                Location = new Point(Size.Width / 2 - 310, 220)
            };
            Button button2 = new Button()
            {
                Text = "Хочу увидеть статистику!",
                Font = new Font("Palatino Linotype", 11, FontStyle.Regular),
                Size = new Size(300, 64),
                Location = new Point(Size.Width / 2 + 10, 220)
            };
            Controls.Add(button1);
            Controls.Add(button2);
            button1.Click += button1_Click;
            button2.Click += button2_Click;

            void button1_Click(object sender, EventArgs e)
            { 
                this.Hide();
                ChooseTrain Form = new ChooseTrain(train);
                Form.Show();
            }
            void button2_Click(object sender, EventArgs e)
            {

            }

        }
        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
