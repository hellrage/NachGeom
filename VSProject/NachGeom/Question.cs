using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Question
    {
        
        public Dictionary<string, bool> answers;
        public string questionText;
        public string image;

        public Question()
        {
            this.answers = new Dictionary<string, bool>();
        }
        
    }
}
