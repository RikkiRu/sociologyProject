using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sociology
{
    class tester
    {
        public List<answer> answers;
        public string FIO;

        public tester(string fio)
        {
            FIO = fio;
            answers = new List<answer>();
        }
    }

    class opros
    {
        public int maxTesters;
        public string Description;
        public List<tester> testers;
        public oprosnik selectedOprosnik;
        public bool IsAnonimus;

        public opros(int TestersCount, string Description, oprosnik Oprosnik, bool anonimno)
        {
            testers = new List<tester>();
            maxTesters = TestersCount;
            this.Description = Description;
            selectedOprosnik = new oprosnik();
            foreach (var x in Oprosnik.elements)
            {
                selectedOprosnik.addNewElement(x.question, x.answers, x.IsOneVariant);
            }
            IsAnonimus = anonimno;
        }
    }

    class answer
    {
        public List<bool> SelectedAnswers;

        public answer(List<bool> Variants)
        {
            SelectedAnswers = new List<bool>();
            foreach (bool b in Variants)
            {
                SelectedAnswers.Add(b);
            }
        }
    }
}
