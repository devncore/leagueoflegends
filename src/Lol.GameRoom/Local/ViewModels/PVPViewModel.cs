﻿using System;
using System.Windows;
using System.Collections.Generic;
using Lol.Foundation.Mvvm;
using Lol.YamlDatabase.Controller;
using Lol.YamlDatabase.Entites.Schema;

namespace Lol.GameRoom.Local.ViewModels
{
    public class PVPViewModel : ObservableObject
    {
        public event EventHandler CreateButtonClicked;
        private GameRooms _currentPVP;
        public List<GameRooms> PVPs { get; set; }
        public RelayCommand<object> ButtonRoomCreate { get; set; }

        #region CurrentPVP

        public GameRooms CurrentPVP
        {
            get { return _currentPVP; }
            set { _currentPVP = value; OnPropertyChanged(); }
        }
        #endregion

        #region Constructor

        public PVPViewModel()
        {
            PVPs = new GameRoomApi().GetGameRooms();
            _currentPVP = PVPs[0];
            ButtonRoomCreate = new RelayCommand<object>(ButtonRoomCreateCmd, CanButtonRoomCreateCmd);
        }
        #endregion

        private void ButtonRoomCreateCmd(object obj)
        {
            RoutedEventArgs a = new();
            OnCloseButtonClicked(a);
        }

        private bool CanButtonRoomCreateCmd(object obj)
        {
            return true;
        }

        protected virtual void OnCloseButtonClicked(EventArgs e)
        {
            CreateButtonClicked?.Invoke(this, e);
        }
    }
}