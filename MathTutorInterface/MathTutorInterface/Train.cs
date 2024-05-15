using MathTutor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathTutorInterface
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();

            var train = new TheoryTrainer();
            ChooseKindOfTrain(train);
        }
        public void ChooseKindOfTrain(TheoryTrainer train)
        {

            var Themes = new List<string> { "тригонометрия", "таблица производных", "таблица интегралов" };

            Label label = new Label();
            label.Text = "Выберете тему, по которой хотите пройти тренировку:";
            label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
            label.Location = new Point((Size.Width - label.Width) / 2, 90);

            Controls.Add(label);

            var button1 = new Button()
            {
                Text = "Тригонометрия",
                Font = new Font("Palatino Linotype", 12, FontStyle.Regular),
                Size = new Size(316, 52),
                Location = new Point((Size.Width - 316) / 2, 160)
            };
            var button2 = new Button()
            {
                Text = "Таблица производных",
                Font = new Font("Palatino Linotype", 12, FontStyle.Regular),
                Size = new Size(316, 52),
                Location = new Point((Size.Width - 316) / 2, button1.Location.Y + button1.Height + 10)
            };
            var button3 = new Button()
            {
                Text = "Таблица интегралов",
                Font = new Font("Palatino Linotype", 12, FontStyle.Regular),
                Size = new Size(316, 52),
                Location = new Point((Size.Width - 316) / 2, button2.Location.Y + button2.Height + 10)
            };

            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);

            void button1_Click(object sender, EventArgs e)
            {
                train.Start("1");
            }
            void button2_Click(object sender, EventArgs e)
            {
                train.Start("2");
            }
            void button3_Click(object sender, EventArgs e)
            {
                train.Start("3");
            }
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
