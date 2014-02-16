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
        Testsheet test;
        List<Question> questionData = new List<Question>();
        List<RadioButton> RadioButtonList;
       
        /*
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
        */
        
        
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;

            test = new Testsheet("Name234", 1);

            //List of Questions

            for (int i = 0; i < 5; i++)
		    {
			    questionData.Add(new Question());
		    }
            

            //Метод, заполняющий список данными из базы

            //Initialization of Questions

            //1
            questionData[0].questionText = "Какое изображение называется видом?";
            //Variants
            questionData[0].answers.Add("Изображение фигуры, получающейся при мысленном рассечении предмета одной или несколькими плоскостями с показом того, что получается в секущей плоскости", false);
            questionData[0].answers.Add("Изображение обращенной к наблюдателю видимой части поверхности предмета", false);
            questionData[0].answers.Add("Изображение предмета, мысленно рассеченного одной или несколькими плоскостями с показом того, что получается в секущей плоскости и что расположено за ней", true);
            questionData[0].answers.Add("Дополнительное отдельное изображение какой-либо части предмета, требующей графического и других поясненй в отношении формы, размеров и других данных", false);
            questionData[0].answers.Add("Разрез, служащий для выяснения устройства предмета лишь в отдельном, ограниченном месте", false);

            questionData[0].image = "path";

            //2
            questionData[1].questionText = "Какое изображение является видом спереди?";
            //Variants
            questionData[1].answers.Add("1", true);
            questionData[1].answers.Add("2", false);
            questionData[1].answers.Add("3", false);
            questionData[1].answers.Add("4", false);
            questionData[1].answers.Add("5", false);

            questionData[1].image = "path";

            //3
            questionData[2].questionText = "Как называется изображение 3?";
            //Variants
            questionData[2].answers.Add("Главный вид", false);
            questionData[2].answers.Add("Вид сверху", true);
            questionData[2].answers.Add("Вид слева", false);
            questionData[2].answers.Add("Местный вид", false);
            questionData[2].answers.Add("Сечение", false);

            questionData[2].image = "path";

            //4
            questionData[3].questionText = "Как называется изображение А-А?";
            //Variants
            questionData[3].answers.Add("Фронтальный разрез", false);
            questionData[3].answers.Add("Горизонтальный разрез", false);
            questionData[3].answers.Add("Профильный разрез", false);
            questionData[3].answers.Add("Ломаный разрез", false);
            questionData[3].answers.Add("Сложный ступенчатый фронтальный разрез", true);

            questionData[3].image = "path";

            //5
            questionData[4].questionText = "Как называется изображение А-А?";
            //Variants
            questionData[4].answers.Add("Наложенное сечение", false);
            questionData[4].answers.Add("Выносной элемент", false);
            questionData[4].answers.Add("Сечение, входящее в состав разреза", false);
            questionData[4].answers.Add("Вынесенное сечение", true);
            questionData[4].answers.Add("Местный разрез", false);

            questionData[4].image = "path";


            //Заполнение списка объекта Тест

            test.FillQuestions(questionData);


            //Method, creating list of  RadioButtons
            RadioButtonList = new List<RadioButton>();
            RadioButtonList.Add(radioButton1);
            RadioButtonList.Add(radioButton2);
            RadioButtonList.Add(radioButton3);
            RadioButtonList.Add(radioButton4);
            RadioButtonList.Add(radioButton5);

        }


        void UpdatingForm()
        {
            label1.Text = questionNum.ToString();
            groupBox1.Text = test.questions[questionNum - 1].questionText;
            int i = 0;
            foreach (KeyValuePair<string, bool> s in test.questions[questionNum - 1].answers)
            {
                RadioButtonList[i].Text = s.Key;
                i++;
            }
            //picture
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (questionNum == 4)
            { 
                button2.Enabled = false; 
            }

            if (questionNum != 5)
            {
                questionNum++;
            }

            button1.Enabled = true;

            //Method of updating results;


            //Method of updating form;
            UpdatingForm();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (questionNum == 2)
            {
                button1.Enabled = false;
            }
            
            if(questionNum != 1)
            {
             questionNum--;
            }

            button2.Enabled = true;

            //Method of updating form;
            UpdatingForm();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // if(sender.checked)
           // {
                
           // }
        }
    }
}
