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
    public partial class ChooseTrain : Form
    {
        public ChooseTrain()
        {
            InitializeComponent();

            ChooseKindOfTrain();
        }
        /// <summary>
        /// Выбор темы для тренировки
        /// </summary>
        /// <param name="train"></param>
        public void ChooseKindOfTrain()
        {

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

            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }

        //По нажатию кнопкок переходит на форму тренировки и передаёт туда тему тренировки
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Train newForm = new Train("1");
            newForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Train newForm = new Train("2");
            newForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Train newForm = new Train("3");
            newForm.Show();
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
