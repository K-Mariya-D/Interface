using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using MathTutorInterface;
//using System.Reflection.Emit;
using System.Windows.Forms;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.VisualStyles;

namespace MathTutor
{
    public class TheoryTrainer
    {
        public static Dictionary<string, List<Dictionary<Formula, int>>> statistics;
        public TheoryTrainer()
        {
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

                
                var formulas_lst = new List<Formula>();
                
                var mistakescnt = new Dictionary<Formula, int>(); //Кол-во ошибок по каждой формуле

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
                    }/*
                void Test1()
                {
                    if (formulas_lst.Count == 0)
                        return;
                    var r = new Random();
                    var rnd = r.Next(1, formulas_lst.Count);
                    var rand_formula = formulas_lst.Take(rnd).Last();
                    Console.WriteLine(rand_formula.Name);
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
                }
                Test1();
                if (theme == "1")
                {
                    if (!statistics.ContainsKey("тригонометрия"))
                        statistics["тригонометрия"] = new List<Dictionary<Formula, int>>();
                    statistics["тригонометрия"].Add(mistakescnt);
                }
                else if (theme == "2")
                {
                    if (!statistics.ContainsKey("таблица производных"))
                        statistics["таблица производных"] = new List<Dictionary<Formula, int>>();
                    statistics["таблица производных"].Add(mistakescnt);
                }
                else if (theme == "3")
                {
                    if (!statistics.ContainsKey("таблица интегралов"))
                        statistics["таблица интегралов"] = new List<Dictionary<Formula, int>>();
                    statistics["таблица интегралов"].Add(mistakescnt);
                }

                Console.WriteLine("Введите '1', если желаете пройти тест ещё раз, иначе введите '0'");
                int res = int.Parse(Console.ReadLine());
                if (res == 1)
                    Test();
                else
                    return;
                */
            }
            Test();
        }
        /// <summary>
        /// Выводит на экран статистику ответов за указанное кол-во попыток
        /// </summary>
        /// <param name="theme"></param>
        /// <param name="attemptsCnt"></param>
        public void ShowStatistics(string theme, int attemptsCnt)
        {
            Console.WriteLine(theme);
            var lastAttempts = statistics[theme].Skip(statistics[theme].Count-attemptsCnt);
            foreach (var attempt in lastAttempts)
            {
                foreach (var formulaa in attempt)
                {
                    Console.WriteLine($"{formulaa.Key} >>> кол-во ошибок >>> {formulaa.Value}");
                }
                Console.WriteLine();
            }
        }
    }
}
