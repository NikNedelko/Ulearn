using System;
using System.Collections.Generic;

namespace Шифр_незнакомки
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letter = {"решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
            "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
            "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
            "если особенно упорно подойдешь к делу",
            "будет Трудно конечнО",
            "Код ведЬ не из простых",
            "очень ХОРОШИЙ код",
            "то у тебя все получится",
            "и я буДу Писать тЕбЕ еще",
            "чао",
            };
        }

        private static string DecodeMessage(string[] lines)
        {
            List<string> selecter = new List<string>();
            string result = "", helper = "", word = "";
            for (int i = 0; i < lines.Length; i++)
            {
                helper = lines[i];
                for (int j = 0; j < helper.Length; j++)
                {
                    if (helper == " ")
                    {
                        continue;
                    }
                    if (helper[j] == char.ToUpper(helper[j]) && j == 0 || helper[j] == char.ToUpper(helper[j]) && helper[j - 1] == ' ')
                    {
                        int counter = j;
                        char[] convertedHelper = helper.ToCharArray();
                        //helper[counter] != ' '
                        while (true)
                        {
                            if (convertedHelper[counter] == ' ' || counter == helper.Length - 1)
                            {
                                break;
                            }
                            word += convertedHelper[counter];
                            counter++;
                        }
                        word += " ";
                        selecter.Add(word);
                        word = "";
                    }
                }
            }
            for (int i = selecter.Count; i > 0; i--)
            {
                result += selecter[i - 1];
            }
            return result;
        }
    }

}
/*
List<string> selecter = new List<string>();
            string result = "", helper="";
            for (int i = 0; i < lines.Length; i++)
            {
                helper = lines[i];
                if (helper==" ")
                {
                    continue;
                }
                if (helper[0]==char.ToUpper(helper[0]))
                {
                    selecter.Add(helper);
                }
            }
           for (int i = selecter.Count; i >0; i--)
           {
               result+= selecter[i-1];
           }
            return result;


            string[] letter = {"решИла ", "нЕ ", "Упрощать ", "и ", "зашифРОВАтЬ ", "Все ", "послаНИЕ ", 
             "дАже ", "не ", "Старайся ", "нИЧЕГО ", "у ", "тЕбя ", "нЕ ", "получится ", "с ", "расшифРОВкой ",
            "Сдавайся ", "НЕ ", "твоего ", "ума ", "Ты ", "не ", "споСОбЕн ", "Но ", "может ", "быть ",
            "если ", "особенно ", "упорно ", "подойдешь ", "к ", "делу ",

            "будет ", "Трудно ", "конечнО ",
            "Код ", "ведЬ ", "не ", "из ", "простых ",
            "очень ", "ХОРОШИЙ ", "код ",
            "то ", "у ", "тебя ", "все ", "получится ",
            "и ", "я ", "буДу ", "Писать ", "тЕбЕ ", "еще"

            +"чао"};
*/
