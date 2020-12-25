using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Key
    {

    }

    public class Methods
    {
        public String NumberToString(int number)
        {
            Char c = (Char)(97 + (number - 1));
            return c.ToString();

        }
        public int StringToNumber(char s)
        {
            int c = (int)s % 32;
            return c;
        }
        public Char RandomChar()
        {
            var rand1 = new Random();
            return (char)rand1.Next('a', 'z');
        }

        public string Encrypt(string str)
        {
            //replace empty string with a slash
            str = str.ToLower();
            str = Regex.Replace(str, @"\s+", "/");
            //vars
            Char[] Letters = str.ToCharArray();
            var rand = new Random();
            String[] Indexes = new string[str.Length - 1];
            
            //randoms
            char randomChar = (char)rand.Next('a', 'z');

            Indexes[Indexes.Length - 1] = rand.Next(0, Indexes.Length).ToString();

            for (int i = 0; i < Letters.Length - 2; i++)
            {
               if(Letters[i] != '/')
                {
                    int index = (int)str[i] % 32;
                    //useless index = this
                    var indexOfStringByAlphabet = index.ToString();
                    
                    //randoms 
                    randomChar = (char)rand.Next('a', 'z');
                    int RandomCharIndexMultByIndex = ((int)randomChar % 32) * index;

                    //assignment
                    Indexes[i] = $"{RandomCharIndexMultByIndex}{randomChar}";
                }
                else
                {
                    //if Letters[i] is an empty string
                    Indexes[i] = " ";
                }
            }

            return string.Join("",Indexes);
        }
        public string Decrypt(string str)
        {
            //418v100t75y432x45i15c20a 65e115w228l38b20t 4 
            Char[] letters = str.ToCharArray(); 
            Char[] onlyLetters = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
			{
                 if(Char.IsLetter(str[i])){
                    onlyLetters[i] = str[i];
                }
			}
            string onlyLetters_1= string.Join("", onlyLetters);
            var lets = Regex.Matches(onlyLetters_1, @"[a-z]").Cast<Match>().Select(m => m.Value).ToArray();
            string[] final = new string[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                string b = string.Empty;
                if (Char.IsDigit(str[i]))
                {
                    b = String.Join("", str[i].ToString().Where(char.IsDigit));
                    Console.WriteLine(int.Parse(b) * 2);

                }
            }
            return "!";
        }

    }
}
    