
﻿// Sample.Plugin ~ SettingsViewModel.cs
// SettingsViewModel.cs
//
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FFXIVAPP.Common.Events;
using FFXIVAPP.Common.Models;
using FFXIVAPP.Common.ViewModelBase;
using ffxivmc.Plugin.Views;

namespace ffxivmc.Plugin.ViewModels
{
    internal sealed class SettingsViewModel : INotifyPropertyChanged
    {


        #region Declarations

        public ICommand ClearChatLogCommand { get; private set; }

        #endregion

        #region Command Bindings

        #endregion

        #region Property Bindings

        private static SettingsViewModel _instance;

        public static SettingsViewModel Instance
        {
            get { return _instance ?? (_instance = new SettingsViewModel()); }
        }

        #endregion

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
