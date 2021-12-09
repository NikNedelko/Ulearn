using System;
using System.Collections.Generic;
using System.Drawing;
/// <summary>
/// in process
/// https://ulearn.me/course/basicprogramming/Praktika_Khozhdenie_po_chekpointam__a0c554bb-1bb2-451e-b192-c88c87ec5147
/// </summary>
namespace RoutePlanning
{
	public static class PathFinderTask
	{
		static int bestPrice { get; set; }

		public static int[] FindBestCheckpointsOrder(Point[] checkpoints)
		{
			var bestOrder = MakeTrivialPermutation(checkpoints.Length);
			return bestOrder;
		}

		private static int[] MakeTrivialPermutation(int size)
		{
			var bestOrder = new int[size];
			for (int i = 0; i < bestOrder.Length; i++)
				bestOrder[i] = i;
			return bestOrder;
		}
	}
}