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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрывает окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Переход к окну со статистикой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Statistic_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Переход к окну с тестом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Train NewForm = new Train();
            NewForm.Show();
        }
    }
}
