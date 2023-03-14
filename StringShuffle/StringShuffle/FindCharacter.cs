using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringShuffle
{
    internal class FindCharacter
    {
        public static int countvowels()
        {
            List<char> vowels = new List<char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');

            string word = "this is my sentence";
            int count = 0;
            for(int i = 0; i < word.Length; i++)
            {
                for(int j = 0; j < vowels.Count; j++)
                {
                    if(word[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }


        public static string codedSentence()
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('a', '4');
            dic.Add('i', '1');
            dic.Add('e', '3');
            dic.Add('s', '5');
            dic.Add('o', '0');
            dic.Add('z', '2');

            string sentence = "This is my sentence";
            string str = "";
            char[] newSentence = sentence.ToArray();
            for (int i = 0; i < newSentence.Length; i++)
            {
                for (int j = 0; j < dic.Count; j++)
                {
                    if (newSentence[i] == dic.ElementAt(j).Key)
                    {
                        newSentence[i] = dic.ElementAt(j).Value!;
                    }
                }
            }
            foreach(var x in newSentence)
            {
                str = str + x;
            }
            return str;
        }
    }
}
