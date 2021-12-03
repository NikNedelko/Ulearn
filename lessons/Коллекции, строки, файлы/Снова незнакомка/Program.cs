using System;
using System.Text;

namespace Снова_незнакомка
{
    /// <summary>
    /// https://ulearn.me/course/basicprogramming/Snova_neznakomka_741d39bd-d543-40d2-abbc-941c7f778106
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var text = new string[] {"push Привет! Это снова я! Пока!"
            ,"pop 5",
            "push Как твои успехи? Плохо?",
            "push qwertyuiop",
            "push 1234567890",
            "pop 26"};
            /// ....
            ApplyCommands(text);
        }

        private static string ApplyCommands(string[] commands)
        {
            var builder = new StringBuilder();
            string result = "";
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i].Substring(0, 4) == "push")
                    builder.Append(commands[i].Substring(5));
                else
                    builder.Remove(builder.Length - Convert.ToInt32(commands[i].Substring(4)),
                    Convert.ToInt32(commands[i].Substring(4)));
            }

            return result=builder.ToString();
        }

    }
}
