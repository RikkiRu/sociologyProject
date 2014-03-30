using System;
using System.Windows.Forms;

using unoidl.com.sun.star.lang;
using unoidl.com.sun.star.frame;
using OOo = unoidl.com.sun.star;

namespace sociology
{
    public partial class resultsForm : Form
    {
        opros res;

        public resultsForm(string way)
        {
            InitializeComponent();
            res = new opros();
            if (!res.load(way)) { MessageBox.Show("Выбраный файл не является опросом"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //данные ответов
            AnswersData ad = new AnswersData(res);
            ad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OproshinieData od = new OproshinieData(res);
            od.ShowDialog();
        }

        OOo.sheet.XSpreadsheet InitOffice()
        {
            OOo.uno.XComponentContext Context = uno.util.Bootstrap.bootstrap();
            OOo.lang.XMultiServiceFactory Factory = (OOo.lang.XMultiServiceFactory)Context.getServiceManager();
            XComponentLoader componentLoad = (XComponentLoader)Factory.createInstance("com.sun.star.frame.Desktop");
            XComponent xCom = componentLoad.loadComponentFromURL("private:factory/scalc", "_blank", 0, new OOo.beans.PropertyValue[0]);
            OOo.sheet.XSpreadsheets d = (OOo.sheet.XSpreadsheets)(((OOo.sheet.XSpreadsheetDocument)xCom).getSheets());
            uno.Any t = d.getByName(d.getElementNames()[0]);
            OOo.sheet.XSpreadsheet f = (OOo.sheet.XSpreadsheet)t.Value;
            return f;
        }

        void SetText(OOo.sheet.XSpreadsheet f, int x, int y, string text)
        {
            OOo.table.XCell cc = f.getCellByPosition(x, y);
            cc.setFormula(text);
        }

        void SetText(OOo.sheet.XSpreadsheet f, int x, int y, string text, int size)
        {
            SetText(f, x, y, text);
            SetStyleTitle(f, x, y, size);
        }

        void SetStyleTitle(OOo.sheet.XSpreadsheet f, int x, int y, int FontSize)
        {
            OOo.table.XCellRange xRange = (OOo.table.XCellRange)f.getCellByPosition(x, y);
            OOo.beans.XPropertySet options = (OOo.beans.XPropertySet)xRange;
            options.setPropertyValue("CharHeight", new uno.Any((Single)FontSize));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OOo.sheet.XSpreadsheet f = InitOffice();
                SetText(f, 0, 0, "Анкеты", 16);
                int stroka = 1;
                SetText(f, 0, stroka, "№", 12);

                for (int i = 0; i < res.anketa.Count; i++)
                {
                    SetText(f, i + 1, stroka, res.anketa[i], 12);
                }
                stroka++;

                for (int i = 0; i < res.testers.Count; i++)
                {
                    SetText(f, 0, stroka, (i+1).ToString());
                    for (int j = 0; j < res.testers[i].anketa.Count; j++)
                    {
                        SetText(f, j + 1, stroka, res.testers[i].anketa[j]);
                    }
                    stroka++;
                }
                stroka++;

                SetText(f, 0, stroka, "Данные ответов", 16);
                stroka++;
                for (int i = 0; i < res.selectedOprosnik.elements.Count; i++)
                {
                    SetText(f, 0, stroka, res.selectedOprosnik.elements[i].question, 12);
                    stroka++;
                    stroka = infoAnsw(f, stroka, res.selectedOprosnik.elements[i].question);
                    stroka++;
                }
                stroka++;

                SetText(f, 0, stroka, "Данные по каждому опрошенному", 16);
                stroka++;
                for (int i = 0; i < res.testers.Count; i++)
                {
                    SetText(f, 0, stroka, "Номер", 14);
                    SetText(f, 1, stroka, (i+1).ToString(), 14);
                    stroka++;
                    for (int j = 0; j < res.selectedOprosnik.elements.Count; j++)
                    {
                        SetText(f, 0, stroka, res.selectedOprosnik.elements[j].question, 10);
                        stroka++;
                        for (int k = 0; k < res.testers[i].answers[j].SelectedAnswers.Count; k++)
                        {
                            bool otv = res.testers[i].answers[j].SelectedAnswers[k];
                            string temp = "0";
                            if (otv) temp = "1";
                            SetText(f, 0, stroka, temp, 8);
                            SetText(f, 1, stroka, res.selectedOprosnik.elements[j].answers[k], 8);
                            stroka++;
                        }
                        stroka++;
                    }
                    stroka++;
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int infoAnsw(OOo.sheet.XSpreadsheet f, int stroka, string find)
        {
            oprosnikElem x = new oprosnikElem();
            int nAnsw = 0;
            for (int i = 0; i < res.selectedOprosnik.elements.Count; i++)
            {
                if (res.selectedOprosnik.elements[i].question == find)
                {
                    x = res.selectedOprosnik.elements[i];
                    nAnsw = i;
                    break;
                }
            }

            for (int i = 0; i < x.answers.Count; i++)
            {
                SetText(f, 0, stroka, x.answers[i]);

                float temp = 0;
                foreach (var it in res.testers)
                {
                    if (it.answers[nAnsw].SelectedAnswers[i] == true) temp++;
                }
                SetText(f, 1, stroka, temp.ToString());
                if (res.testers.Count != 0) temp = temp * 100 / res.testers.Count;
                SetText(f, 2, stroka, temp.ToString());
                stroka++;
            }

            return stroka;
        }

    }
}
