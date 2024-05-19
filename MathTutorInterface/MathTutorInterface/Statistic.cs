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
            Choose(train);
        }
        /// <summary>
        /// Выбор: Переход к ещё одной тренировке или к статистике
        /// </summary>
        /// <param name="train"></param>
        public void Choose(TheoryTrainer train)
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
                Controls.Remove(label);
                Controls.Remove(button1);
                Controls.Remove(button2);
                button1.Click -= button1_Click;
                button2.Click -= button2_Click;
                ChooseThemeStatistic(train);
            }

        }
        /// <summary>
        /// Выбор темы для статистики
        /// </summary>
        /// <param name="train"></param>
        public void ChooseThemeStatistic(TheoryTrainer train)
        {
            Label label = new Label();
            label.Text = "По какой теме вы хотите увидеть статистику?";
            label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
            label.Location = new Point((Width - label.Width) / 2, 90);
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

            void button1_Click(object sender, EventArgs e)
            { 
                Controls.Remove(label);
                Controls.Remove(button1);
                Controls.Remove(button2);
                Controls.Remove(button3);
                button1.Click -= button1_Click;
                button2.Click -= button2_Click;
                button3.Click -= button3_Click;
                ChooseCount("1", train);
            };
            void button2_Click(object sender, EventArgs e)
            {
                Controls.Remove(label);
                Controls.Remove(button1);
                Controls.Remove(button2);
                Controls.Remove(button3);
                button1.Click -= button1_Click;
                button2.Click -= button2_Click;
                button3.Click -= button3_Click;
                ChooseCount("2", train);
            };
            void button3_Click(object sender, EventArgs e)
            {
                Controls.Remove(label);
                Controls.Remove(button1);
                Controls.Remove(button2);
                Controls.Remove(button3);
                button1.Click -= button1_Click;
                button2.Click -= button2_Click;
                button3.Click -= button3_Click;
                ChooseCount("3", train);
            };
        }
        /// <summary>
        /// Выбор числа учитываемых попыток
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="train"></param>
        public void ChooseCount(string theme, TheoryTrainer train)
        {
            Label label = new Label();
            label.Text = "За какое кол-во попыток вы хотите увидеть статистику?\nВведите число учитываемых попыток внизу:";
            label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
            label.Location = new Point((Width - label.Width) / 2, 90);
            Controls.Add(label);

            TextBox textBox = new TextBox();
            textBox.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            textBox.Size = new Size(604, 20);
            textBox.Location = new Point((Width - textBox.Width) / 2, 160);
            Controls.Add(textBox);
            textBox.TextChanged += textBox_TextChanged;

            void textBox_TextChanged(object sender, EventArgs e)
            {
                Controls.Remove(textBox);
                Controls.Remove(label);
                ShowStatistic(theme, textBox.Text, train);
            }
        }
        /// <summary>
        /// Выводит статистику тренировок
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="train"></param>
        public void ShowStatistic(string theme, string count, TheoryTrainer train)
        {
            RichTextBox textBox = new RichTextBox();
            textBox.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            textBox.Size = new Size(604, 200);
            textBox.Location = new Point((Width - textBox.Width) / 2, 110);
            Controls.Add(textBox);

            if (!int.TryParse(count, out var c) || int.Parse(count) < 0)
                textBox.Text = "Ой, вы ввели неправильное кол-во учитываемых попыток! Мы не можем показать вам статистику ^ - ^";

            List<Dictionary<Formula, int>> stat = train.ShowStatistics(theme, int.Parse(count));
            foreach (var attempts in stat)
            {
                foreach (var item in attempts)
                {
                    textBox.Text += $"{item.Key}  >>> кол-во ошибок >>> {item.Value}\n";
                }
                textBox.Text += "\n";
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
        /// <summary>
        /// Возврат к главной странице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMainScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu Form = new StartMenu();
            Form.Show();
        }
    }
}
