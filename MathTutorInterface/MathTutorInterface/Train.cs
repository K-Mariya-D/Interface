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
    public partial class Train : Form
    {
        public Train(string theme, TheoryTrainer train)
        {
            InitializeComponent();
            StartTrain(theme, train);
            
        }
        public void StartTrain(string theme, TheoryTrainer train)
        {
            train.Start(theme);

            //Параметры, которые не будут менятся описаны здесь. Остальное в методе Start
            Label label = new Label();
            label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular); 
            
            Label label1 = new Label();
            label1.Text = "Можете ввести формулу ниже или записать у себя на листке.\nДля того чтобы узнать правильную формулу нажмите Enter>>";
            label1.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            label1.Size = new Size(label1.PreferredWidth, label1.PreferredHeight);

            var button1 = new Button()
            {
                Text = "Я написал формулу правильно!",
                Font = new Font("Palatino Linotype", 11, FontStyle.Regular),
                Size = new Size(322, 54),
                Location = new Point(Size.Width / 2 - 332, richTextBox1.Location.Y + richTextBox1.Height + 18)
            };
            var button2 = new Button()
            {
                Text = "Я написал формулу неправильно :(",
                Font = new Font("Palatino Linotype", 11, FontStyle.Regular),
                Size = new Size(322, 54),
                Location = new Point(Size.Width / 2 + 10, richTextBox1.Location.Y + richTextBox1.Height + 18)
            };

            Controls.Add(label);
            Controls.Add(label1);

            Start();

            void Start()
            {
                var Question = train.TakeQuestion();
                if (Question == null) //Значит вопросы закончились
                {
                    this.Hide();
                    Statistic Form = new Statistic(train);
                    Form.Show();
                    return;
                }

                label.Text = "Формула: " + Question.Name;
                label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
                label.Location = new Point((Size.Width - label.Width) / 2, 90);

                label1.Location = new Point((Size.Width - label1.Width) / 2, label.Location.Y + 30);

                button1.Click += button1_Click;
                button2.Click += button2_Click;

                richTextBox1.KeyDown += richTextBox1_KeyDown;

                //Показ правильной формулы по нажатию клавиши Enter
                void richTextBox1_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        richTextBox1.Text = Question.Data;
                        // После показа формулы появляются кнопки для проверки ответа 
                        Controls.Add(button1);
                        Controls.Add(button2);
                    }
                }
                //После проверки ответа кнопки пропадают и метод запускается заново
                void button1_Click(object sender1, EventArgs e1)
                {
                    train.CheckAnswer(Question, 1);

                    Controls.Remove(button1);
                    Controls.Remove(button2);
                    button1.Click -= button1_Click;
                    button2.Click -= button2_Click;
                    richTextBox1.Clear();

                    Start();
                }
                void button2_Click(object sender1, EventArgs e1)
                {
                    train.CheckAnswer(Question, 0);

                    Controls.Remove(button1);
                    Controls.Remove(button2);
                    button1.Click -= button1_Click;
                    button2.Click -= button2_Click;
                    richTextBox1.Clear();

                    Start();
                }
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
