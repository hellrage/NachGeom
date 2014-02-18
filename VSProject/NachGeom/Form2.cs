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
    public partial class Form2 : Form
    {
        int questionNum = 1;
        

        List<Question> questionData = new List<Question>();
        List<RadioButton> RadioButtonList;
        List<RadioButton> RadioButtonListCash;
        
               
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
        
        public Form2()
        {
            InitializeComponent();
            buttonPrev.Enabled = false;
            pMain.currentTest = new Testsheet("Name234", 1);
            pMain.studentName = "Vasya";
            pMain.studentSurname = "Petrov";
            pMain.studentFname = "Petrovich";
            pMain.Faculty = "IU";
            pMain.Group = "IU4-23";
            pMain.testStart = DateTime.Now;


            //onceMaingForm
            toolStripStatusStudentName.Text = "Имя студента: " + pMain.studentName;
            toolStripStatusVariant.Text = "Вариант: " + pMain.currentTest.Variant.ToString();
            toolStripStatusTime.Text = "Время выполнения: " + (DateTime.Now - pMain.testStart).ToString("hh':'mm':'ss");
            this.Text = "Тест: " + pMain.currentTest.testName;
            

            //List of Questions

            for (int i = 0; i < 5; i++)
			    questionData.Add(new Question());

            //Метод, заполняющий список данными из базы

            //Initialization of Questions

            //1
            questionData[0].questionText = "Какое изображение называется видом?";
            //Variants
            questionData[0].answers.Add("Изображение фигуры, получающейся при мысленном рассечении предмета одной или несколькими плоскостями с показом того, что получается в секущей плоскости", false);
            questionData[0].answers.Add("Изображение обращенной к наблюдателю видимой части поверхности предмета", true);
            questionData[0].answers.Add("Изображение предмета, мысленно рассеченного одной или несколькими плоскостями с показом того, что получается в секущей плоскости и что расположено за ней", false);
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

            pMain.currentTest.FillQuestions(questionData);

            //Method, creating list of  RadioButtons
            RadioButtonList = new List<RadioButton>();
            RadioButtonList.Add(radioButton1);
            RadioButtonList.Add(radioButton2);
            RadioButtonList.Add(radioButton3);
            RadioButtonList.Add(radioButton4);
            RadioButtonList.Add(radioButton5);
            
            UpdatingForm();
            Debugging();
        }

        void Debugging()
        {
            //debugging
            label1.Text = "";
            for (int i = 1; i <= 5; i++)
                label1.Text += pMain.currentTest.results[i].ToString();
            label2.Text = "";
            for (int i = 1; i <= 5; i++)
                label2.Text += pMain.currentTest.chosenAnswers[i].ToString();
            label3.Text = questionNum.ToString();
        }


        void AnalisationOfAnswer()
        {
            int i = 1;
            foreach (RadioButton r in RadioButtonList)
            {
                
                if (r.Checked)
                {
                    pMain.currentTest.UpdateResults(questionNum, pMain.currentTest.questions[questionNum - 1].answers[r.Text]);
                    pMain.currentTest.chosenAnswers[questionNum] = i;
                }
                i++;
            }
        }

        void RadioButtonChecking()
        {
            AnalisationOfAnswer();
            
            //Updating ProgressBar
            int progressBarValue = 0;
            for (int i = 1; i < 6; i++)
            {
                if (pMain.currentTest.chosenAnswers[i] != 0)
                    progressBarValue++;
            }
            toolStripProgressBar1.Value = progressBarValue;

            //Updating buttonUnanswered
            bool allAnswered = true;
            for (int i = 1; i < 6; i++)
                if (pMain.currentTest.chosenAnswers[i] == 0)
                    allAnswered = false;
            if (allAnswered)
                buttonUnanswered.Enabled = false;

            Debugging();
        }


        void UpdatingForm()
        {
            //creating cash list
            RadioButtonListCash = new List<RadioButton>();
            RadioButtonListCash.Add(radioButton1);
            RadioButtonListCash.Add(radioButton2);
            RadioButtonListCash.Add(radioButton3);
            RadioButtonListCash.Add(radioButton4);
            RadioButtonListCash.Add(radioButton5);

            //Disabling and Enabling buttons
            if (questionNum == 1)
                buttonPrev.Enabled = false;
            else
                buttonPrev.Enabled = true;
            if (questionNum == 5)
                buttonNext.Enabled = false; 
            else
                buttonNext.Enabled = true; 

           

            //Filling with text
            labelQuestionNum.Text = "Задание номер " + questionNum;
            groupBox1.Text = pMain.currentTest.questions[questionNum - 1].questionText;
            
            int j = 0;
            foreach (KeyValuePair<string, bool> s in pMain.currentTest.questions[questionNum - 1].answers)
            {
                RadioButtonListCash[j].Text = s.Key;
                j++;
            }


            //Cheking answers as was or placing "1"
            if (pMain.currentTest.chosenAnswers[questionNum] == 0)
            {
                foreach (RadioButton r in RadioButtonList)
                    r.Checked = false;
            }
            else
                RadioButtonList[pMain.currentTest.chosenAnswers[questionNum] - 1].Checked = true;

            //picture
            string path;
            path = "./Images/" + questionNum + ".jpg";
            pictureBox1.Image = Image.FromFile(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (questionNum != 5)
                questionNum++;

            buttonPrev.Enabled = true;
                        
            UpdatingForm();
            
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if(questionNum != 1)
                questionNum--;
            
            buttonNext.Enabled = true;
            
            UpdatingForm();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void buttonUnanswered_Click(object sender, EventArgs e)
        {
            if(pMain.currentTest.chosenAnswers[questionNum] != 0 )
                for (int i = 1; i < 6; i++)
                    if (pMain.currentTest.chosenAnswers[i] == 0)
                    {
                        questionNum = i;
                        UpdatingForm();
                        break;
                    }

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusTime.Text = "Время выполнения: " + (DateTime.Now - pMain.testStart).ToString("hh':'mm':'ss");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                RadioButtonChecking();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
                RadioButtonChecking();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
                RadioButtonChecking();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

                RadioButtonChecking();

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

                RadioButtonChecking();

        }

        

 




    }
}
