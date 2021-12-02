using System;
using System.Collections.Generic;
/// <summary>
/// https://ulearn.me/course/basicprogramming/Poleznye_znakomstva_9a4d5ff4-2331-4bef-a3ee-88e54bec88c8
/// </summary>
namespace Полезные_знакомства
{
    class Program
    {
        static void Main(string[] args)
        {
            var sasha = new List<string>();
            sasha.Add("A:А@A.A");
            sasha.Add("Ваня:v@mail.ru");
            sasha.Add("Вася:vasiliy@gmail.com");
            sasha.Add("Ваня:ivan@grozniy.ru");
            sasha.Add("Саша:sasha1995@sasha.ru");
            sasha.Add("Саша:alex@nd.ru");
            sasha.Add("Паша:pavel.egorov@urfu.ru");
            sasha.Add("Юрий:dolg@rukiy.ru");
            sasha.Add("Гена:genadiy.the.best@inbox.ru");
            OptimizeContacts(sasha);
        }

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            string[] user = new string[2];
            foreach (var it in contacts)
            {
                user = it.Split(":");
                string shortName;
                if (user[0].Length < 2)
                    shortName = user[0];
                else
                shortName=user[0].Substring(0,2);
                if (!dictionary.ContainsKey(shortName))
                {
                    dictionary.Add(shortName, new List<string>());
                    dictionary[shortName].Add(it);
                }
                else
                    dictionary[shortName].Add(it);
            }
            return dictionary;
        }
    }
}
