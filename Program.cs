using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace Digital_Design
{

    public class Words
    {
        public string words { get; set; }
        public int count { get; set; }
        public Words(string words, int count)
        {
            this.words = words;
            this.count = count;
        }

        public override string ToString()
        {
            return string.Format("{0,10}\t{1,10}", words, count);
        }
    }
    class Program
    {
        List<string> words = new List<string>();
        List<Words> wordsAndCount = new List<Words>();
        List<string> uniqueWords = new List<string>();

        static void Main()
        { 
            Program program = new Program();
            
            string fileStream = System.IO.File.ReadAllText("C:\\vs_projects\\Digital_Design\\90202836.txt");
            
            program.WordsOnString(fileStream);
            program.ToLower();
            program.UniqueWords();
            program.CountWords();


            
            var sortedWords = from p in program.wordsAndCount orderby p.count descending select p; // сортировка по убыванию


            StreamWriter sw = new StreamWriter("C:\\vs_projects\\Digital_Design\\Test.txt");
            foreach (var item in sortedWords)
            {
                sw.WriteLine(item);
            }
            sw.Close();
        }


        
        public void CountWords() // подсчёт уникальных слов и создание экземпляров класса с ними
        {
            for (int i = 0; i < uniqueWords.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < words.Count; j++)
                {
                    if (uniqueWords[i] == words[j])
                    {
                        count += 1;
                    }
                }
                wordsAndCount.Add(new Words(uniqueWords[i], count));
            }
        }
        public void UniqueWords() // отбор уникальных слов
        {
            for (int i = 0; i < words.Count; i++)
            {
                bool temp = true;
                for (int j = 0; j < uniqueWords.Count; j++)
                {
                    if (words[i] == uniqueWords[j])
                    {
                        temp = false;
                        break;
                    }
                    
                }
                if (temp)
                {
                    uniqueWords.Add(words[i]);
                }
            }
        }
        public void ToLower() // приведение к нижнему регистру
        {
            for (int i = 0; i < words.Count; i++)
            {
                words[i] = words[i].ToLower();
            }
        }
        public void WordsOnString(string fileStream) //разбиение по словам
        {
            string str = "";
            for (int i = 0; i < fileStream.Length; i++)
            {
                if (!fileStream[i].ToString().Equals(" ") && !Regex.IsMatch(fileStream[i].ToString(), @"[\+\-\/!?*0123456789vix.:;,XVI""()]+$"))
                {
                    str += fileStream[i];
                                  
                }
                else
                {
                    if (str != "")
                    {
                        words.Add(str);
                        
                        str = "";
                    }
                    else str = "";
                }

            }
            words.Add(str); // добавление последнего слова
            
        }
    }
}
