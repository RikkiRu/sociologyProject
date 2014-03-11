using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System;
using System.Windows.Forms;

namespace sociology
{
    public class oprosnik
    {
        public List<oprosnikElem> elements;

        public oprosnik()
        {
            elements = new List<oprosnikElem>();
        }

        public void addNewElement(string question, List<string> answers, bool IsOneVariant)
        {
            elements.Add(new oprosnikElem(question, answers, IsOneVariant));
        }

        public void Save(string way)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<oprosnikElem>));
                FileStream fs = new FileStream(way, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    ser.Serialize(sw, elements);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Load(string way)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<oprosnikElem>));
                FileStream fs = new FileStream(way, FileMode.Open);
                using (StreamReader sr = new StreamReader(fs))
                {
                    elements = ser.Deserialize(sr) as List<oprosnikElem>;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class oprosnikElem
    {
        public bool IsOneVariant;
        public string question;
        public List<string> answers;
        public oprosnikElem(string question, List<string> answers, bool IsOneVariant)
        {
            this.question = question;
            this.answers = answers;
            this.IsOneVariant = IsOneVariant;
        }

        public oprosnikElem() 
        {
            answers = new List<string>();
        }
    }
}
