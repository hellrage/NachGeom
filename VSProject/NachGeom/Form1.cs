using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int questionNum = 1;
        classVariant objVariant = new classVariant();
        classVariant.classQuestion objQuestion1 = new classVariant.classQuestion();
        classVariant.classQuestion objQuestion2 = new classVariant.classQuestion();
        classVariant.classQuestion objQuestion3 = new classVariant.classQuestion();
        classVariant.classQuestion objQuestion4 = new classVariant.classQuestion();
        classVariant.classQuestion objQuestion5 = new classVariant.classQuestion();

        int i;
        string[] rad1 = {"1", "Главный вид", "Фронтальный разрез", "Наложенное сечение"};
        string[] rad2 = { "2", "Вид сверху", "Горизонтальный разрез", "Выносной элемент" };
        string[] rad3 = { "3", "Вид слева", "Профильный разрез", "Сечение, входящее в состав разреза" };
        string[] rad4 = { "4", "Местный вид", "Ломаный разрез", "Вынесенное сечение" };
        string[] rad5 = { "5", "Сечение", "Сложный ступенчатый фронтальный разрез", "Местный разрез" };
        string[] group = { "Какое изображение является видом спереди?", 
                             "Как называется изображение 3?", 
                             "Как называется изображение А-А?", 
                             "Как называется изображение А-А?" };
        int[] answ = { 3, 1, 2, 5, 4 };
    
        
        
        public Form1()
        {
            InitializeComponent();

            button1.Enabled = false;


            //Initializaton of objVariant

            objVariant.Answers = new Dictionary<int, bool>();
            for (int i = 1; i <= 5; i++)
            {
                objVariant.Answers.Add(i , false);
            }
            objVariant.Name = "11";
            objVariant.SurName = "11";
            objVariant.Date = "11";
            objVariant.Mark = 2;


            //Initialization of objQuestions


            //1
            objQuestion1.Question = "Какое изображение называется видом?";
            //Variants
            objQuestion1.dicAnswers.Add("Изображение фигуры, получающейся при мысленном рассечении предмета одной или несколькими плоскостями с показом того, что получается в секущей плоскости", false);
            objQuestion1.dicAnswers.Add("Изображение обращенной к наблюдателю видимой части поверхности предмета", false);
            objQuestion1.dicAnswers.Add("Изображение предмета, мысленно рассеченного одной или несколькими плоскостями с показом того, что получается в секущей плоскости и что расположено за ней", true);
            objQuestion1.dicAnswers.Add("Дополнительное отдельное изображение какой-либо части предмета, требующей графического и других поясненй в отношении формы, размеров и других данных", false);
            objQuestion1.dicAnswers.Add("Разрез, служащий для выяснения устройства предмета лишь в отдельном, ограниченном месте", false);

            objQuestion1.Picture = "path";

            //2
            objQuestion2.Question = "Какое изображение является видом спереди?";
            //Variants
            objQuestion2.dicAnswers.Add("1", true);
            objQuestion2.dicAnswers.Add("2", false);
            objQuestion2.dicAnswers.Add("3", false);
            objQuestion2.dicAnswers.Add("4", false);
            objQuestion2.dicAnswers.Add("5", false);

            objQuestion2.Picture = "path";

            //3
            objQuestion3.Question = "Как называется изображение 3?";
            //Variants
            objQuestion3.dicAnswers.Add("Главный вид", false);
            objQuestion3.dicAnswers.Add("Вид сверху", true);
            objQuestion3.dicAnswers.Add("Вид слева", false);
            objQuestion3.dicAnswers.Add("Местный вид", false);
            objQuestion3.dicAnswers.Add("Сечение", false);

            objQuestion3.Picture = "path";

            //4
            objQuestion4.Question = "Как называется изображение А-А?";
            //Variants
            objQuestion4.dicAnswers.Add("Фронтальный разрез", false);
            objQuestion4.dicAnswers.Add("Горизонтальный разрез", false);
            objQuestion4.dicAnswers.Add("Профильный разрез", false);
            objQuestion4.dicAnswers.Add("Ломаный разрез", false);
            objQuestion4.dicAnswers.Add("Сложный ступенчатый фронтальный разрез", true);

            objQuestion4.Picture = "path";

            //5
            objQuestion5.Question = "Как называется изображение А-А?";
            //Variants
            objQuestion5.dicAnswers.Add("Наложенное сечение", false);
            objQuestion5.dicAnswers.Add("Выносной элемент", false);
            objQuestion5.dicAnswers.Add("Сечение, входящее в состав разреза", false);
            objQuestion5.dicAnswers.Add("Вынесенное сечение", true);
            objQuestion5.dicAnswers.Add("Местный разрез", false);

            objQuestion5.Picture = "path";

            //Method, creating list of lables
            //List<???>
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (questionNum == 5)
            { 
                button2.Enabled = false; 
            }
            else 
            { 
                button1.Enabled = true;
                questionNum++; 
            }

            //Method of updating form;
            groupBox1.Text = objQuestion[questionNum].Question;
            radioButton1.Text = rad1[questionNum];
            radioButton2.Text = rad2[questionNum];
            radioButton3.Text = rad3[questionNum];
            radioButton4.Text = rad4[questionNum];
            radioButton5.Text = rad5[questionNum];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (questionNum == 1)
            {
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                questionNum--;
            }

            //Method of updating form;
            groupBox1.Text = objQuestion[questionNum].Question;
            radioButton1.Text = rad1[questionNum];
            radioButton2.Text = rad2[questionNum];
            radioButton3.Text = rad3[questionNum];
            radioButton4.Text = rad4[questionNum];
            radioButton5.Text = rad5[questionNum];
        }
    }
}
