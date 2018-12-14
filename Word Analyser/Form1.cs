using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Analyser
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int timesAnalysed = 0;

        void StringTheory(string inTxt) // splits up words, gets data, and analyzes it all in one neat function
        {
            string[] words = inTxt.Split(' ');
            string curWord;
            int totalWLength = 0; //number of letters in words from the article (WILL DIVIDE BY # OF WORDS TO GET AVG WORD LENGTH)
            int numofSentences = 0;
            int numofWords = 0; //in the current sentence, not of the entire article
            List<int> sLengths = new List<int>(); //numbers of words in all the sentences
            bool sentEnd = false;
            int CmpSents = 0; // num of compound sentences
            int semicolons = 0;
            int colons = 0;
            bool hasPunc = false;

            for (int i = 0; i < words.Length; i++) //gets data
            {
                curWord = words[i];
                if (i > words.Length)
                {
                    break;
                }
                hasPunc = false;
                sentEnd = false;

                if (curWord.Contains('.'))
                {
                    hasPunc = true;
                    if (curWord == "Dr." || curWord == "Mr." || curWord == "Mrs.") // period used as end of sentence
                    {
                        sentEnd = false;
                    }

                    if (curWord.Contains('0')|| curWord.Contains('1') || curWord.Contains('2') || curWord.Contains('3') || curWord.Contains('4') || curWord.Contains('5') || curWord.Contains('6') || curWord.Contains('7') || curWord.Contains('8') || curWord.Contains('9'))
                    {
                        sentEnd = false;
                    }

                    else sentEnd = true;
                }

                else if (curWord.Contains('?') || curWord.Contains('!'))
                {
                    hasPunc = true;
                    sentEnd = true;
                }

                if (curWord.Contains(',') && (words[i + 1] == "for" || words[i + 1] == "and" || words[i + 1] == "but" || words[i + 1] == "or" || words[i + 1] == "yet" || words[i + 1] == "so"))
                //, and a conjunction singifying a compound sentence
                {
                    CmpSents++;
                }

                if (curWord.Contains(';'))
                {
                    hasPunc = true;
                    semicolons++;
                    CmpSents++;
                }


                if (curWord.Contains(':'))
                {
                    hasPunc = true;
                    colons++;
                }

                if (hasPunc) { totalWLength += curWord.Length - 1; }
                else
                {
                    totalWLength += curWord.Length;
                }
                numofWords++;

                if (sentEnd)
                {
                    sLengths.Add(numofWords);
                    numofSentences++;
                    numofWords = 0;
                }
            }

            float avgWordLength; // average length of words
            avgWordLength = (float)totalWLength / (float)words.Length;
            float avgWordsInSent = 0;
            try
            {
                avgWordsInSent = (float)sLengths.Sum() / (float)numofSentences;
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Divide by zero error. Are there zero sentences?");
                avgWordsInSent = 0;
                numofSentences = 0;
            }
            List<int> dataInts = new List<int>(5)
            {
                words.Length, numofSentences, semicolons, colons, CmpSents
            };

            output(avgWordLength, avgWordsInSent, dataInts);
        }

        void output(float aWL, float aWIS, List<int> dataInts)
        {
            table.Rows.Add();
            table.Rows[timesAnalysed].Cells[0].ReadOnly = false;
            table.Rows[timesAnalysed].Cells[0].Value = "Enter article name here.";
            table.Rows[timesAnalysed].Cells[1].Value = dataInts[0];
            table.Rows[timesAnalysed].Cells[2].Value = dataInts[1];
            table.Rows[timesAnalysed].Cells[3].ValueType = typeof(float);
            table.Rows[timesAnalysed].Cells[3].Value = aWL;
            table.Rows[timesAnalysed].Cells[4].ValueType = typeof(float);
            table.Rows[timesAnalysed].Cells[4].Value = aWIS;
            table.Rows[timesAnalysed].Cells[5].Value = dataInts[2];
            table.Rows[timesAnalysed].Cells[6].Value = dataInts[3];
            table.Rows[timesAnalysed].Cells[7].Value = dataInts[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inText = this.inputBox.Text;
            StringTheory(inText);
            timesAnalysed++;
        }
    }
}

