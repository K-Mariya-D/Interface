using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using MathTutorInterface;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.VisualStyles;

namespace MathTutor
{
    public class TheoryTrainer
    {
        public static Dictionary<string, List<Dictionary<Formula, int>>> statistics;
        private List<Formula> formulas_lst; //Формулы, используемые в тренировке
        private Dictionary<Formula, int> mistakescnt; //Кол-во ошибок по каждой формуле
        public TheoryTrainer()
        {
            formulas_lst = new List<Formula>();
            mistakescnt = new Dictionary<Formula, int>();
            statistics = new Dictionary<string, List<Dictionary<Formula, int>>>();
        }
        /// <summary>
        /// Запускает тест
        /// </summary>
        public void Start(string theme)
        {
            
            void Test()
            {
                ///Заполнение банка формул по теме тригонометрия из файла
                var formula_bank = new Dictionary<string, Formula[]>();

                string[] lines1 = File.ReadAllLines("тригонометрия.txt");
                Formula[] formulas1 = new Formula[lines1.Count()];
                for (int i = 0; i < lines1.Count(); i++)
                {
                    var NameData = Regex.Split(lines1[i], "<=>");
                    formulas1[i]=new Formula(NameData[0],NameData[1]);
                }
                formula_bank["тригонометрия"] = formulas1;

                ///Заполнение банка формул по теме производные из файла
                string[] lines2 = File.ReadAllLines("таблица производных.txt");
                Formula[] formulas2 = new Formula[lines2.Count()];
                for (int i = 0; i < lines2.Count(); i++)
                {
                    var NameData = Regex.Split(lines2[i], "<=>");
                    formulas2[i] = new Formula(NameData[0], NameData[1]);
                }
                formula_bank["таблица производных"] = formulas2;

                ///Заполнение банка формул по теме  интегралы из файла
                string[] lines3 = File.ReadAllLines("таблица интегралов.txt");
                Formula[] formulas3 = new Formula[lines3.Count()];
                for (int i = 0; i < lines3.Count(); i++)
                {
                    var NameData = Regex.Split(lines3[i], "<=>");
                    formulas3[i] = new Formula(NameData[0], NameData[1]);
                }
                formula_bank["таблица интегралов"] = formulas3;

                if (theme == "1")
                    foreach (var formula in formulas1)
                    {
                        formulas_lst.Add(formula);
                        mistakescnt[formula] = 0;
                    }
                else if (theme == "2")
                    foreach (var formula in formulas2)
                    {
                        formulas_lst.Add(formula);
                        mistakescnt[formula] = 0;
                    }
                else
                    foreach (var formula in formulas3)
                    {
                        formulas_lst.Add(formula);
                        mistakescnt[formula] = 0;
                    }

            }
            Test();
        }
        /// <summary>
        /// Возвращает один случайный вопрос из списка формул
        /// </summary>
        /// <returns></returns>
        public Formula TakeQuestion()
        {
            if (formulas_lst.Count() == 0)
                return null;

            var r = new Random();
            var rnd = r.Next(1, formulas_lst.Count() + 1);
            var rand_formula = formulas_lst.Take(rnd).Last();
            
            return rand_formula;
        }
        /// <summary>
        /// Проверка ответа по формуле 
        /// </summary>
        /// <param name="rand_formula"></param>
        /// <param name="res"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void CheckAnswer(Formula rand_formula, int res)
        {
            if (rand_formula == null)
                throw new ArgumentNullException();

            if (res == 0)
                mistakescnt[rand_formula] += 1;
            else
                formulas_lst.Remove(rand_formula);
        }
        /// <summary>
        /// Выводит на экран статистику ответов за указанное кол-во попыток
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="attemptsCnt"></param>
        public List<Dictionary<Formula, int>> ShowStatistics(string theme, int attemptsCnt)
        {
            //Добавление ошибочных ответов в статистику 
            if (theme == "1")
            {
                theme = "тригонометрия";
                if (!statistics.ContainsKey(theme))
                    statistics[theme] = new List<Dictionary<Formula, int>>();
                statistics[theme].Add(mistakescnt);
            }
            else if (theme == "2")
            {
                theme = "таблица производных";
                if (!statistics.ContainsKey(theme))
                    statistics[theme] = new List<Dictionary<Formula, int>>();
                statistics[theme].Add(mistakescnt);
            }
            else if (theme == "3")
            {
                theme = "таблица интегралов";
                if (!statistics.ContainsKey(theme))
                    statistics[theme] = new List<Dictionary<Formula, int>>();
                statistics[theme].Add(mistakescnt);
            }
            var res = new List<Dictionary<Formula, int>>();
            var Dict = new Dictionary<Formula, int>();

            var lastAttempts = statistics[theme].Skip(statistics[theme].Count-attemptsCnt);
            foreach (var attempt in lastAttempts)
            {
                foreach (var formulaa in attempt)
                {
                    Dict.Add(formulaa.Key, formulaa.Value);
                }
                res.Add(Dict);
            }
            return res;
        }
    }
}
