using System;
using System.Collections.Generic;
/*
 * 
 * https://ulearn.me/course/basicprogramming2/Praktika_CVS__1d5457ac-46f1-43af-b902-abfba0a0c280
   learn ci pi. Обучить клона с номером ci по программе pi.
   rollback ci. Откатить последнюю программу у клона с номером ci.
   relearn ci. Переусвоить последний откат у клона с номером ci.
   clone ci. Клонировать клона с номером ci.
   check ci. Вернуть программу, которой клон с номером ci владеет и при этом усвоил последней. Если клон владеет только базовыми знаниями, верните "basic".
 */
namespace Clones
{
    class Clone
    {
		public string Version;

		public LinkedList<string> logsLearned = new LinkedList<string>();
		public LinkedList<string> logsRemoved = new LinkedList<string>();

	}

	public class CloneVersionSystem : ICloneVersionSystem
	{
		public string Execute(string query)
		{
			var clone1 = new Clone();
			clone1.logsLearned.AddFirst("basic");
			var clone2 = new Clone();
			clone2.logsLearned.AddFirst("basic");

			var commands = query.Split(' ');
			switch (commands[0])
			{
				case "learn":
					{
                        if (commands[1]=="1")
                        {
							clone1.logsLearned.AddFirst(commands[3]);
							clone1.Version = commands[3];
                        }
                        else
                        {
							clone2.logsLearned.AddFirst(commands[3]);
							clone2.Version = commands[3];
						}
						break;
					}

				case "rollback":
					{
						if (commands[1] == "1")
						{
							clone1.logsRemoved.AddFirst(clone1.logsLearned.First.Value);
							//clone1.Version = clone1.logsLearned.First.Value;
							clone1.logsLearned.RemoveFirst();
							clone1.Version = clone1.logsLearned.First.Value;
						}
						else
						{
							clone2.logsRemoved.AddFirst(clone2.logsLearned.First.Value);
							//clone2.Version = clone2.logsLearned.First.Value;
							clone2.logsLearned.RemoveFirst();
							clone2.Version = clone2.logsLearned.First.Value;
						}
						break;
					
					}

				case "relearn":
					{
						if (commands[1] == "1")
						{
							clone1.logsLearned.AddFirst(clone1.logsRemoved.First.Value);
							clone1.logsRemoved.RemoveFirst();
							clone1.Version = clone1.logsLearned.First.Value;
						}
						else
						{

						}
						break;
						
					}

				case "clone":
					{
						if (commands[1] == "1")
						{

						}
						else
						{

						}
						break;
						
					}

				case "check":
					{
						if (commands[1] == "1")
						{
							return clone1.Version;
						}
						else
						{
							return clone2.Version;
						}
					}

				default:
					return null;
			}
			return "";
		}
	}
}
