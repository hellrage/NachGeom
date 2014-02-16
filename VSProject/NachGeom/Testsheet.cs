using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    public class Testsheet
    {
        public List<Question> questions;

        
        private string name;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }


        public int Variant;
        public Dictionary<int, bool> results;


        //Конструктор
        public Testsheet(string Name, int Variant)
        {
            this.name = Name;
            this.Variant = Variant;

            this.questions = new List<Question>();

            this.results = new Dictionary<int, bool>();
            for (int i = 1; i <= 5; i++)
            {
                this.results.Add(i, false);
            }

        }

        //Заполнение вопросов объекта типа Testsheet
        public void FillQuestions(List<Question> questions)
        {
            foreach (Question q in questions)
            {
                this.questions.Add(q);
            }
        }

    }
}
