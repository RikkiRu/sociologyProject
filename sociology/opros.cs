﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

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

        public bool load(string way)
        {
            try
            {
                FileStream fs = new FileStream(way, FileMode.Open);
                using (StreamReader sw = new StreamReader(fs))
                {
                    string temp="";

                    temp=sw.ReadLine();
                    if (temp != "!realOprosFile!") return false;

                    maxTesters = Convert.ToInt32(sw.ReadLine());

                    temp = sw.ReadLine();
                    while (temp != "!endDescr!")
                    {
                        Description += temp+Environment.NewLine;
                        temp = sw.ReadLine();
                    }
                    IsAnonimus = Convert.ToBoolean(sw.ReadLine());

                    temp = sw.ReadLine();
                    while (temp != "!endGenAnketa!")
                    {
                        anketa.Add(temp);
                        temp = sw.ReadLine();
                    }

                    temp = sw.ReadLine();

                    while (temp != "!oprosnik!")
                    {
                        tester t = new tester();
                        while (temp != "!next!")
                        {
                            while (temp != "!endAnketa!")
                            {
                                t.anketa.Add(temp);
                                temp = sw.ReadLine();
                            }
                            temp = sw.ReadLine();

                            while (temp != "!next!")
                            {

                                if (temp != "!next!")
                                {
                                    List<bool> variant = new List<bool>();
                                    while (temp != "!newAnsw!")
                                    {
                                        if (temp == "+") variant.Add(true);
                                        else variant.Add(false);
                                        temp = sw.ReadLine();
                                    }
                                    t.answers.Add(new answer(variant));
                                    temp = sw.ReadLine();
                                }
                            }
                        }
                        temp = sw.ReadLine();
                        testers.Add(t);
                    }

                    temp = sw.ReadLine();
                    while (temp != "!END!")
                    {
                        oprosnikElem x = new oprosnikElem();
                        x.IsOneVariant = Convert.ToBoolean(temp);
                        x.question = sw.ReadLine();
                        temp = sw.ReadLine();
                        while (temp != "!next!")
                        {
                            x.answers.Add(temp);
                            temp = sw.ReadLine();
                        }
                        temp = sw.ReadLine();
                        selectedOprosnik.elements.Add(x);
                    }
                
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке" + Environment.NewLine + ex.Message);
            }
            return true;
        }

        public void save(string way)
        {
            FileStream fs = new FileStream(way, FileMode.Create);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine("!realOprosFile!");
                sw.WriteLine(maxTesters.ToString());
                sw.WriteLine(Description);
                sw.WriteLine("!endDescr!");
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
                            if (b) sw.WriteLine("+");
                            else sw.WriteLine("-");
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

        public opros() 
        { 
            testers = new List<tester>();
            selectedOprosnik = new oprosnik();
            anketa = new List<string>();
        }

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

        public bool connectOpr (string add)
        {
            opros op = new opros();
            if (!op.load(add)) return false;

            if (this.anketa.Count != op.anketa.Count) return false;
            for (int i=0; i<op.anketa.Count; i++)
            {
                if (this.anketa[i] != op.anketa[i]) return false;
            }

            foreach (var x in op.testers)
            {
                tester t = new tester();
                foreach (var a in x.anketa)
                {
                    t.anketa.Add(a);
                }
                foreach (var a in x.answers)
                {
                    answer answ = new answer(new List<bool>());
                    foreach (var b in a.SelectedAnswers)
                    {
                        answ.SelectedAnswers.Add(b);
                    }
                    t.answers.Add(answ);
                }
                this.testers.Add(t);
            }
            return true;
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
