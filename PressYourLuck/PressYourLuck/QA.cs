///Filename:QA.cs
///Class for questions and answer
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyluck
{
    class QA
    {
        private string question;
        private string answer;

        //constructor
        public QA()
        {
            question = "";
            answer = "";
        }

        public QA(string q,string a)
        {
            this.question = q;
            this.answer = a;
        }

        //getters and setters for question and answer
        public string Q
        {
            get { return question; }
            set { question = value; }
        }

        public string A
        {
            get { return answer; }
            set { answer = value; }
        }
    }
}
