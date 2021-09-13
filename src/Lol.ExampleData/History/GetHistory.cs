﻿using Lol.Data.History;
using System;
using System.Collections.Generic;

namespace Lol.ExampleData.History
{
	public partial class ExamHistory
	{
		public static List<HistoryModel> GetHistory()
		{
			List<HistoryModel> source = new()
			{
				new HistoryModel {Seq = 0, Champion = "Nautilus", GameType = "개인/2인 랭크 게임", MapType = "소환사의 협곡", Result = "승리", StDt = DateTime.Now, GameTime = "25:13", Money = 6633, Cs = 30,  K = 1, D = 12, A = 5, Level = 18 },
				new HistoryModel {Seq = 1, Champion = "Nautilus", GameType = "개인/2인 랭크 게임", MapType = "소환사의 협곡", Result = "승리", StDt = DateTime.Now, GameTime = "21:13", Money = 6633, Cs = 30,  K = 1, D = 12, A = 5, Level = 9 },
				new HistoryModel {Seq = 2, Champion = "Nautilus", GameType = "개인/2인 랭크 게임", MapType = "소환사의 협곡", Result = "패배", StDt = DateTime.Now, GameTime = "24:13", Money = 6633, Cs = 30,  K = 1, D = 12, A = 5, Level = 14 },
				new HistoryModel {Seq = 3, Champion = "Nautilus", GameType = "개인/2인 랭크 게임", MapType = "소환사의 협곡", Result = "패배", StDt = DateTime.Now, GameTime = "30:13", Money = 6633, Cs = 30,  K = 1, D = 12, A = 5, Level = 7 },
			};

			return source;
		}
	}
}