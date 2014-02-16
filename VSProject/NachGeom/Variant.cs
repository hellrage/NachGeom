using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    class classVariant
    {
        public Dictionary<int, bool> Answers;
            
            //= new Dictionary<int, bool>();

        //initilization
        //for(int i = 1; int <= 5; i++){

        public int Variant;
        public string SurName;
        public string Name;
        public string Date;
        public int Mark;

        public class classQuestion
        {
            public string Question;
            public Dictionary<string, bool> dicAnswers;
            public string Picture;
        }

            

    }
}
