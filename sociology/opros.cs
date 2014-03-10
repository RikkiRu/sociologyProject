using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace sociology
{
    public class tester
    {
        public List<answer> answers;
        public List<string> anketa;

        public tester()
        {
            answers = new List<answer>();
            anketa = new List<string>();
        }
    }

    public class opros
    {
        public int maxTesters;
        public string Description;
        public List<tester> testers;
        public oprosnik selectedOprosnik;
        public bool IsAnonimus;
        public List<string> anketa;

        public void save(string way)
        {
            FileStream fs = new FileStream(way, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(maxTesters.ToString());
                sw.WriteLine(Description);
                sw.WriteLine(IsAnonimus.ToString());

                foreach (string s in anketa)
                {
                    sw.WriteLine(s);
                }
                sw.WriteLine("!endGenAnketa!");

                foreach (var a in testers)
                {
                    foreach (var b in a.anketa)
                    {
                        sw.WriteLine(b);
                    }
                    sw.WriteLine("!endAnketa!");

                    foreach (var c in a.answers)
                    {
                        foreach (bool b in c.SelectedAnswers)
                        {
                            sw.WriteLine(b.ToString());
                        }
                        sw.WriteLine("!newAnsw!");
                    }

                    sw.WriteLine("!next!");
                }


               
                    sw.WriteLine("!oprosnik!");
                    foreach (var x in selectedOprosnik.elements)
                    {
                        sw.WriteLine(x.IsOneVariant.ToString());
                        sw.WriteLine(x.question);
                        foreach (var t in x.answers)
                        {
                            sw.WriteLine(t);
                        }
                        sw.WriteLine("!next!");
                    }
                    sw.WriteLine("!END!");
                

            }
        }

        public opros() { }

        public opros(int TestersCount, string Description, oprosnik Oprosnik, bool anonimno, List<string> Anketa)
        {
            testers = new List<tester>();
            maxTesters = TestersCount;
            this.Description = Description;
            selectedOprosnik = new oprosnik();
            foreach (var x in Oprosnik.elements)
            {
                selectedOprosnik.addNewElement(x.question, x.answers, x.IsOneVariant);
            }

            anketa = new List<string>();
            foreach (var x in Anketa)
            {
                anketa.Add(x);
            }

            IsAnonimus = anonimno;
        }
    }

    public class answer
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
