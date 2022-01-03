/*
using System;

using System.Collections.Generic;
/*
   learn ci pi. Обучить клона с номером ci по программе pi.
   rollback ci. Откатить последнюю программу у клона с номером ci.
   relearn ci. Переусвоить последний откат у клона с номером ci.
   clone ci. Клонировать клона с номером ci.
   check ci. Вернуть программу, которой клон с номером ci владеет и при этом усвоил последней. Если клон владеет только базовыми знаниями, верните "basic".
 
//namespace Clones
{
	//class Clone
	{
		public int Version;
		public int Number;
		private LinkedList<string> logs = new LinkedList<string>();

		public Clone()
		{

		}

	}

	//public class CloneVersionSystem : ICloneVersionSystem
	{            //        id    command
		private Dictionary<int, string> dictFirstClone = new Dictionary<int, string>();
		private Dictionary<int, string> dictSecondClone = new Dictionary<int, string>();
		private Dictionary<string, string> dictCommands = new Dictionary<string, string>();

		private LinkedList<string> logsFirst = new LinkedList<string>();
		private LinkedList<string> logsSecond = new LinkedList<string>();

		private LinkedList<string> idFirstAndCommandLogs = new LinkedList<string>();
		private LinkedList<string> idSecondAndCommandLogs = new LinkedList<string>();

		public string Execute(string query)
		{
			var commands = query.Split(' ');

			switch (commands[0])
			{
				case "learn":
					{
						if (commands[1] == "2")
						{
							if (dictSecondClone.ContainsKey(Convert.ToInt32(commands[1])))
							{
								idSecondAndCommandLogs.AddFirst(commands[1] + " " + dictSecondClone[Convert.ToInt32(commands[1])]);//cloneLogs
								logsSecond.AddFirst("Learn " + commands[1] + " " + commands[2]);//logs

								dictSecondClone.Remove(Convert.ToInt32(commands[1]));
								dictSecondClone.Add(Convert.ToInt32(commands[1]), commands[2]);

								break;
							}
							dictSecondClone.Add(Convert.ToInt32(commands[1]), commands[2]);
							logsSecond.AddFirst("Learn " + commands[1] + " " + commands[2]);//logs
							break;
						}
						else
						{
							if (dictFirstClone.ContainsKey(Convert.ToInt32(commands[1])))
							{
								idFirstAndCommandLogs.AddFirst(commands[1] + " " + dictFirstClone[Convert.ToInt32(commands[1])]);//cloneLogs
								logsFirst.AddFirst("Learn " + commands[1] + " " + commands[2]);//logs

								dictFirstClone.Remove(Convert.ToInt32(commands[1]));
								dictFirstClone.Add(Convert.ToInt32(commands[1]), commands[2]);

								break;
							}
							dictFirstClone.Add(Convert.ToInt32(commands[1]), commands[2]);
							logsFirst.AddFirst("Learn " + commands[1] + " " + commands[2]);//logs
							break;
						}
					}

				case "rollback":
					{
						if (commands[2] == "2")
						{
							logsSecond.RemoveFirst();
							Execute(logsFirst.First.Value);
							logsSecond.RemoveFirst();
							break;
						}
						else
						{
							logsFirst.RemoveFirst();
							Execute(logsFirst.First.Value);
							logsFirst.RemoveFirst();
							break;
						}
					}


				case "relearn":
					{

						break;
					}

				case "clone":
					{
						break;
					}

				case "check":
					{
						TakeInfo(Convert.ToInt32(commands[1]));
						break;
					}

				default:
					return null;
			}

			return null;
		}
		private string TakeInfo(int id)
		{
			return dictFirstClone[id];
		}

		private string BackUp(int id)
		{
			return "";
		}
	}
}
*/