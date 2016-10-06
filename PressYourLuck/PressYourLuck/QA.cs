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
        private string _question;
        private string _answer;

        //constructor
        public QA()
        {
            _question = "";
            _answer = "";
        }

        public QA(string q,string a)
        {
            this._question = q;
            this._answer = a;
        }

        //getters and setters for question and answer
        public string Q
        {
            get { return _question; }
            set { _question = value; }
        }

        public string A
        {
            get { return _answer; }
            set { _answer = value; }
        }
    }
}
