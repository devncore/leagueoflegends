﻿using Leagueoflegends.Data.Main;
using Leagueoflegends.Windowbase.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace Leagueoflegends.Options.ViewModels
{
	public class OptionsViewModel : ObservableObject
    {
        #region SortTypes

        public List<OptionModel> SortTypes { get; set; }
        #endregion

        #region CurrentSortType

        private OptionModel _currentSortType;
        public OptionModel CurrentSortType
        {
            get { return _currentSortType; }
            set { _currentSortType = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor
        public OptionsViewModel()
        {
            SortTypes = GetSortTypes();
            CurrentSortType = SortTypes.First();
        }
        #endregion

        #region GetSortTypes

        private List<OptionModel> GetSortTypes()
        {
            List<OptionModel> source = new List<OptionModel>
			{
                new OptionModel { DisplayName = "Sort Alphabetically" },
                new OptionModel { DisplayName = "Sort by Status" }
            };
            return source;
        }
		#endregion
	}
}