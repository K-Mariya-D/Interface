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
        public Train(string theme)
        {
            InitializeComponent();
            StartTrain(theme);
        }
        public void StartTrain(string theme)
        {
            var train = new TheoryTrainer();
            train.Start(theme);


            Label label = new Label();
            var Question = train.TakeQuestion();
            label.Text = "Формула: " + Question.Name;
            label.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            label.Size = new Size(label.PreferredWidth, label.PreferredHeight);
            label.Location = new Point((Size.Width - label.Width) / 2, 90);

            Label label1 = new Label();
            label1.Text = "Можете ввести формулу ниже или записать у себя на листке.\nДля того чтобы узнать правильную формулу нажмите Enter>>";
            label1.Font = new Font("Palatino Linotype", 12, FontStyle.Regular);
            label1.Size = new Size(label1.PreferredWidth, label1.PreferredHeight);
            label1.Location = new Point((Size.Width - label1.Width) / 2, label.Location.Y + 30);
            /*
                 Console.WriteLine("Нажмите enter для вывода правильной формулы");
                 Console.ReadLine();
                 Console.WriteLine(rand_formula.Data);
                 Console.WriteLine("Введите '1', если правильно написали формулу, иначе введите '0'");
                 int ress = int.Parse(Console.ReadLine());
                 if (ress == 0)
                     mistakescnt[rand_formula] += 1;
                 else
                     formulas_lst.Remove(rand_formula);
                 Test1(); 
                */
            Controls.Add(label);
            Controls.Add(label1);

            richTextBox1.KeyDown += richTextBox1_KeyDown;

            //Показ правильной формулы по нажатию клавиши Enter
            void richTextBox1_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    richTextBox1.Text = Question.Data;
                    // Здесь же написать кнопки для проверки правильности написанной формулы (из конструктора удалить)
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
