using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4kyu
{
    public class StringsMixTask
    {
        public static string Mix(string s1, string s2)
        {
            var s1Letters = AddLetters(s1.ToCharArray());
            var s2Letters = AddLetters(s2.ToCharArray());

            var results = new List<string>();

            var allKeys = s1Letters.Keys.Union(s2Letters.Keys);

            foreach (var key in allKeys)
            {
                int countS1 = s1Letters.ContainsKey(key) ? s1Letters[key] : 0;
                int countS2 = s2Letters.ContainsKey(key) ? s2Letters[key] : 0;

                if (countS1 <= 1 && countS2 <= 1) continue;

                if (countS1 > countS2)
                {
                    results.Add($"1:{new string(key, countS1)}");
                }
                else if (countS2 > countS1)
                {
                    results.Add($"2:{new string(key, countS2)}");
                }
                else
                {
                    results.Add($"=:{new string(key, countS1)}");
                }
            }

            results = results
                .OrderByDescending(r => r.Length)        
                .ThenBy(r => r[0])                        
                .ThenBy(r => r[2])                       
                .ToList();

            return string.Join("/", results);
        }

        private static Dictionary<char, int> AddLetters(char[] letters)
        {
            var boxForLetters = new Dictionary<char, int>();

            foreach (var letter in letters) 
            {
                if (char.IsLetter(letter) && char.IsLower(letter))
                {
                    if (boxForLetters.ContainsKey(letter))
                    {
                        boxForLetters[letter]++;
                    }
                    else
                    {
                        boxForLetters.Add(letter, 1);
                    }
                }
            }

            return boxForLetters;
        }
    }
}
//https://www.codewars.com/kata/5629db57620258aa9d000014/train/csharp